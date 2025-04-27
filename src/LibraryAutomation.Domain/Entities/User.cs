using LibraryAutomation.Domain.Enums;

namespace LibraryAutomation.Domain.Entities;

public sealed class User : EntityBase
{
    public required string Name { get; set; }

    public required string Surname { get; set; }

    public required string Email { get; set; }

    public required string Username { get; set; }

    public required string Password { get; set; }

    public required UserGroup UserGroup { get; set; }

    public ICollection<Borrow>? Borrows { get; set; }
}
