using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Validation;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Book name cannot be empty.")
            .Length(1, 532).WithMessage("Book name must be between 1 and 532 characters.");

        RuleFor(x => x.OriginName)
            .NotEmpty().WithMessage("Book origin name cannot be empty.")
            .Length(1, 532).WithMessage("Book origin name must be between 1 and 532 characters.");

        RuleFor(x => x.PublishDate)
            .NotEmpty().WithMessage("Book publish date cannot be empty.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Book publish date cannot be in the future.");

        RuleFor(x => x.PageCount)
            .NotEmpty().WithMessage("Book page count cannot be empty.")
            .GreaterThan(0).WithMessage("Book page count must be greater than 0.");

        RuleFor(x => x.ISBN)
            .NotEmpty().WithMessage("Book ISBN cannot be empty.")
            .Length(10, 13).WithMessage("Book ISBN must be between 10 and 13 characters.")
            .Matches(@"^\d{9}[\dX]$").WithMessage("Book ISBN must be a valid ISBN-10 or ISBN-13 format.");

        RuleFor(x => x.StockQuantity)
            .NotEmpty().WithMessage("Book stock quantity cannot be empty.")
            .GreaterThanOrEqualTo(0).WithMessage("Book stock quantity must be greater than or equal to 0.");

        RuleFor(x => x.BorrowQuantity)
            .NotEmpty().WithMessage("Book borrow quantity cannot be empty.")
            .GreaterThanOrEqualTo(0).WithMessage("Book borrow quantity must be greater than or equal to 0.");
    }
}
