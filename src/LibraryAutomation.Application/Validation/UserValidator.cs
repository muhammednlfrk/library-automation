using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(user => user.Name)
            .NotEmpty().WithMessage("Ad alanı zorunludur.")
            .MaximumLength(64).WithMessage("Ad alanı en fazla 128 karakter olabilir.");

        RuleFor(user => user.Surname)
            .NotEmpty().WithMessage("Soyad alanı zorunludur.")
            .MaximumLength(64).WithMessage("Soyad alanı en fazla 128 karakter olabilir.");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("E-posta alanı zorunludur.")
            .EmailAddress().WithMessage("Geçersiz e-posta formatı.")
            .MaximumLength(320).WithMessage("E-posta alanı en fazla 256 karakter olabilir.");

        RuleFor(user => user.Username)
            .NotEmpty().WithMessage("Kullanıcı adı alanı zorunludur.")
            .MaximumLength(32).WithMessage("Kullanıcı adı alanı en fazla 128 karakter olabilir.");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Şifre alanı zorunludur.");

        RuleFor(user => user.UserGroup)
            .NotNull().WithMessage("Kullanıcı grubu zorunludur.")
            .IsInEnum().WithMessage("Geçersiz Kullanıcı Grubu değeri.");
    }
}
