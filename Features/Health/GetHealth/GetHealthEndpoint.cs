using Microsoft.AspNetCore.Mvc;

namespace KryptonApi.Features.Health.GetHealth;

[ApiController]
[Route("api/health")]
public class GetHealthEndpoint(GetHealthHandler getHealthHandler) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetHealth(CancellationToken cancellationToken)
    {
        var response = await getHealthHandler.HandleAsync(cancellationToken);
        return Ok(response);
    }
}