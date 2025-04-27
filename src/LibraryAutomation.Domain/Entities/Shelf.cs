namespace LibraryAutomation.Domain.Entities;

public sealed class Shelf : EntityBase
{
    public required string Name { get; set; }

    public required string Description { get; set; }

    public ICollection<Book>? Books { get; set; }
}
