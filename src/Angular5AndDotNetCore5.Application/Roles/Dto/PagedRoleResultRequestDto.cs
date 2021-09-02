using Abp.Application.Services.Dto;

namespace Angular5AndDotNetCore5.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

