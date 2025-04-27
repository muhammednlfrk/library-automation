namespace LibraryAutomation.Domain.Entities;

public sealed class BooksCategories
{
    public int BookId { get; set; }

    public Book? Book { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
