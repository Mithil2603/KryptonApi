# Applies all .sql files in Databases/Migrations that haven't been run yet.
# Usage: .\Databases\migrate.ps1

$Container = "krypton-db"
$DbUser    = "krypton"
$DbName    = "krypton"
$MigrationsDir = Join-Path $PSScriptRoot "Migrations"

# Ensure the tracking table exists.
$trackingTableSql = "CREATE TABLE IF NOT EXISTS schema_migrations (filename TEXT PRIMARY KEY, applied_at TIMESTAMP NOT NULL DEFAULT NOW());"
$trackingTableSql | docker exec -i $Container psql -U $DbUser -d $DbName | Out-Null

# Get list of already-applied migrations.
$applied = docker exec -i $Container psql -U $DbUser -d $DbName -t -A -c "SELECT filename FROM schema_migrations;"
$appliedSet = @{}
foreach ($line in $applied -split "`n") {
    $trimmed = $line.Trim()
    if ($trimmed) { $appliedSet[$trimmed] = $true }
}

$files = Get-ChildItem -Path $MigrationsDir -Filter "*.sql" | Sort-Object Name

$ranAny = $false
foreach ($file in $files) {
    if ($appliedSet.ContainsKey($file.Name)) {
        Write-Host "Skipping $($file.Name) (already applied)" -ForegroundColor DarkGray
        continue
    }

    Write-Host "Applying $($file.Name)..." -ForegroundColor Cyan
    Get-Content $file.FullName -Raw | docker exec -i $Container psql -U $DbUser -d $DbName --set ON_ERROR_STOP=1

    if ($LASTEXITCODE -ne 0) {
        Write-Host "Migration $($file.Name) FAILED. Stopping." -ForegroundColor Red
        exit 1
    }

    $escapedName = $file.Name.Replace("'", "''")
    "INSERT INTO schema_migrations (filename) VALUES ('$escapedName');" | docker exec -i $Container psql -U $DbUser -d $DbName | Out-Null

    Write-Host "Applied $($file.Name)" -ForegroundColor Green
    $ranAny = $true
}

if (-not $ranAny) {
    Write-Host "Nothing to do - database is up to date." -ForegroundColor Yellow
}
