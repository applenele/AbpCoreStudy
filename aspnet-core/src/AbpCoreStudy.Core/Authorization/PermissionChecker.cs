using Abp.Authorization;
using AbpCoreStudy.Authorization.Roles;
using AbpCoreStudy.Authorization.Users;

namespace AbpCoreStudy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
