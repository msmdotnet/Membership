namespace Membership.Shared.Abstractions.Dtos;
public class UserDto
{
    public string Email { get; }
    public string Password { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public UserDto(string email, string password,
        string firstName, string lastName)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }
}
