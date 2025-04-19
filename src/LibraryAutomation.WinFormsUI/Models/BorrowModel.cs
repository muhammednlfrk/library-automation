namespace LibraryAutomation.WinFormsUI.Models;

public class BorrowModel
{
    public int Id { get; set; }

    public string? MemberNumber { get; set; } = "233004094";

    public DateTime BorrowDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

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
                BookISBN = "9783161484100"
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
                BookISBN = "9783161484101"
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
                BookISBN = "9789751014866"
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
                BookISBN = "9780553283680"
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
                BookISBN = "9780441569560"
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
                BookISBN = "9786053758386"
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
                BookISBN = "9789750702601"
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
                BookISBN = "9786053609626"
            },
            new BorrowModel
            {
                Id = 9,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 15),
                DeliveryDate = new DateTime(2025, 3, 29),
                IsDelivered = true,
                BookId = 109,
                BookName = "Ben, Robot",
                BookWriter = "Isaac Asimov",
                BookISBN = "9780553294389"
            },
            new BorrowModel
            {
                Id = 10,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 10),
                DeliveryDate = new DateTime(2025, 3, 24),
                IsDelivered = true,
                BookId = 110,
                BookName = "Otostopçunun Galaksi Rehberi",
                BookWriter = "Douglas Adams",
                BookISBN = "9780345391803"
            },
            new BorrowModel
            {
                Id = 11,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 10),
                DeliveryDate = new DateTime(2025, 3, 24),
                IsDelivered = true,
                BookId = 111,
                BookName = "Dünyalar Savaşı",
                BookWriter = "H.G Wells",
                BookISBN = "9786052958889"
            },
            new BorrowModel
            {
                Id = 12,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 14),
                IsDelivered = false,
                BookId = 112,
                BookName = "Mars Yıllıkları",
                BookWriter = "Ray Bradbury",
                BookISBN = "9789754588201"
            },
            new BorrowModel
            {
                Id = 13,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 13),
                IsDelivered = false,
                BookId = 113,
                BookName = "1984",
                BookWriter = "George Orwell",
                BookISBN = "9789750718534"
            },
            new BorrowModel
            {
                Id = 14,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 11),
                DeliveryDate = new DateTime(2025, 4, 25),
                IsDelivered = false,
                BookId = 114,
                BookName = "Karanlığın Yüreği",
                BookWriter = "Joseph Conrad",
                BookISBN = "9789750733957"
            },
            new BorrowModel
            {
                Id = 15,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 9),
                DeliveryDate = new DateTime(2025, 4, 23),
                IsDelivered = false,
                BookId = 115,
                BookName = "Yıkımın Eşiğinde",
                BookWriter = "Cixin Liu",
                BookISBN = "9786052994276"
            },
            new BorrowModel
            {
                Id = 11,
                MemberNumber = "233004095",
                BorrowDate = new DateTime(2025, 4, 14),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 111,
                BookName = "Yerdeniz Büyücüsü",
                BookWriter = "Ursula K. Le Guin",
                BookISBN = "9786053752553"
            },
            new BorrowModel
            {
                Id = 12,
                MemberNumber = "233004096",
                BorrowDate = new DateTime(2025, 4, 10),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 112,
                BookName = "1984",
                BookWriter = "George Orwell",
                BookISBN = "9789750718536"
            },
            new BorrowModel
            {
                Id = 13,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 28),
                DeliveryDate = new DateTime(2025, 4, 5),
                IsDelivered = true,
                BookId = 113,
                BookName = "Bıçak Sırtı",
                BookWriter = "Philip K. Dick",
                BookISBN = "9786053758395"
            },
            new BorrowModel
            {
                Id = 14,
                MemberNumber = "233004097",
                BorrowDate = new DateTime(2025, 4, 13),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 114,
                BookName = "Ay Zalim Bir Sevgilidir",
                BookWriter = "Robert A. Heinlein",
                BookISBN = "9786053759231"
            },
            new BorrowModel
            {
                Id = 15,
                MemberNumber = "233004095",
                BorrowDate = new DateTime(2025, 3, 20),
                DeliveryDate = new DateTime(2025, 3, 29),
                IsDelivered = true,
                BookId = 115,
                BookName = "Solaris",
                BookWriter = "Stanislaw Lem",
                BookISBN = "9789750818595"
            },
            new BorrowModel
            {
                Id = 16,
                MemberNumber = "233004098",
                BorrowDate = new DateTime(2025, 4, 11),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 116,
                BookName = "Mars Yıllıkları",
                BookWriter = "Ray Bradbury",
                BookISBN = "9789753638022"
            },
            new BorrowModel
            {
                Id = 17,
                MemberNumber = "233004099",
                BorrowDate = new DateTime(2025, 4, 7),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 117,
                BookName = "Karanlığın Sol Eli",
                BookWriter = "Ursula K. Le Guin",
                BookISBN = "9786053758623"
            },
            new BorrowModel
            {
                Id = 18,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 18),
                DeliveryDate = new DateTime(2025, 3, 25),
                IsDelivered = true,
                BookId = 118,
                BookName = "Zamanın Kısa Tarihi",
                BookWriter = "Stephen Hawking",
                BookISBN = "9789754035134"
            },
            new BorrowModel
            {
                Id = 19,
                MemberNumber = "233004096",
                BorrowDate = new DateTime(2025, 4, 5),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 119,
                BookName = "Otomatik Portakal",
                BookWriter = "Anthony Burgess",
                BookISBN = "9789750738152"
            },
            new BorrowModel
            {
                Id = 20,
                MemberNumber = "233004097",
                BorrowDate = new DateTime(2025, 3, 29),
                DeliveryDate = new DateTime(2025, 4, 8),
                IsDelivered = true,
                BookId = 120,
                BookName = "Frankenstein",
                BookWriter = "Mary Shelley",
                BookISBN = "9786053327782"
            },
            new BorrowModel
            {
                Id = 21,
                MemberNumber = "233004101",
                BorrowDate = new DateTime(2025, 4, 13),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 121,
                BookName = "Çocukluğun Sonu",
                BookWriter = "Arthur C. Clarke",
                BookISBN = "9786053758318"
            },
            new BorrowModel
            {
                Id = 22,
                MemberNumber = "233004102",
                BorrowDate = new DateTime(2025, 4, 1),
                DeliveryDate = new DateTime(2025, 4, 10),
                IsDelivered = true,
                BookId = 122,
                BookName = "Solaris",
                BookWriter = "Stanislaw Lem",
                BookISBN = "9789750739562"
            },
            new BorrowModel
            {
                Id = 23,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 3, 21),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 123,
                BookName = "Yerdeniz Büyücüsü",
                BookWriter = "Ursula K. Le Guin",
                BookISBN = "9786053758813"
            },
            new BorrowModel
            {
                Id = 24,
                MemberNumber = "233004103",
                BorrowDate = new DateTime(2025, 3, 30),
                DeliveryDate = new DateTime(2025, 4, 5),
                IsDelivered = true,
                BookId = 124,
                BookName = "Karbon Temelli Hayat",
                BookWriter = "Richard Dawkins",
                BookISBN = "9786050981238"
            },
            new BorrowModel
            {
                Id = 25,
                MemberNumber = "233004104",
                BorrowDate = new DateTime(2025, 4, 14),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 125,
                BookName = "Işık Tanrısı",
                BookWriter = "Roger Zelazny",
                BookISBN = "9789753425844"
            },
            new BorrowModel
            {
                Id = 26,
                MemberNumber = "233004105",
                BorrowDate = new DateTime(2025, 3, 27),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 126,
                BookName = "1984",
                BookWriter = "George Orwell",
                BookISBN = "9789750739364"
            },
            new BorrowModel
            {
                Id = 27,
                MemberNumber = "233004106",
                BorrowDate = new DateTime(2025, 3, 22),
                DeliveryDate = new DateTime(2025, 3, 30),
                IsDelivered = true,
                BookId = 127,
                BookName = "Hayvan Çiftliği",
                BookWriter = "George Orwell",
                BookISBN = "9789750718536"
            },
            new BorrowModel
            {
                Id = 28,
                MemberNumber = "233004094",
                BorrowDate = new DateTime(2025, 4, 16),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 128,
                BookName = "Metropolis",
                BookWriter = "Thea von Harbou",
                BookISBN = "9789750819653"
            },
            new BorrowModel
            {
                Id = 29,
                MemberNumber = "233004107",
                BorrowDate = new DateTime(2025, 3, 12),
                DeliveryDate = null,
                IsDelivered = false,
                BookId = 129,
                BookName = "Dönüşüm",
                BookWriter = "Franz Kafka",
                BookISBN = "9789750739197"
            },
            new BorrowModel
            {
                Id = 30,
                MemberNumber = "233004108",
                BorrowDate = new DateTime(2025, 3, 5),
                DeliveryDate = new DateTime(2025, 3, 15),
                IsDelivered = true,
                BookId = 130,
                BookName = "Sineklerin Tanrısı",
                BookWriter = "William Golding",
                BookISBN = "9789750718536"
            }
        ];
    }
}
