using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Angular5AndDotNetCore5.Configuration;
using Angular5AndDotNetCore5.EntityFrameworkCore;
using Angular5AndDotNetCore5.Migrator.DependencyInjection;

namespace Angular5AndDotNetCore5.Migrator
{
    [DependsOn(typeof(Angular5AndDotNetCore5EntityFrameworkModule))]
    public class Angular5AndDotNetCore5MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public Angular5AndDotNetCore5MigratorModule(Angular5AndDotNetCore5EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(Angular5AndDotNetCore5MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                Angular5AndDotNetCore5Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Angular5AndDotNetCore5MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
