using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Angular5AndDotNetCore5.Roles.Dto;
using Angular5AndDotNetCore5.Users.Dto;

namespace Angular5AndDotNetCore5.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
