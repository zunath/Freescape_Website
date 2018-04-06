using Freescape.Web.Constants;

namespace Freescape.Web.Models.Contracts
{
    public interface ICurrentUser
    {
        bool IsAuthenticated { get; }
        string Username { get; }
        string DiscordUserID { get; }
        string Email { get; }
        string Discriminator { get; }
        string AvatarHash { get; }
        RoleType Role { get; }
    }
}
