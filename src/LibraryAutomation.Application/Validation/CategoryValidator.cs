using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Category name is required.")
            .MaximumLength(64).WithMessage("Category name must not exceed 64 characters.");
    }
}