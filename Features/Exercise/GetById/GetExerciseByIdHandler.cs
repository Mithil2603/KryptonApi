using KryptonApi.Features.Exercise.Mappers;
using KryptonApi.Features.Exercise.Repository.Interface;

namespace KryptonApi.Features.Exercise.GetById;

public class GetExerciseByIdHandler
{
    private readonly IExerciseRepository _repository;

    public GetExerciseByIdHandler(IExerciseRepository repository)
    {
        _repository = repository;
    }

    public async Task<GetExerciseByIdResponse?> GetExercise(GetExerciseByIdRequest request, CancellationToken cancellationToken)
    {
        var exercise = await _repository.GetExerciseAsync(request, cancellationToken);

        if (exercise == null) return null;

        return ExerciseMapper.MapToGetByIdResponse(exercise);
    }
}