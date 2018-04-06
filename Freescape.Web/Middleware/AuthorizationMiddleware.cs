using System;
using System.Linq;
using System.Threading.Tasks;
using DotNetify;
using Freescape.Web.Attributes;
using Freescape.Web.Models.Contracts;
using Freescape.Web.ViewModels;
using IMiddleware = DotNetify.IMiddleware;

namespace Freescape.Web.Middleware
{
    public class AuthorizationMiddleware: IMiddleware
    {
        private readonly ICurrentUser _currentUser;

        public AuthorizationMiddleware(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        public Task Invoke(DotNetifyHubContext context, NextDelegate next)
        {
            Type type = Type.GetType($"{typeof(HomeViewModel).Namespace}.{context.VMId}");

            RoleRequiredAttribute attribute = type.GetCustomAttributes(typeof(RoleRequiredAttribute), true).FirstOrDefault() as RoleRequiredAttribute;
            
            if (attribute != null)
            {
                if (!attribute.RolesRequired.Contains(_currentUser.Role))
                {
                    return null;
                }
            }

            return next(context);
        }
    }
}
