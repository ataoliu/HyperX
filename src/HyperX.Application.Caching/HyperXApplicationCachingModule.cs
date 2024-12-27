using HyperX.Domain;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;

namespace HyperX.Application.Caching;
 [DependsOn(
        typeof(AbpCachingModule),
        typeof(HyperXDomainModule)
    )]
public class HyperXApplicationCachingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
    }
}