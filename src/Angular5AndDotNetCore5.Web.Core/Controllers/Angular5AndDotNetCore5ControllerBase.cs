using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Angular5AndDotNetCore5.Controllers
{
    public abstract class Angular5AndDotNetCore5ControllerBase: AbpController
    {
        protected Angular5AndDotNetCore5ControllerBase()
        {
            LocalizationSourceName = Angular5AndDotNetCore5Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
