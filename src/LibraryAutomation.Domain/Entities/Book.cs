namespace LibraryAutomation.Domain.Entities;

public sealed class Book : EntityBase
{
    public string? Name { get; set; }

    public string? OriginName { get; set; }

    public DateTime? PublishDate { get; set; }

    public int PageCount { get; set; }

    public string? ISBN { get; set; }

    public int StockQuantity { get; set; }

    public int BorrowQuantity { get; set; }

    public int PublisherId { get; set; }

    public Publisher? Publisher { get; set; }

    public int LanguageId { get; set; }

    public Language? Language { get; set; }

    public int OriginalLanguageId { get; set; }

    public Language? OriginalLanguage { get; set; }

    public int ShelfId { get; set; }

    public Shelf? Shelf { get; set; }

    public ICollection<Writer>? Writers { get; set; }

    public ICollection<BooksWriter>? BooksWriters { get; set; }

    public ICollection<Translator>? Translators { get; set; }

    public ICollection<BooksTranslator>? BooksTranslators { get; set; }

    public ICollection<Category>? Categories { get; set; }

    public ICollection<BooksCategories>? BooksCategories { get; set; }

    public ICollection<Borrow>? Borrows { get; set; }
}
