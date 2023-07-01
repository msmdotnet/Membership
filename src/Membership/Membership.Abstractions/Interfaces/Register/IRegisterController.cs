namespace Membership.Abstractions.Interfaces.Register;
public interface IRegisterController
{
    Task RegisterAsync(UserDto user);
}

// TODO: Continuar con interfaces de Login 