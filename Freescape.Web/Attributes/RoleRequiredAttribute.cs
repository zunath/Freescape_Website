using System;
using Freescape.Web.Constants;

namespace Freescape.Web.Attributes
{
    public class RoleRequiredAttribute: Attribute
    {
        public RoleType[] RolesRequired { get; }

        public RoleRequiredAttribute(params RoleType[] roles)
        {
            RolesRequired = roles;
        }
    }
}
