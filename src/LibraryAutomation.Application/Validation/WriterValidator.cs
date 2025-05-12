using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;

public class WriterValidator : AbstractValidator<Writer>
{
    public WriterValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Ad alanı zorunludur.")
            .MaximumLength(128).WithMessage("Ad alanı en fazla 128 karakter olabilir.");

        RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Soyad alanı zorunludur.")
            .MaximumLength(128).WithMessage("Soyad alanı en fazla 128 karakter olabilir.");

        RuleFor(x => x.BirthDate)
            .NotEmpty().WithMessage("Doğum tarihi alanı zorunludur.")
            .LessThan(DateTime.Now).WithMessage("Doğum tarihi geçmiş bir tarih olmalıdır.");

        RuleFor(x => x.DeathDate)
            .LessThan(DateTime.Now).WithMessage("Ölüm tarihi geçmiş bir tarih olmalıdır.")
            .GreaterThan(x => x.BirthDate).WithMessage("Ölüm tarihi doğum tarihinden sonra olmalıdır.");
    }
}
