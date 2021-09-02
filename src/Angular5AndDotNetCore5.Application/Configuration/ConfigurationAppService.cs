using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Angular5AndDotNetCore5.Configuration.Dto;

namespace Angular5AndDotNetCore5.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Angular5AndDotNetCore5AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
