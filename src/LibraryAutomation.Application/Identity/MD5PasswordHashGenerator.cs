using System.Security.Cryptography;
using System.Text;

namespace LibraryAutomation.ApplicationL.Identity;

public class MD5PasswordHashGenerator : IPasswordHashGenerator
{
    private const int SALT_SIZE = 32;
    private const int HASH_ITERATIONS = 500;

    public string HashPassword(string password)
    {
        return getPasswordHashAndSalt(password, generateSalt());
    }

    public bool VerifyPassword(string password, string hashedPassword)
    {
        string[] parts = hashedPassword.Split(':');
        if (parts.Length != 2) throw new ArgumentException("invalid password format");

        string storedHash = parts[0];
        string storedSalt = parts[1];

        string saltedPassword = password + storedSalt;
        for (int i = 0; i < HASH_ITERATIONS; i++)
        {
            byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
            byte[] saltedPasswordHash = MD5.HashData(saltedPasswordBytes);
            saltedPassword = Convert.ToBase64String(saltedPasswordHash);
        }

        return storedHash == saltedPassword;
    }

    private string generateSalt()
    {
        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        byte[] salt = new byte[SALT_SIZE];
        rng.GetBytes(salt);
        return Convert.ToBase64String(salt);
    }

    private string getPasswordHashAndSalt(string password, string salt)
    {
        string saltedPassword = password + salt;
        for (int i = 0; i < HASH_ITERATIONS; i++)
        {
            byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
            byte[] saltedPasswordHash = MD5.HashData(saltedPasswordBytes);
            saltedPassword = Convert.ToBase64String(saltedPasswordHash);
        }
        return saltedPassword + ":" + salt;
    }
}
