namespace LibraryAutomation.WinFormsUI.Models;

public class MemberModel
{
    public int Id { get; set; }

    public string? Name { get; set; } // ex. Muhammed Nilifırka

    public string? Email { get; set; } // ex. 233004094@ogr.selcuk.edu.tr

    public string? Number { get; set; } // ex. 233004094

    public string? PasswordHash { get; set; } // MD5 hash

    public static IEnumerable<MemberModel> GetDummyData()
    {
        return
        [
            new MemberModel
            {
                Id = 1,
                Name = "Muhammed Nilifırka",
                Email = "233004094@ogr.selcuk.edu.tr",
                Number = "233004094",
                PasswordHash = "5f4dcc3b5aa765d61d8327deb882cf99" // password
            },
            new MemberModel
            {
                Id = 2,
                Name = "Zeynep Karagöz",
                Email = "233004095@ogr.selcuk.edu.tr",
                Number = "233004095",
                PasswordHash = "e99a18c428cb38d5f260853678922e03" // abc123
            },
            new MemberModel
            {
                Id = 3,
                Name = "Ali Vural",
                Email = "233004096@ogr.selcuk.edu.tr",
                Number = "233004096",
                PasswordHash = "d8578edf8458ce06fbc5bb76a58c5ca4" // qwerty
            },
            new MemberModel
            {
                Id = 4,
                Name = "Elif Aydın",
                Email = "233004097@ogr.selcuk.edu.tr",
                Number = "233004097",
                PasswordHash = "25f9e794323b453885f5181f1b624d0b" // 123456789
            },
            new MemberModel
            {
                Id = 5,
                Name = "Mustafa Ünal",
                Email = "233004098@ogr.selcuk.edu.tr",
                Number = "233004098",
                PasswordHash = "81dc9bdb52d04dc20036dbd8313ed055" // 1234
            },
            new MemberModel
            {
                Id = 6,
                Name = "Hatice Demir",
                Email = "233004099@ogr.selcuk.edu.tr",
                Number = "233004099",
                PasswordHash = "202cb962ac59075b964b07152d234b70" // 123
            },
            new MemberModel
            {
                Id = 7,
                Name = "Ahmet Şahin",
                Email = "233004100@ogr.selcuk.edu.tr",
                Number = "233004100",
                PasswordHash = "098f6bcd4621d373cade4e832627b4f6" // test
            },
            new MemberModel
            {
                Id = 8,
                Name = "Ayşe Yıldırım",
                Email = "233004101@ogr.selcuk.edu.tr",
                Number = "233004101",
                PasswordHash = "21232f297a57a5a743894a0e4a801fc3" // admin
            },
            new MemberModel
            {
                Id = 9,
                Name = "Kemal Özdemir",
                Email = "233004102@ogr.selcuk.edu.tr",
                Number = "233004102",
                PasswordHash = "5ebe2294ecd0e0f08eab7690d2a6ee69" // secret
            },
            new MemberModel
            {
                Id = 11,
                Name = "Burak Kılıç",
                Email = "233004104@ogr.selcuk.edu.tr",
                Number = "233004104",
                PasswordHash = "b2e98ad6f6eb8508dd6a14cfa704bad7" // letmein
            },
            new MemberModel
            {
                Id = 12,
                Name = "Gizem Yılmaz",
                Email = "233004105@ogr.selcuk.edu.tr",
                Number = "233004105",
                PasswordHash = "6cb75f652a9b52798eb6cf2201057c73" // 111111
            },
            new MemberModel
            {
                Id = 13,
                Name = "Onur Kaptan",
                Email = "233004106@ogr.selcuk.edu.tr",
                Number = "233004106",
                PasswordHash = "1d56a37fb6b08aa709fe90e12ca59e12" // pass123
            },
            new MemberModel
            {
                Id = 14,
                Name = "Nisanur Doğan",
                Email = "233004107@ogr.selcuk.edu.tr",
                Number = "233004107",
                PasswordHash = "c33367701511b4f6020ec61ded352059" // 654321
            },
            new MemberModel
            {
                Id = 15,
                Name = "Yusuf Çelik",
                Email = "233004108@ogr.selcuk.edu.tr",
                Number = "233004108",
                PasswordHash = "25d55ad283aa400af464c76d713c07ad" // 12345678
            },
            new MemberModel
            {
                Id = 16,
                Name = "Büşra Erdem",
                Email = "233004109@ogr.selcuk.edu.tr",
                Number = "233004109",
                PasswordHash = "098f6bcd4621d373cade4e832627b4f6" // test
            }
        ];
    }
}
