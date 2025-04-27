using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Validation;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(user => user.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MaximumLength(64).WithMessage("Name must not exceed 64 characters.");

        RuleFor(user => user.Surname)
            .NotEmpty().WithMessage("Surname is required.")
            .MaximumLength(64).WithMessage("Surname must not exceed 64 characters.");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email format.")
            .MaximumLength(320).WithMessage("Email must not exceed 320 characters.");

        RuleFor(user => user.Username)
            .NotEmpty().WithMessage("Username is required.")
            .MaximumLength(32).WithMessage("Username must not exceed 32 characters.");

        RuleFor(user => user.Password)
            .NotEmpty().WithMessage("Password is required.");

        RuleFor(user => user.UserGroup)
            .NotNull().WithMessage("UserGroup is required.")
            .IsInEnum().WithMessage("Invalid UserGroup value.");
    }
}
