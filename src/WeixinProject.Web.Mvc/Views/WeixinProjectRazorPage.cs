using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace WeixinProject.Web.Views
{
    public abstract class WeixinProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected WeixinProjectRazorPage()
        {
            LocalizationSourceName = WeixinProjectConsts.LocalizationSourceName;
        }
    }
}
