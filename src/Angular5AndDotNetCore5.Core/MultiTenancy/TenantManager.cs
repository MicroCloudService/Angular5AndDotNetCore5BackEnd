using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Angular5AndDotNetCore5.Authorization.Users;
using Angular5AndDotNetCore5.Editions;

namespace Angular5AndDotNetCore5.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
