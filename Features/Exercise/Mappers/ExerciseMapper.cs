using KryptonApi.Features.Exercise.List;

namespace KryptonApi.Features.Exercise.Mappers;

public static class ExerciseMapper
{
    public static Exercise MapToEntity(ListExerciseResponse response)
    {
        var exercise = new Exercise
        {
            Id = response.Id,
            Name = response.Name,
            Category = response.Category,
            MuscleGroup = response.MuscleGroup,
            Equipment = response.Equipment,
            Description = response.Description,
            IsActive = response.IsActive,
            CreatedAt = response.CreatedAt,
            UpdatedAt = response.UpdatedAt
        };

        return exercise;
    }

    public static ListExerciseResponse MapToResponse(Exercise exercise)
    {
        var response = new ListExerciseResponse
        {
            Id = exercise.Id,
            Name = exercise.Name,
            Category = exercise.Category,
            MuscleGroup = exercise.MuscleGroup,
            Equipment = exercise.Equipment,
            Description = exercise.Description,
            IsActive = exercise.IsActive,
            CreatedAt = exercise.CreatedAt,
            UpdatedAt = exercise.UpdatedAt
        };

        return response;
    }
}