namespace LibraryAutomation.WinFormsUI.Models;

public class BorrowModel
{
    public int Id { get; set; }

    public string? MemberNumber { get; set; } = "233004094";

    public DateTime BorrowDate { get; set; }

    public bool IsDelivered { get; set; } = false;

    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? BookWriter { get; set; }

    public string? BookISBN { get; set; }

    public static IEnumerable<BorrowModel> GetDummyData()
    {
        return
        [
            new BorrowModel
            {
                Id = 1,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 15),
                IsDelivered = false,
                BookId = 101,
                BookName = "Dune: Çöl Gezegeni",
                BookWriter = "Frank Herbert",
                BookISBN = "978-3-16-148410-0"
            },
            new BorrowModel
            {
                Id = 2,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 12),
                IsDelivered = false,
                BookId = 102,
                BookName = "Dune Mesihi",
                BookWriter = "Frank Herbert",
                BookISBN = "978-3-16-148410-1"
            },
            new BorrowModel
            {
                Id = 3,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 10),
                IsDelivered = false,
                BookId = 103,
                BookName = "Vakıf ve İmparatorluk",
                BookWriter = "Isaac Asimov",
                BookISBN = "978-975-10-1486-6"
            },
            new BorrowModel
            {
                Id = 4,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 8),
                IsDelivered = false,
                BookId = 104,
                BookName = "Hyperion",
                BookWriter = "Dan Simmons",
                BookISBN = "978-0-553-28368-0"
            },
            new BorrowModel
            {
                Id = 5,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 5),
                IsDelivered = false,
                BookId = 105,
                BookName = "Neuromancer",
                BookWriter = "William Gibson",
                BookISBN = "978-0-441-56956-0"
            },
            new BorrowModel
            {
                Id = 6,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 30),
                IsDelivered = false,
                BookId = 106,
                BookName = "Sürgün Gezegeni",
                BookWriter = "Ursula K. Le Guin",
                BookISBN = "978-605-375-838-6"
            },
            new BorrowModel
            {
                Id = 7,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 25),
                IsDelivered = false,
                BookId = 107,
                BookName = "Cesur Yeni Dünya",
                BookWriter = "Aldous Huxley",
                BookISBN = "978-975-07-0260-1"
            },
            new BorrowModel
            {
                Id = 8,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 20),
                IsDelivered = false,
                BookId = 108,
                BookName = "Zaman Makinesi",
                BookWriter = "H.G. Wells",
                BookISBN = "978-605-360-962-6"
            },
            new BorrowModel
            {
                Id = 9,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 15),
                IsDelivered = true,
                BookId = 109,
                BookName = "Ben, Robot",
                BookWriter = "Isaac Asimov",
                BookISBN = "978-0-553-29438-9"
            },
            new BorrowModel
            {
                Id = 10,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 10),
                IsDelivered = true,
                BookId = 110,
                BookName = "Otostopçunun Galaksi Rehberi",
                BookWriter = "Douglas Adams",
                BookISBN = "978-0-345-39180-3"
            },
            new BorrowModel
            {
                Id = 10,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 10),
                IsDelivered = true,
                BookId = 110,
                BookName = "Dünyalar Savaşı",
                BookWriter = "H.G Wells",
                BookISBN = "9786052958889"
            }
        ];
    }
}
