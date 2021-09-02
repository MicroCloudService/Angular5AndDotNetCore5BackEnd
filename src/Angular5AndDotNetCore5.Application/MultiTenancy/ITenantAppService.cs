using Abp.Application.Services;
using Angular5AndDotNetCore5.MultiTenancy.Dto;

namespace Angular5AndDotNetCore5.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

