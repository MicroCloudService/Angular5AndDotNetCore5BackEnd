using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Angular5AndDotNetCore5.Configuration;

namespace Angular5AndDotNetCore5.Web.Host.Startup
{
    [DependsOn(
       typeof(Angular5AndDotNetCore5WebCoreModule))]
    public class Angular5AndDotNetCore5WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Angular5AndDotNetCore5WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Angular5AndDotNetCore5WebHostModule).GetAssembly());
        }
    }
}
