using FluentValidation;

namespace CraftShopAPI.Domain.Validators
{
    public class ChairValidator : FluentValidation.AbstractValidator<Entities.Chair>
    {
        public ChairValidator()
        {
            RuleFor(chair => chair.Name)
                .NotEmpty().WithMessage("Chair name is required.")
                .MaximumLength(100).WithMessage("Chair name cannot exceed 100 characters.");
            RuleFor(chair => chair.Material)
                .MaximumLength(50).WithMessage("Material cannot exceed 50 characters.");
            RuleFor(chair => chair.Color)
                .MaximumLength(30).WithMessage("Color cannot exceed 30 characters.");
            RuleFor(chair => chair.NumberOfLegs)
                .GreaterThan(0).WithMessage("Number of legs must be greater than zero.");
            RuleFor(chair => chair.Style)
                .MaximumLength(50).WithMessage("Style cannot exceed 50 characters.");
        }
    }
}
