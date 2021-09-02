using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Angular5AndDotNetCore5.EntityFrameworkCore.Seed;

namespace Angular5AndDotNetCore5.EntityFrameworkCore
{
    [DependsOn(
        typeof(Angular5AndDotNetCore5CoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class Angular5AndDotNetCore5EntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<Angular5AndDotNetCore5DbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        Angular5AndDotNetCore5DbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        Angular5AndDotNetCore5DbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Angular5AndDotNetCore5EntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
