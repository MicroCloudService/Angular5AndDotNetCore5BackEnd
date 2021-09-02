using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Angular5AndDotNetCore5.Authorization;

namespace Angular5AndDotNetCore5
{
    [DependsOn(
        typeof(Angular5AndDotNetCore5CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Angular5AndDotNetCore5ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Angular5AndDotNetCore5AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Angular5AndDotNetCore5ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
