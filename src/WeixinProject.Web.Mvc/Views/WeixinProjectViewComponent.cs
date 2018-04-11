using Abp.AspNetCore.Mvc.ViewComponents;

namespace WeixinProject.Web.Views
{
    public abstract class WeixinProjectViewComponent : AbpViewComponent
    {
        protected WeixinProjectViewComponent()
        {
            LocalizationSourceName = WeixinProjectConsts.LocalizationSourceName;
        }
    }
}
