namespace LibraryAutomation.WinFormsUI.Models;

public abstract class PersonBaseModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public DateTime BirthDate { get; set; }

    public DateTime? DeathDate { get; set; }

    public string FullName => $"{Name} {Surname}";
}
