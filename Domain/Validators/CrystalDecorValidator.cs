using FluentValidation;

namespace CraftShopAPI.Domain.Validators
{
    public class CrystalDecorValidator : FluentValidation.AbstractValidator<Entities.CrystalDecor>
    {
        public CrystalDecorValidator()
        {
            RuleFor(decor => decor.Name)
                .NotEmpty().WithMessage("Crystal decor name is required.")
                .MaximumLength(100).WithMessage("Crystal decor name cannot exceed 100 characters.");
            RuleFor(decor => decor.CrystalType)
                .NotEmpty().WithMessage("Crystal type is required.")
                .MaximumLength(50).WithMessage("Crystal type cannot exceed 50 characters.");
            RuleFor(decor => decor.Color)
                .MaximumLength(30).WithMessage("Color cannot exceed 30 characters.");
            RuleFor(decor => decor.Shape)
                .MaximumLength(50).WithMessage("Shape cannot exceed 50 characters.");
        }
    }
}
