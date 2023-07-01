namespace Membership.Abstractions.Entities;
public class MembershipError
{
    public string Code { get; }
    public string Description { get; }

    public MembershipError(string code, string description)
    {
        Code = code;
        Description = description;
    }
}
