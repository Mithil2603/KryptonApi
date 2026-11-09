
namespace KryptonApi.Features.Exercise.Repository.Interface;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercise>> GetExerciseAsync(CancellationToken cancellationToken);
}