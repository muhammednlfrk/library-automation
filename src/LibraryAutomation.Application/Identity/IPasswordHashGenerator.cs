namespace LibraryAutomation.ApplicationL.Identity;

public interface IPasswordHashGenerator
{
    string HashPassword(string password);

    bool VerifyPassword(string password, string hashedPassword);
}
