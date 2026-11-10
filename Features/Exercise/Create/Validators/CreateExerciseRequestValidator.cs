using FluentValidation;
using KryptonApi.Features.Exercise.Enums;

namespace KryptonApi.Features.Exercise.Create.Validators;

public class CreateExerciseRequestValidator : AbstractValidator<CreateExerciseRequest>
{
    public CreateExerciseRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Exercise name is required.").MaximumLength(100).WithMessage("Exercise name cannot be longer than 100 characters.").MinimumLength(2).WithMessage("Enter a valid exercise name");

        RuleFor(x => x.Category).IsInEnum();

        RuleFor(x => x.MuscleGroup).IsInEnum();

        RuleFor(x => x.Equipment).IsInEnum();

        RuleFor(x => x.Description).MaximumLength(1000);
    }
}