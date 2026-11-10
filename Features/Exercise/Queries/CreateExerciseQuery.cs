namespace KryptonApi.Features.Exercise.Queries;

internal partial class CreateExerciseQuery
{
    internal const string create = @"
        INSERT INTO exercises (name, category, muscle_group, equipment, description, is_active) VALUES (@Name, @Category, @MuscleGroup, @Equipment, @Description, @IsActive) RETURNING *;
    ";
}