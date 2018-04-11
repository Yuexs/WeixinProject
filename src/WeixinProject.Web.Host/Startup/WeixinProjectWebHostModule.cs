using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WeixinProject.Configuration;

namespace WeixinProject.Web.Host.Startup
{
    [DependsOn(
       typeof(WeixinProjectWebCoreModule))]
    public class WeixinProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WeixinProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WeixinProjectWebHostModule).GetAssembly());
        }
    }
}
