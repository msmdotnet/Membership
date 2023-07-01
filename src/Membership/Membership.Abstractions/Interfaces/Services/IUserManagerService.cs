namespace Membership.Abstractions.Interfaces.Services;
public interface IUserManagerService
{
    Task<IEnumerable<MembershipError>> RegisterUserAsync(UserDto user);
    Task<IEnumerable<MembershipError>> RegisterExternalUserAsync(
        ExternalUserEntity user);

    Task<UserEntity> GetUserByCredentialsAsync(UserCredentialsDto userCredentials);
    Task<UserEntity> GetUserByExternalCredentialsAsync(
        ExternalUserCredentials userCredentials);

    async Task ThrowIfUnableToRegisterUserAsync(UserDto user)
    {
        var Errors = await RegisterUserAsync(user);
        if (Errors != null && Errors.Any())
            throw new RegisterUserException(Errors);
    }
    async Task ThrowIfUnableToRegisterExternalUserAsync(ExternalUserEntity user)
    {
        var Errors = await RegisterExternalUserAsync(user);
        if (Errors != null && Errors.Any())
            throw new RegisterUserException(Errors);
    }

    async Task<UserEntity> ThrowIfUnableToGetUserByCredentialsAsync(
        UserCredentialsDto userCredentials)
    {
        var User = await GetUserByCredentialsAsync(userCredentials);
        if (User == default)
            throw new LoginUserException();
        return User;
    }

    async Task<UserEntity> ThrowIfUnableToGetUserByExternalCredentialsAsync(
    ExternalUserCredentials userCredentials)
    {
        var User = await GetUserByExternalCredentialsAsync(userCredentials);
        if (User == default)
            throw new LoginUserException();
        return User;
    }
}
