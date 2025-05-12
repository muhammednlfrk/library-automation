using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;
public class PublisherValidator : AbstractValidator<Publisher>
{
    public PublisherValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Yayınevi adı zorunludur.")
            .MaximumLength(256).WithMessage("Yayınevi adı en fazla 256 karakter olabilir.");
    }
}
