using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryAutomation.Domain.Entities;

public sealed class Writer : EntityBase
{
    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime? BirthDate { get; set; }

    public DateTime? DeathDate { get; set; }

    public ICollection<Book>? Books { get; set; }

    [NotMapped]
    public string FullName => $"{Name} {Surname}";
}
