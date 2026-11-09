using KryptonApi.Features.Exercise.Mappers;
using KryptonApi.Features.Exercise.Repository.Interface;

namespace KryptonApi.Features.Exercise.List;

public class ListExerciseHandler
{
    private readonly IExerciseRepository _repository;

    public ListExerciseHandler(IExerciseRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<ListExerciseResponse>> GetExercisesAsync(ListExerciseRequest request, CancellationToken cancellationToken)
    {
        var exercises = await _repository.GetExerciseAsync(request, cancellationToken);

        return exercises.Select(ExerciseMapper.MapToResponse);
    }
}