namespace LibraryAutomation.Domain.Entities;

public sealed class Translator : EntityBase
{
    public required string Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? DeathDate { get; set; }

    public ICollection<Book>? Books { get; set; }
}