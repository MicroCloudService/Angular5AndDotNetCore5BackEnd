using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Angular5AndDotNetCore5.Authorization.Roles;
using Angular5AndDotNetCore5.Authorization.Users;
using Angular5AndDotNetCore5.MultiTenancy;

namespace Angular5AndDotNetCore5.EntityFrameworkCore
{
    public class Angular5AndDotNetCore5DbContext : AbpZeroDbContext<Tenant, Role, User, Angular5AndDotNetCore5DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Angular5AndDotNetCore5DbContext(DbContextOptions<Angular5AndDotNetCore5DbContext> options)
            : base(options)
        {
        }
    }
}
