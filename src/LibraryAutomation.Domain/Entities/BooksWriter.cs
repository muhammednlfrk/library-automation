namespace LibraryAutomation.Domain.Entities;

public sealed class BooksWriter : EntityBase
{
    public int WriterId { get; set; }

    public Writer? Writer { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }
}
