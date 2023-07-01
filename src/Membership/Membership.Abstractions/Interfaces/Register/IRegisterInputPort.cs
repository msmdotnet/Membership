namespace Membership.Abstractions.Interfaces.Register;
public interface IRegisterInputPort
{
    Task RegisterAsync(UserDto user);
}
