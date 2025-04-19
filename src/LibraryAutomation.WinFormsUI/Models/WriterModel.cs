namespace LibraryAutomation.WinFormsUI.Models;

public class WriterModel : PersonBaseModel
{
    public static IEnumerable<WriterModel> GetDummyData()
    {
        return
        [
            new() { Id = 1, Name = "George", Surname = "Orwell", BirthDate = new DateTime(1903, 6, 25), DeathDate = new DateTime(1950, 1, 21) },
            new() { Id = 2, Name = "Aldous", Surname = "Huxley", BirthDate = new DateTime(1894, 7, 26), DeathDate = new DateTime(1963, 11, 22) },
            new() { Id = 3, Name = "Isaac", Surname = "Asimov", BirthDate = new DateTime(1920, 1, 2), DeathDate = new DateTime(1992, 4, 6) },
            new() { Id = 4, Name = "Arthur C.", Surname = "Clarke", BirthDate = new DateTime(1917, 12, 16), DeathDate = new DateTime(2008, 3, 19) },
            new() { Id = 5, Name = "Ray", Surname = "Bradbury", BirthDate = new DateTime(1920, 8, 22), DeathDate = new DateTime(2012, 6, 5) },
            new() { Id = 6, Name = "Philip K.", Surname = "Dick", BirthDate = new DateTime(1928, 12, 16), DeathDate = new DateTime(1982, 3, 2) },
            new() { Id = 7, Name = "H.G.", Surname = "Wells", BirthDate = new DateTime(1866, 9, 21), DeathDate = new DateTime(1946, 8, 13) },
            new() { Id = 8, Name = "Frank", Surname = "Herbert", BirthDate = new DateTime(1920, 10, 8), DeathDate = new DateTime(1986, 2, 11) },
            new() { Id = 9, Name = "Ursula K.", Surname = "Le Guin", BirthDate = new DateTime(1929, 10, 21), DeathDate = new DateTime(2018, 1, 22) },
            new() { Id = 10, Name = "William", Surname = "Gibson", BirthDate = new DateTime(1948, 3, 17), DeathDate = null },
            new() { Id = 11, Name = "Dan", Surname = "Simmons", BirthDate = new DateTime(1948, 4, 4), DeathDate = null },
            new() { Id = 12, Name = "Douglas", Surname = "Adams", BirthDate = new DateTime(1952, 3, 11), DeathDate = new DateTime(2001, 5, 11) },
            new() { Id = 13, Name = "Margaret", Surname = "Atwood", BirthDate = new DateTime(1939, 11, 18), DeathDate = null },
            new() { Id = 14, Name = "Neil", Surname = "Gaiman", BirthDate = new DateTime(1960, 11, 10), DeathDate = null },
            new() { Id = 15, Name = "Terry", Surname = "Pratchett", BirthDate = new DateTime(1948, 4, 28), DeathDate = new DateTime(2015, 3, 12) },
            new() { Id = 16, Name = "Jules", Surname = "Verne", BirthDate = new DateTime(1828, 2, 8), DeathDate = new DateTime(1905, 3, 24) },
            new() { Id = 17, Name = "Orson", Surname = "Scott Card", BirthDate = new DateTime(1951, 8, 24), DeathDate = null },
            new() { Id = 18, Name = "Cixin", Surname = "Liu", BirthDate = new DateTime(1963, 6, 23), DeathDate = null },
            new() { Id = 19, Name = "Yevgeny", Surname = "Zamyatin", BirthDate = new DateTime(1884, 2, 1), DeathDate = new DateTime(1937, 3, 10) },
            new() { Id = 20, Name = "Octavia", Surname = "Butler", BirthDate = new DateTime(1947, 6, 22), DeathDate = new DateTime(2006, 2, 24) },
            new() { Id = 21, Name = "Mary", Surname = "Shelley", BirthDate = new DateTime(1797, 8, 30), DeathDate = new DateTime(1851, 2, 1) },
            new() { Id = 22, Name = "Bram", Surname = "Stoker", BirthDate = new DateTime(1847, 11, 8), DeathDate = new DateTime(1912, 4, 20) },
            new() { Id = 23, Name = "Robert", Surname = "Heinlein", BirthDate = new DateTime(1907, 7, 7), DeathDate = new DateTime(1988, 5, 8) },
            new() { Id = 24, Name = "Kurt", Surname = "Vonnegut", BirthDate = new DateTime(1922, 11, 11), DeathDate = new DateTime(2007, 4, 11) },
            new() { Id = 25, Name = "Anne", Surname = "McCaffrey", BirthDate = new DateTime(1926, 4, 1), DeathDate = new DateTime(2011, 11, 21) },
            new() { Id = 26, Name = "Roger", Surname = "Zelazny", BirthDate = new DateTime(1937, 5, 13), DeathDate = new DateTime(1995, 6, 14) },
            new() { Id = 27, Name = "Samuel R.", Surname = "Delany", BirthDate = new DateTime(1942, 4, 1), DeathDate = null },
            new() { Id = 28, Name = "James", Surname = "Blish", BirthDate = new DateTime(1921, 5, 23), DeathDate = new DateTime(1975, 7, 30) },
            new() { Id = 29, Name = "Frederik", Surname = "Pohl", BirthDate = new DateTime(1919, 11, 26), DeathDate = new DateTime(2013, 9, 2) },
            new() { Id = 30, Name = "Theodore", Surname = "Sturgeon", BirthDate = new DateTime(1918, 2, 26), DeathDate = new DateTime(1985, 5, 8) },
            new() { Id = 31, Name = "Larry", Surname = "Niven", BirthDate = new DateTime(1938, 4, 30), DeathDate = null },
            new() { Id = 32, Name = "John", Surname = "Scalzi", BirthDate = new DateTime(1969, 5, 10), DeathDate = null },
            new() { Id = 33, Name = "Cory", Surname = "Doctorow", BirthDate = new DateTime(1971, 7, 17), DeathDate = null },
            new() { Id = 34, Name = "Joe", Surname = "Haldeman", BirthDate = new DateTime(1943, 6, 9), DeathDate = null },
            new() { Id = 35, Name = "Kim", Surname = "Stanley Robinson", BirthDate = new DateTime(1952, 3, 23), DeathDate = null },
            new() { Id = 36, Name = "Nancy", Surname = "Kress", BirthDate = new DateTime(1948, 1, 20), DeathDate = null },
            new() { Id = 37, Name = "Greg", Surname = "Bear", BirthDate = new DateTime(1951, 8, 20), DeathDate = new DateTime(2022, 11, 19) },
            new() { Id = 38, Name = "David", Surname = "Brin", BirthDate = new DateTime(1950, 10, 6), DeathDate = null },
            new() { Id = 39, Name = "Michael", Surname = "Crichton", BirthDate = new DateTime(1942, 10, 23), DeathDate = new DateTime(2008, 11, 4) },
            new() { Id = 40, Name = "J.G.", Surname = "Ballard", BirthDate = new DateTime(1930, 11, 15), DeathDate = new DateTime(2009, 4, 19) }
        ];
    }
}
