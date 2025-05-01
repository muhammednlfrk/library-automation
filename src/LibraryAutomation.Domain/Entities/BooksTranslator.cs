using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAutomation.Domain.Entities;

public sealed class BooksTranslator : EntityBase
{
    [NotMapped]
    public override int Id { get => base.Id; set => base.Id = value; }

    public int TranslatorId { get; set; }

    public Translator? Translator { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }
}
