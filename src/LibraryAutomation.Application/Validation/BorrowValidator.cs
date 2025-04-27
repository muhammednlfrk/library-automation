using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Validation;

public class BorrowValidator : AbstractValidator<Borrow>
{
    public BorrowValidator()
    {
        RuleFor(b => b.BorrowDate)
            .NotEmpty().WithMessage("Borrow date is required.");

        RuleFor(b => b.ReturnDate)
            .NotEmpty().WithMessage("Return date is required.")
            .GreaterThan(b => b.BorrowDate).WithMessage("Return date must be after the borrow date.");

        RuleFor(b => b.IsDelivered)
            .NotNull().WithMessage("IsDelivered status is required.");
    }
}
