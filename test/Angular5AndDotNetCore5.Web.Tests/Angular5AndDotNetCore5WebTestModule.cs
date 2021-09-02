using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Angular5AndDotNetCore5.EntityFrameworkCore;
using Angular5AndDotNetCore5.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Angular5AndDotNetCore5.Web.Tests
{
    [DependsOn(
        typeof(Angular5AndDotNetCore5WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class Angular5AndDotNetCore5WebTestModule : AbpModule
    {
        public Angular5AndDotNetCore5WebTestModule(Angular5AndDotNetCore5EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Angular5AndDotNetCore5WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(Angular5AndDotNetCore5WebMvcModule).Assembly);
        }
    }
}