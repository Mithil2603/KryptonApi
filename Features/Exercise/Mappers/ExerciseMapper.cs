using KryptonApi.Features.Exercise.Entities;
using KryptonApi.Features.Exercise.List;

namespace KryptonApi.Features.Exercise.Mappers;

public static class ExerciseMapper
{
    public static Exercises MapToEntity(ListExerciseResponse response)
    {
        var exercise = new Exercises
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

    public static ListExerciseResponse MapToResponse(Exercises exercise)
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