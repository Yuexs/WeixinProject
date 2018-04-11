using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WeixinProject.Controllers
{
    public abstract class WeixinProjectControllerBase: AbpController
    {
        protected WeixinProjectControllerBase()
        {
            LocalizationSourceName = WeixinProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
