using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Validation;

public class ShelfValidator : AbstractValidator<Shelf>
{
    public ShelfValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Shelf name cannot be empty.")
            .MaximumLength(64).WithMessage("Shelf name cannot exceed 50 characters.");

        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Shelf description cannot exceed 500 characters.");
    }
}
