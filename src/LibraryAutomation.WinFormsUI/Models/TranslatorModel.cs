namespace LibraryAutomation.WinFormsUI.Models;

public class TranslatorModel : PersonBaseModel
{
    public static IEnumerable<TranslatorModel> GetDummyData()
    {
        return
        [
            new() { Id = 1, Name = "Roza", Surname = "Hakmen", BirthDate = new DateTime(1945, 5, 10), DeathDate = new DateTime(2021, 8, 2) },
            new() { Id = 2, Name = "Ülker", Surname = "İnan", BirthDate = new DateTime(1960, 3, 12), DeathDate = null },
            new() { Id = 3, Name = "Sevin", Surname = "Okyay", BirthDate = new DateTime(1942, 2, 12), DeathDate = null },
            new() { Id = 4, Name = "Cemal", Surname = "Süreya", BirthDate = new DateTime(1931, 10, 20), DeathDate = new DateTime(1990, 1, 9) },
            new() { Id = 5, Name = "Tomris", Surname = "Uyar", BirthDate = new DateTime(1941, 3, 15), DeathDate = new DateTime(2003, 7, 4) },
            new() { Id = 6, Name = "Can", Surname = "Yücel", BirthDate = new DateTime(1926, 8, 21), DeathDate = new DateTime(1999, 8, 12) },
            new() { Id = 7, Name = "Güngör", Surname = "Dilmen", BirthDate = new DateTime(1930, 3, 12), DeathDate = new DateTime(2012, 8, 4) },
            new() { Id = 8, Name = "Sabahattin", Surname = "Ali", BirthDate = new DateTime(1907, 2, 25), DeathDate = new DateTime(1948, 4, 2) },
            new() { Id = 9, Name = "Zehra", Surname = "Çelenk", BirthDate = new DateTime(1970, 11, 18), DeathDate = null },
            new() { Id = 10, Name = "Yiğit", Surname = "Bener", BirthDate = new DateTime(1958, 6, 30), DeathDate = null },
            new() { Id = 11, Name = "Fatih", Surname = "Özgüven", BirthDate = new DateTime(1957, 4, 3), DeathDate = null },
            new() { Id = 12, Name = "Buket", Surname = "Uzuner", BirthDate = new DateTime(1955, 10, 3), DeathDate = null },
            new() { Id = 13, Name = "Fuat", Surname = "Sevimay", BirthDate = new DateTime(1972, 12, 24), DeathDate = null },
            new() { Id = 14, Name = "Ayşe", Surname = "Başar", BirthDate = new DateTime(1980, 1, 15), DeathDate = null },
            new() { Id = 15, Name = "Mehmet", Surname = "Kara", BirthDate = new DateTime(1975, 7, 7), DeathDate = null },
            new() { Id = 16, Name = "Aslı", Surname = "Biçen", BirthDate = new DateTime(1970, 5, 25), DeathDate = null },
            new() { Id = 17, Name = "İlknur", Surname = "Özdemir", BirthDate = new DateTime(1965, 9, 9), DeathDate = null },
            new() { Id = 18, Name = "Mina", Surname = "Urgan", BirthDate = new DateTime(1916, 5, 14), DeathDate = new DateTime(2000, 6, 15) },
            new() { Id = 19, Name = "Şirin", Surname = "Tekeli", BirthDate = new DateTime(1944, 12, 11), DeathDate = new DateTime(2017, 6, 13) },
            new() { Id = 20, Name = "Necati", Surname = "Cumalı", BirthDate = new DateTime(1921, 1, 13), DeathDate = new DateTime(2001, 1, 10) },
            new() { Id = 21, Name = "Ahmet", Surname = "Cemal", BirthDate = new DateTime(1942, 1, 1), DeathDate = new DateTime(2017, 8, 1) },
            new() { Id = 22, Name = "Nazım", Surname = "Hikmet", BirthDate = new DateTime(1902, 1, 15), DeathDate = new DateTime(1963, 6, 3) },
            new() { Id = 23, Name = "Melisa", Surname = "Kesmez", BirthDate = new DateTime(1980, 4, 5), DeathDate = null },
            new() { Id = 24, Name = "Ayfer", Surname = "Tunç", BirthDate = new DateTime(1964, 2, 10), DeathDate = null },
            new() { Id = 25, Name = "Ali", Surname = "Berktay", BirthDate = new DateTime(1957, 9, 21), DeathDate = null },
            new() { Id = 26, Name = "Pelin", Surname = "Tamgüç", BirthDate = new DateTime(1978, 6, 16), DeathDate = null },
            new() { Id = 27, Name = "Orhan", Surname = "Pamuk", BirthDate = new DateTime(1952, 6, 7), DeathDate = null },
            new() { Id = 28, Name = "Elif", Surname = "Batuman", BirthDate = new DateTime(1977, 7, 20), DeathDate = null },
            new() { Id = 29, Name = "Halide", Surname = "Edip", BirthDate = new DateTime(1884, 1, 11), DeathDate = new DateTime(1964, 1, 9) },
            new() { Id = 30, Name = "Hikmet", Surname = "Temel Akarsu", BirthDate = new DateTime(1962, 4, 12), DeathDate = null },
            new() { Id = 31, Name = "Alev", Surname = "Ersan", BirthDate = new DateTime(1985, 3, 23), DeathDate = null },
            new() { Id = 32, Name = "Taner", Surname = "Baybars", BirthDate = new DateTime(1936, 1, 1), DeathDate = new DateTime(2010, 12, 5) },
            new() { Id = 33, Name = "Nurdan", Surname = "Damla", BirthDate = new DateTime(1990, 11, 8), DeathDate = null },
            new() { Id = 34, Name = "Ömer", Surname = "Madra", BirthDate = new DateTime(1945, 5, 15), DeathDate = null },
            new() { Id = 35, Name = "Seray", Surname = "Şahiner", BirthDate = new DateTime(1984, 11, 7), DeathDate = null },
            new() { Id = 36, Name = "Ferit", Surname = "Edgü", BirthDate = new DateTime(1936, 2, 24), DeathDate = null },
            new() { Id = 37, Name = "Süheyla", Surname = "Ezer", BirthDate = new DateTime(1975, 7, 19), DeathDate = null },
            new() { Id = 38, Name = "Mehmet", Surname = "Erte", BirthDate = new DateTime(1978, 5, 6), DeathDate = null },
            new() { Id = 39, Name = "Zeynep", Surname = "Avcı", BirthDate = new DateTime(1960, 10, 17), DeathDate = null },
            new() { Id = 40, Name = "Gaye", Surname = "Borsuk", BirthDate = new DateTime(1987, 6, 14), DeathDate = null }
        ];
    }
}
