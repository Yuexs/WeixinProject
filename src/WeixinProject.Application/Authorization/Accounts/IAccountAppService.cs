using System.Threading.Tasks;
using Abp.Application.Services;
using WeixinProject.Authorization.Accounts.Dto;

namespace WeixinProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
