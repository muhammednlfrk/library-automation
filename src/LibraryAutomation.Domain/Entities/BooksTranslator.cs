namespace LibraryAutomation.Domain.Entities;
public sealed class BooksTranslator : EntityBase
{
    public int TranslatorId { get; set; }

    public Translator? Translator { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }
}
