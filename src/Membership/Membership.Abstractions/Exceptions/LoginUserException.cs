namespace Membership.Abstractions.Exceptions;
public class LoginUserException : Exception
{
    public LoginUserException()
    {
    }

    public LoginUserException(string? message) : base(message)
    {
    }

    public LoginUserException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
