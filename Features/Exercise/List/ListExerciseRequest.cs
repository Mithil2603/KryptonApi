using KryptonApi.Features.Exercise.Enums;

namespace KryptonApi.Features.Exercise.List;

public class ListExerciseRequest
{
    public string? Name { get; set; }

    public CategoryEnum? Category { get; set; }

    public MuscleGroupEnum? MuscleGroup { get; set; }

    public EquipmentEnum? Equipment { get; set; }

    public bool? IsActive { get; set; }
}