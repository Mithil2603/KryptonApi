namespace KryptonApi.Features.Exercise.Queries;

internal partial class GetExerciseById
{
    internal const string exercise = @"
        SELECT * FROM exercises WHERE Id = @id
    ";
}