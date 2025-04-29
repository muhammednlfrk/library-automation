using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAutomation.Domain.Entities;

public sealed class BooksWriter : EntityBase
{
    [NotMapped]
    public override int Id { get => base.Id; set => base.Id = value; }

    public int WriterId { get; set; }

    public Writer? Writer { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }
}
