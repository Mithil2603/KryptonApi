using System.ComponentModel.DataAnnotations;
using KryptonApi.Features.Exercise.Enums;

namespace KryptonApi.Features.Exercise.Create;

public class CreateExerciseRequest
{
    [Required]
    public string Name { get; set; } = null!;

    [EnumDataType(typeof(CategoryEnum))]
    public CategoryEnum Category { get; set; }

    [EnumDataType(typeof(MuscleGroupEnum))]
    public MuscleGroupEnum MuscleGroup { get; set; }

    [EnumDataType(typeof(EquipmentEnum))]
    public EquipmentEnum Equipment { get; set; }

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;
}