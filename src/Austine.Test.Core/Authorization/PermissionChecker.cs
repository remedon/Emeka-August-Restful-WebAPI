using Abp.Authorization;
using Austine.Test.Authorization.Roles;
using Austine.Test.Authorization.Users;

namespace Austine.Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
