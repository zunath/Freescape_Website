using DotNetify;
using Freescape.Web.Attributes;
using Freescape.Web.Constants;
using Freescape.Web.Models.Contracts;

namespace Freescape.Web.ViewModels
{
    [RoleRequired(RoleType.Admin, RoleType.DM)]
    public class AdminViewModel: BaseVM
    {
        public AdminViewModel(ICurrentUser currentUser)
        {
            Role = currentUser.Role;
        }

        public RoleType Role
        {
            get => Get<RoleType>();
            set => Set(value);
        }
    }
}
