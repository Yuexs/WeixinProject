using Abp.Authorization;
using WeixinProject.Authorization.Roles;
using WeixinProject.Authorization.Users;

namespace WeixinProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
