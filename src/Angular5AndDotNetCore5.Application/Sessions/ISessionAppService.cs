using System.Threading.Tasks;
using Abp.Application.Services;
using Angular5AndDotNetCore5.Sessions.Dto;

namespace Angular5AndDotNetCore5.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
