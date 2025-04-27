using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Validation;

public class TranslatorValidator : AbstractValidator<Translator>
{
    public TranslatorValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(64).WithMessage("Name must not exceed 64 characters.");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Surname is required.")
            .MaximumLength(64).WithMessage("Surname must not exceed 64 characters.");

        RuleFor(x => x.BirthDate)
            .NotEmpty().WithMessage("Birth date is required.")
            .LessThan(DateTime.Now).WithMessage("Birth date must be in the past.");

        RuleFor(x => x.DeathDate)
            .LessThan(DateTime.Now).WithMessage("Death date must be in the past.")
            .GreaterThan(x => x.BirthDate).WithMessage("Death date must be after birth date.");
    }
}
