using KryptonApi.Features.Exercise.Create;
using KryptonApi.Features.Exercise.Entities;
using KryptonApi.Features.Exercise.GetById;
using KryptonApi.Features.Exercise.List;

namespace KryptonApi.Features.Exercise.Repository.Interface;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercises>> GetExerciseListAsync(ListExerciseRequest request, CancellationToken cancellationToken);

    Task<Exercises?> GetExerciseAsync(GetExerciseByIdRequest request, CancellationToken cancellationToken);

    Task<Exercises> CreateExerciseAsync(CreateExerciseRequest request, CancellationToken cancellationToken);
}