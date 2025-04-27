namespace LibraryAutomation.Domain.Entities;

public sealed class Publisher : EntityBase
{
    public required string Name { get; set; }

    public ICollection<Book>? Books { get; set; }
}
