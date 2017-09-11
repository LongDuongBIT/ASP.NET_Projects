using Abp.Authorization;
using App.Authorization.Roles;
using App.Authorization.Users;

namespace App.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
