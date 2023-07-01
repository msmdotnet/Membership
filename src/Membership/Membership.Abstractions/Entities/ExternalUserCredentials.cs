namespace Membership.Abstractions.Entities;
public class ExternalUserCredentials
{
    public string LoginProvider { get; }
    public string ProviderUserId { get; }

    public ExternalUserCredentials(string loginProvider, string providerUserId)
    {
        LoginProvider = loginProvider;
        ProviderUserId = providerUserId;
    }
}
