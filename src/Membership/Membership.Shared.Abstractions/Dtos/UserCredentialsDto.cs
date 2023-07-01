namespace Membership.Shared.Abstractions.Dtos;
public class UserCredentialsDto
{
    public string Email { get; }
    public string Password { get; }

    public UserCredentialsDto(string email, string password)
    {
        Email = email;
        Password = password;
    }
}
