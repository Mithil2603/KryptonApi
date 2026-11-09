namespace KryptonApi.Features.Exercise.Queries;

internal partial class GetAllExercisesQuery
{
    internal const string List = @"
        SELECT * FROM exercises;
    ";
}