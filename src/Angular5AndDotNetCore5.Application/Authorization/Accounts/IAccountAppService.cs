using System.Threading.Tasks;
using Abp.Application.Services;
using Angular5AndDotNetCore5.Authorization.Accounts.Dto;

namespace Angular5AndDotNetCore5.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
