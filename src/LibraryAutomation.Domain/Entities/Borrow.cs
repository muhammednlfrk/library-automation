namespace LibraryAutomation.Domain.Entities;

public sealed class Borrow : EntityBase
{
    public required DateTime BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public bool IsDelivered { get; set; }

    public int UserId { get; set; }

    public User? User { get; set; }

    public int BookId { get; set; }

    public Book? Book { get; set; }
}
