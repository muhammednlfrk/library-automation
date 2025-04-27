using LibraryAutomation.Domain.Entities;

namespace LibraryAutomation.Application.Identity;

public interface IAuthenticator
{
    User? Authenticate(string usernameOrEmail, string password);
}
