namespace LibraryAutomation.Domain.Entities;

public sealed class Language : EntityBase
{
    public required string Key { get; set; }

    public required string NameTR { get; set; }

    public ICollection<Book>? Books { get; set; }

    public ICollection<Book>? BooksWithOriginalLanguage { get; set; }
}
