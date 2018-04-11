using System.Threading.Tasks;
using Abp.Application.Services;
using WeixinProject.Sessions.Dto;

namespace WeixinProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
