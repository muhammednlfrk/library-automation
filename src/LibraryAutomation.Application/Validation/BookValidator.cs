using FluentValidation;
using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.ApplicationL.Validation;

public class BookValidator : AbstractValidator<Book>
{
    public BookValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Kitap adı zorunludur.")
            .Length(1, 532).WithMessage("Kitap adı 1 ile 532 karakter arasında olmalıdır.");

        RuleFor(x => x.OriginName)
            .NotEmpty().WithMessage("Kitabın orijinal adı en fazla 532 karakter olabilir.")
            .Length(1, 532).WithMessage("Kitabın orijinal adı en fazla 532 karakter olabilir.");

        RuleFor(x => x.PublishDate)
            .NotEmpty().WithMessage("Yayın tarihi zorunludur.")
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Kitap yayın tarihi gelecekte olamaz.");

        RuleFor(x => x.PageCount)
            .NotEmpty().WithMessage("Sayfa sayısı zorunludur.")
            .GreaterThan(0).WithMessage("Kitap sayfa sayısı 0'dan büyük olmalıdır.");

        RuleFor(x => x.ISBN)
            .NotEmpty().WithMessage("ISBN zorunludur.")
            .Length(10, 13).WithMessage("Kitap ISBN'i 10 ile 13 karakter arasında olmalıdır.");

        RuleFor(x => x.StockQuantity)
            .NotEmpty().WithMessage("Stok miktarı zorunludur.")
            .GreaterThanOrEqualTo(0).WithMessage("Kitap stok miktarı 0'dan büyük veya eşit olmalıdır.");

        RuleFor(x => x.BorrowQuantity)
            .NotEmpty().WithMessage("Ödünç verilen miktar zorunludur.")
            .GreaterThanOrEqualTo(0).WithMessage("Kitap ödünç verilen miktarı 0'dan büyük veya eşit olmalıdır.");
    }
}
