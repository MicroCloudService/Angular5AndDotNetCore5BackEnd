using Abp.Authorization;
using Angular5AndDotNetCore5.Authorization.Roles;
using Angular5AndDotNetCore5.Authorization.Users;

namespace Angular5AndDotNetCore5.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
