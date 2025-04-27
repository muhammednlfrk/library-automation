namespace LibraryAutomation.WinFormsUI.Models;

public class ShelfModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public static IEnumerable<ShelfModel> GetDummyData()
    {
        return
        [
            new ShelfModel { Id = 1, Name = "A1", Description = "Bilim kurgu klasikleri" },
            new ShelfModel { Id = 2, Name = "A2", Description = "Fantastik romanlar" },
            new ShelfModel { Id = 3, Name = "A3", Description = "Modern Türk edebiyatı" },
            new ShelfModel { Id = 4, Name = "A4", Description = "Dünya edebiyatı" },
            new ShelfModel { Id = 5, Name = "A5", Description = "Polisiye ve gerilim" },
            new ShelfModel { Id = 6, Name = "B1", Description = "Tarih kitapları" },
            new ShelfModel { Id = 7, Name = "B2", Description = "Felsefe eserleri" },
            new ShelfModel { Id = 8, Name = "B3", Description = "Psikoloji kitapları" },
            new ShelfModel { Id = 9, Name = "B4", Description = "Siyaset ve sosyoloji" },
            new ShelfModel { Id = 10, Name = "B5", Description = "Ekonomi ve iş dünyası" },
            new ShelfModel { Id = 11, Name = "C1", Description = "Kişisel gelişim" },
            new ShelfModel { Id = 12, Name = "C2", Description = "Din ve mitoloji" },
            new ShelfModel { Id = 13, Name = "C3", Description = "Sanat ve mimarlık" },
            new ShelfModel { Id = 14, Name = "C4", Description = "Biyografi ve otobiyografi" },
            new ShelfModel { Id = 15, Name = "C5", Description = "Bilim ve teknoloji" },
            new ShelfModel { Id = 16, Name = "D1", Description = "Çocuk kitapları" },
            new ShelfModel { Id = 17, Name = "D2", Description = "Gençlik kitapları" },
            new ShelfModel { Id = 18, Name = "D3", Description = "Mizah ve karikatür" },
            new ShelfModel { Id = 19, Name = "D4", Description = "Şiir kitapları" },
            new ShelfModel { Id = 20, Name = "D5", Description = "Klasik eserler" }
        ];
    }
}
