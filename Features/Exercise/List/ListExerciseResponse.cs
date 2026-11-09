using KryptonApi.Features.Exercise.Enums;

namespace KryptonApi.Features.Exercise.List;

public class ListExerciseResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public CategoryEnum Category { get; set; }

    public MuscleGroupEnum MuscleGroup { get; set; }

    public EquipmentEnum Equipment { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}