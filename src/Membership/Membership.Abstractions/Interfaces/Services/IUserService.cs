namespace Membership.Abstractions.Interfaces.Services;
public interface IUserService
{
    bool IsAuthenticated { get; }
    string Email { get; }
    string FullName { get; }

    void ThrowIfNotIsAuthenticated()
    {
        if (!IsAuthenticated)
            throw new UnauthorizedAccessException();
    }
}
