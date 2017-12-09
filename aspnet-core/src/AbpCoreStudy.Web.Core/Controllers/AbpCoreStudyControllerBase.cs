using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpCoreStudy.Controllers
{
    public abstract class AbpCoreStudyControllerBase: AbpController
    {
        protected AbpCoreStudyControllerBase()
        {
            LocalizationSourceName = AbpCoreStudyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
