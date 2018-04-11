using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WeixinProject.Authorization;

namespace WeixinProject
{
    [DependsOn(
        typeof(WeixinProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WeixinProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WeixinProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WeixinProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
