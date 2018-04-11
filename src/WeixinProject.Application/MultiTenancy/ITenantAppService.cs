using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WeixinProject.MultiTenancy.Dto;

namespace WeixinProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
