namespace Membership.Abstractions.Exceptions;
public class RefreshTokenNotFoundException : Exception
{
    public RefreshTokenNotFoundException()
    {
    }

    public RefreshTokenNotFoundException(string? message) : base(message)
    {
    }

    public RefreshTokenNotFoundException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
