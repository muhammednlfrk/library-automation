using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;

public class BorrowValidator : AbstractValidator<Borrow>
{
    public BorrowValidator()
    {
        RuleFor(b => b.BorrowDate)
            .NotEmpty().WithMessage("Ödünç alma tarihi zorunludur.");

        RuleFor(b => b.ReturnDate)
            .NotEmpty().WithMessage("İade tarihi zorunludur.")
            .GreaterThan(b => b.BorrowDate).WithMessage("İade tarihi, ödünç alma tarihinden sonra olmalıdır.");

        RuleFor(b => b.IsDelivered)
            .NotNull().WithMessage("Teslim durumu zorunludur.");
    }
}
