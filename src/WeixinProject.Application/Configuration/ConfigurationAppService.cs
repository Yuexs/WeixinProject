using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WeixinProject.Configuration.Dto;

namespace WeixinProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WeixinProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
