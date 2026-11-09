using Microsoft.AspNetCore.Mvc;

namespace KryptonApi.Features.Exercise.List;

[ApiController]
[Route("exercise")]
public class ListExerciseEndpoint : ControllerBase
{
    private readonly ListExerciseHandler _exerciseHandler;

    public ListExerciseEndpoint(ListExerciseHandler exerciseHandler)
    {
        _exerciseHandler = exerciseHandler;
    }

    [HttpGet]
    public async Task<IActionResult> GetExercisesAsync(CancellationToken cancellationToken)
    {
        var response = await _exerciseHandler.GetExercisesAsync(cancellationToken);

        return Ok(response);
    }
}