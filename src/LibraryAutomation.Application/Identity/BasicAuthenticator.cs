using LibraryAutomation.Domain.Entities;
using LibraryAutomation.Infrastructure.Repositories;

namespace LibraryAutomation.ApplicationL.Identity;

public class BasicAuthenticator(IRepository<User> userRepository, IPasswordHashGenerator passwordHashGenerator) : IAuthenticator
{
    private readonly IRepository<User> _userRepository = userRepository;
    private readonly IPasswordHashGenerator _passwordHashGenerator = passwordHashGenerator;

    public User? Authenticate(string usernameOrEmail, string password)
    {
        User? user = _userRepository.DbSet.FirstOrDefault(u =>
            u.Username == usernameOrEmail ||
            u.Email == usernameOrEmail);

        if (user == null) return null;

        bool isPasswordCorrect = _passwordHashGenerator.VerifyPassword(password, user.Password);

        return isPasswordCorrect ? user : null;
    }
}
