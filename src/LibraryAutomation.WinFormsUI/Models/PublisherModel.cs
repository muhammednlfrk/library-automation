namespace LibraryAutomation.WinFormsUI.Models;

public class PublisherModel
{
    public int Id { get; set; }

    public string? Name { get; set; } // unique

    public static IEnumerable<PublisherModel> GetDummmyData()
    {
        return
        [
            new PublisherModel { Id = 1, Name = "İthaki Yayınları" },
            new PublisherModel { Id = 2, Name = "Altıkırkbeş Yayınları" },
            new PublisherModel { Id = 3, Name = "Can Yayınları" },
            new PublisherModel { Id = 4, Name = "Metis Yayınları" },
            new PublisherModel { Id = 5, Name = "Koridor Yayıncılık" },
            new PublisherModel { Id = 6, Name = "Pegasus Yayınları" },
            new PublisherModel { Id = 7, Name = "April Yayıncılık" },
            new PublisherModel { Id = 8, Name = "Tudem Yayınları" },
            new PublisherModel { Id = 9, Name = "Everest Yayınları" },
            new PublisherModel { Id = 10, Name = "Yapı Kredi Yayınları" },
            new PublisherModel { Id = 11, Name = "Doğan Kitap" },
            new PublisherModel { Id = 12, Name = "Remzi Kitabevi" },
            new PublisherModel { Id = 13, Name = "Sel Yayıncılık" },
            new PublisherModel { Id = 14, Name = "Kırmızı Kedi Yayınevi" },
            new PublisherModel { Id = 15, Name = "İnkılap Kitabevi" },
            new PublisherModel { Id = 16, Name = "Profil Kitap" },
            new PublisherModel { Id = 17, Name = "Can Çocuk Yayınları" },
            new PublisherModel { Id = 18, Name = "Sia Kitap" },
            new PublisherModel { Id = 19, Name = "Destek Yayınları" },
            new PublisherModel { Id = 20, Name = "Kolektif Kitap" },
            new PublisherModel { Id = 21, Name = "Epsilon Yayınları" },
            new PublisherModel { Id = 22, Name = "Artemis Yayınları" },
            new PublisherModel { Id = 23, Name = "Canis Yayınları" },
            new PublisherModel { Id = 24, Name = "Beta Yayıncılık" },
            new PublisherModel { Id = 25, Name = "Kaknüs Yayınları" },
            new PublisherModel { Id = 26, Name = "Timaş Yayınları" },
            new PublisherModel { Id = 27, Name = "Elips Kitap" },
            new PublisherModel { Id = 28, Name = "Dharma Yayınları" },
            new PublisherModel { Id = 29, Name = "Akılçelen Kitaplar" },
            new PublisherModel { Id = 30, Name = "Siren Yayınları" },
            new PublisherModel { Id = 31, Name = "Penguin Books" },
            new PublisherModel { Id = 32, Name = "HarperCollins" },
            new PublisherModel { Id = 33, Name = "Simon & Schuster" },
            new PublisherModel { Id = 34, Name = "Macmillan Publishers" },
            new PublisherModel { Id = 35, Name = "Hachette Book Group" },
            new PublisherModel { Id = 36, Name = "Tor Books" },
            new PublisherModel { Id = 37, Name = "Orbit Books" },
            new PublisherModel { Id = 38, Name = "Del Rey Books" },
            new PublisherModel { Id = 39, Name = "Vintage Books" },
            new PublisherModel { Id = 40, Name = "Gollancz" }
        ];
    }
}
