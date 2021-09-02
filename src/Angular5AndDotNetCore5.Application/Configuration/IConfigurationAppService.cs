using System.Threading.Tasks;
using Angular5AndDotNetCore5.Configuration.Dto;

namespace Angular5AndDotNetCore5.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
