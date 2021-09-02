using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Angular5AndDotNetCore5.Configuration;
using Angular5AndDotNetCore5.Web;

namespace Angular5AndDotNetCore5.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Angular5AndDotNetCore5DbContextFactory : IDesignTimeDbContextFactory<Angular5AndDotNetCore5DbContext>
    {
        public Angular5AndDotNetCore5DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Angular5AndDotNetCore5DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Angular5AndDotNetCore5DbContextConfigurer.Configure(builder, configuration.GetConnectionString(Angular5AndDotNetCore5Consts.ConnectionStringName));

            return new Angular5AndDotNetCore5DbContext(builder.Options);
        }
    }
}
