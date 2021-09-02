using Abp.MultiTenancy;
using Angular5AndDotNetCore5.Authorization.Users;

namespace Angular5AndDotNetCore5.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
