namespace LibraryAutomation.WinFormsUI.Models;

public class BookModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Writer { get; set; }

    public string? OriginName { get; set; }

    public string? Publisher { get; set; }

    public DateTime PublishDate { get; set; }

    public int PageCount { get; set; }

    public string? ISBN { get; set; }

    public int StockQuantity { get; set; }

    public int BorrowQuantity { get; set; }

    public static IEnumerable<BookModel> GetDummyData()
    {
        return
       [
            new BookModel
            {
                Id = 0,
                Name = "Hyperion",
                Writer = "Dan Simmons",
                PublishDate = new DateTime(1989, 05, 26),
                PageCount = 482,
                BorrowQuantity = 5,
                StockQuantity = 2,
                OriginName = "Hyperion",
                Publisher = "İthaki Yayınları",
                ISBN = "9780553283680"
            },
            new BookModel
            {
                Id = 1,
                Name = "1984",
                Writer = "George Orwell",
                PublishDate = new DateTime(2020, 01, 15),
                PageCount = 328,
                BorrowQuantity = 5,
                StockQuantity = 3,
                OriginName = "Nineteen EightyFour",
                Publisher = "Can Yayınları",
                ISBN = "9780452284234"
            },
            new BookModel
            {
                Id = 2,
                Name = "Hayvan Çiftliği",
                Writer = "George Orwell",
                PublishDate = new DateTime(2021, 03, 10),
                PageCount = 152,
                BorrowQuantity = 2,
                StockQuantity = 1,
                OriginName = "Animal Farm",
                Publisher = "Can Yayınları",
                ISBN = "9780452284241"
            },
            new BookModel
            {
                Id = 3,
                Name = "Sefiller",
                Writer = "Victor Hugo",
                PublishDate = new DateTime(2018, 11, 05),
                PageCount = 1200,
                BorrowQuantity = 1,
                StockQuantity = 2,
                OriginName = "Les Misérables",
                Publisher = "İş Bankası Kültür Yayınları",
                ISBN = "9789754588210"
            },
            new BookModel
            {
                Id = 4,
                Name = "Yüzüklerin Efendisi: Yüzük Kardeşliği",
                Writer = "J.R.R. Tolkien",
                PublishDate = new DateTime(2022, 07, 21),
                PageCount = 535,
                BorrowQuantity = 0,
                StockQuantity = 4,
                OriginName = "The Fellowship of the Ring",
                Publisher = "Metis Yayınları",
                ISBN = "9780618002228"
            },
            new BookModel
            {
                Id = 5,
                Name = "Simyacı",
                Writer = "Paulo Coelho",
                PublishDate = new DateTime(2017, 09, 12),
                PageCount = 184,
                BorrowQuantity = 6,
                StockQuantity = 5,
                OriginName = "The Alchemist",
                Publisher = "Can Yayınları",
                ISBN = "9780061122415"
            },
            new BookModel
            {
                Id = 6,
                Name = "Körlük",
                Writer = "José Saramago",
                PublishDate = new DateTime(2015, 02, 18),
                PageCount = 352,
                BorrowQuantity = 3,
                StockQuantity = 2,
                OriginName = "Ensaio sobre a cegueira",
                Publisher = "Kırmızı Kedi Yayınları",
                ISBN = "9789750503522"
            },
            new BookModel
            {
                Id = 7,
                Name = "Suç ve Ceza",
                Writer = "Fyodor Dostoyevski",
                PublishDate = new DateTime(2016, 12, 03),
                PageCount = 704,
                BorrowQuantity = 4,
                StockQuantity = 3,
                OriginName = "Преступление и наказание",
                Publisher = "Türkiye İş Bankası Kültür Yayınları",
                ISBN = "9789754587398"
            },
            new BookModel
            {
                Id = 8,
                Name = "Uçurtma Avcısı",
                Writer = "Khaled Hosseini",
                PublishDate = new DateTime(2018, 05, 09),
                PageCount = 374,
                BorrowQuantity = 5,
                StockQuantity = 1,
                OriginName = "The Kite Runner",
                Publisher = "Everest Yayınları",
                ISBN = "9789752894207"
            },
            new BookModel
            {
                Id = 9,
                Name = "Otostopçunun Galaksi Rehberi",
                Writer = "Douglas Adams",
                PublishDate = new DateTime(2021, 10, 01),
                PageCount = 224,
                BorrowQuantity = 2,
                StockQuantity = 2,
                OriginName = "The Hitchhiker's Guide to the Galaxy",
                Publisher = "Alfa Yayınları",
                ISBN = "9780330258647"
            },
            new BookModel
            {
                Id = 10,
                Name = "Vakıf",
                Writer = "Isaac Asimov",
                PublishDate = new DateTime(2020, 01, 10),
                PageCount = 296,
                BorrowQuantity = 7,
                StockQuantity = 3,
                OriginName = "Foundation",
                Publisher = "Alfa Yayınları",
                ISBN = "9780553803710"
            },
            new BookModel
            {
                Id = 11,
                Name = "Ben, Robot",
                Writer = "Isaac Asimov",
                PublishDate = new DateTime(2019, 06, 17),
                PageCount = 256,
                BorrowQuantity = 4,
                StockQuantity = 2,
                OriginName = "I, Robot",
                Publisher = "Alfa Yayınları",
                ISBN = "9780553294389"
            },
            new BookModel
            {
                Id = 12,
                Name = "Neuromancer",
                Writer = "William Gibson",
                PublishDate = new DateTime(2018, 03, 08),
                PageCount = 271,
                BorrowQuantity = 2,
                StockQuantity = 2,
                OriginName = "Neuromancer",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441569564"
            },
            new BookModel
            {
                Id = 13,
                Name = "Sürgün Gezegeni",
                Writer = "Ursula K. Le Guin",
                PublishDate = new DateTime(2021, 07, 14),
                PageCount = 208,
                BorrowQuantity = 3,
                StockQuantity = 1,
                OriginName = "Planet of Exile",
                Publisher = "Metis Yayınları",
                ISBN = "9780060125837"
            },
            new BookModel
            {
                Id = 14,
                Name = "Zaman Makinesi",
                Writer = "H.G. Wells",
                PublishDate = new DateTime(2017, 11, 30),
                PageCount = 152,
                BorrowQuantity = 5,
                StockQuantity = 2,
                OriginName = "The Time Machine",
                Publisher = "Can Yayınları",
                ISBN = "9780141439976"
            },
            new BookModel
            {
                Id = 15,
                Name = "Solaris",
                Writer = "Stanisław Lem",
                PublishDate = new DateTime(2016, 04, 22),
                PageCount = 224,
                BorrowQuantity = 1,
                StockQuantity = 3,
                OriginName = "Solaris",
                Publisher = "Versus Kitap",
                ISBN = "9780156837507"
            },
            new BookModel
            {
                Id = 16,
                Name = "Bir Mars Destanı",
                Writer = "Ray Bradbury",
                PublishDate = new DateTime(2020, 12, 01),
                PageCount = 288,
                BorrowQuantity = 3,
                StockQuantity = 2,
                OriginName = "The Martian Chronicles",
                Publisher = "İthaki Yayınları",
                ISBN = "9780553278228"
            },
            new BookModel
            {
                Id = 17,
                Name = "Karbon Değişimi",
                Writer = "Richard K. Morgan",
                PublishDate = new DateTime(2019, 09, 13),
                PageCount = 384,
                BorrowQuantity = 2,
                StockQuantity = 1,
                OriginName = "Altered Carbon",
                Publisher = "Alfa Yayınları",
                ISBN = "9780345457690"
            },
            new BookModel
            {
                Id = 18,
                Name = "Dune: Çöl Gezegeni",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1965, 08, 01),
                PageCount = 620,
                BorrowQuantity = 12,
                StockQuantity = 4,
                OriginName = "Dune",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172719"
            },
            new BookModel
            {
                Id = 19,
                Name = "Mesih Dune",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1969, 10, 15),
                PageCount = 336,
                BorrowQuantity = 8,
                StockQuantity = 2,
                OriginName = "Dune Messiah",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172726"
            },
            new BookModel
            {
                Id = 20,
                Name = "Dune Çocukları",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1976, 04, 21),
                PageCount = 416,
                BorrowQuantity = 6,
                StockQuantity = 3,
                OriginName = "Children of Dune",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172733"
            },
            new BookModel
            {
                Id = 21,
                Name = "Dune Tanrı İmparatoru",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1981, 05, 28),
                PageCount = 496,
                BorrowQuantity = 4,
                StockQuantity = 2,
                OriginName = "God Emperor of Dune",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172740"
            },
            new BookModel
            {
                Id = 22,
                Name = "Dune’un Kâfirleri",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1984, 06, 17),
                PageCount = 480,
                BorrowQuantity = 3,
                StockQuantity = 2,
                OriginName = "Heretics of Dune",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172757"
            },
            new BookModel
            {
                Id = 23,
                Name = "Dune Tarikat Okulu",
                Writer = "Frank Herbert",
                PublishDate = new DateTime(1985, 08, 01),
                PageCount = 448,
                BorrowQuantity = 2,
                StockQuantity = 2,
                OriginName = "Chapterhouse: Dune",
                Publisher = "İthaki Yayınları",
                ISBN = "9780441172764"
            },
            new BookModel
            {
                Id = 24,
                Name = "Dune Avcıları",
                Writer = "Brian Herbert & Kevin J. Anderson",
                PublishDate = new DateTime(2006, 09, 01),
                PageCount = 512,
                BorrowQuantity = 1,
                StockQuantity = 2,
                OriginName = "Hunters of Dune",
                Publisher = "Del Rey",
                ISBN = "9780765306466"
            },
            new BookModel
            {
                Id = 25,
                Name = "Dune: Kum Solucanları",
                Writer = "Brian Herbert & Kevin J. Anderson",
                PublishDate = new DateTime(2007, 08, 07),
                PageCount = 528,
                BorrowQuantity = 1,
                StockQuantity = 1,
                OriginName = "Sandworms of Dune",
                Publisher = "Del Rey",
                ISBN = "9780765306473"
            },
             new BookModel
            {
                Id = 26,
                Name = "Dünyalar Savaşı",
                Writer = "H.G Wells",
                PublishDate = new DateTime(2007, 08, 07),
                PageCount = 528,
                BorrowQuantity = 1,
                StockQuantity = 3,
                OriginName = "War of The Worlds",
                Publisher = "İş Bankası Kültür Yayınları",
                ISBN = "9786052958889"
            }
       ];
    }
}
