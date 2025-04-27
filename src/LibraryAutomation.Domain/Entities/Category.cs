namespace LibraryAutomation.Domain.Entities;

public sealed class Category : EntityBase
{
    public required string Name { get; set; }

    public ICollection<Book>? Books { get; set; }
}