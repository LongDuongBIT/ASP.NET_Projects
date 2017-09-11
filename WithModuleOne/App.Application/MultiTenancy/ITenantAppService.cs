using Abp.Application.Services;
using Abp.Application.Services.Dto;
using App.MultiTenancy.Dto;

namespace App.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
