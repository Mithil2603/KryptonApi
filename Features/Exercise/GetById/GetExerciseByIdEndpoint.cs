using Microsoft.AspNetCore.Mvc;

namespace KryptonApi.Features.Exercise.GetById
{
    [ApiController]
    [Route("exercise")]
    public class GetExerciseByIdEndpoint : ControllerBase
    {
        private readonly GetExerciseByIdHandler _handler;

        public GetExerciseByIdEndpoint(GetExerciseByIdHandler handler)
        {
            _handler = handler;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExerciseById([FromRoute] GetExerciseByIdRequest request, CancellationToken cancellationToken)
        {
            var response = await _handler.GetExercise(request, cancellationToken);

            if (response == null) return NotFound();

            return Ok(response);
        }
    }
}