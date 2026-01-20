using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace CraftShopAPI.Domain.Validators
{
    public class LampValidator : FluentValidation.AbstractValidator<Entities.Lamp>
    {
        public LampValidator() 
        { 
                RuleFor(lamp => lamp.Name)
                    .NotEmpty().WithMessage("Lamp name is required.")
                    .MaximumLength(100).WithMessage("Lamp name cannot exceed 100 characters.");
                RuleFor(lamp => lamp.Material)
                    .MaximumLength(50).WithMessage("Material cannot exceed 50 characters.");
                RuleFor(lamp => lamp.Color)
                    .MaximumLength(30).WithMessage("Color cannot exceed 30 characters.");
                RuleFor(lamp => lamp.BulbType)
                    .MaximumLength(50).WithMessage("Bulb type cannot exceed 50 characters.");
                RuleFor(lamp => lamp.ShadeShape)
                    .MaximumLength(50).WithMessage("Shade shape cannot exceed 50 characters.");


        }

    }
}
