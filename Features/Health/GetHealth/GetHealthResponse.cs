namespace KryptonApi.Features.Health.GetHealth;

public class GetHealthResponse
{
    public required string Status { get; set; } = string.Empty;

    public required string Database { get; set; } = string.Empty;
}