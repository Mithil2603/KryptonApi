using Dapper;
using Npgsql;

namespace KryptonApi.Features.Health.GetHealth;

public sealed class GetHealthHandler(NpgsqlDataSource dataSource)
{
    public async Task<GetHealthResponse> HandleAsync(CancellationToken cancellationToken)
    {
        await using var connection = await dataSource.OpenConnectionAsync(cancellationToken);

        var version = await connection.ExecuteScalarAsync<string>(
            new CommandDefinition("SELECT version();", cancellationToken: cancellationToken)
        );

        return new GetHealthResponse
        {
            Status = "Healthy",
            Database = version ?? "Unknown",
        };
    }
}