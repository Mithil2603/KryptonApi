using KryptonApi.Features.Exercise.Entities;
using KryptonApi.Features.Exercise.List;

namespace KryptonApi.Features.Exercise.Repository.Interface;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercises>> GetExerciseAsync(ListExerciseRequest request, CancellationToken cancellationToken);
}