namespace Membership.Abstractions.Entities;
public class ExternalUserEntity
{
    public string Email { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string LoginProvider { get; }
    public string ProviderUserId { get; }

    public ExternalUserEntity(string email, string firstName, string lastName,
        string loginProvider, string providerUserId)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        LoginProvider = loginProvider;
        ProviderUserId = providerUserId;
    }
}

