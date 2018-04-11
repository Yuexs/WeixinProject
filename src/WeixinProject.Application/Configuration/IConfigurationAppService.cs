using System.Threading.Tasks;
using WeixinProject.Configuration.Dto;

namespace WeixinProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
