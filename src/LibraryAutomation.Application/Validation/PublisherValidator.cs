using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;
public class PublisherValidator : AbstractValidator<Publisher>
{
    public PublisherValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Publisher name is required.")
            .MaximumLength(128).WithMessage("Publisher name must not exceed 128 characters.");
    }
}
