using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Austine.Test.MultiTenancy.Dto;

namespace Austine.Test.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

