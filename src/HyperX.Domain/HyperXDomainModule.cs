using Volo.Abp.Modularity;


using Volo.Abp.Identity;

namespace HyperX.Domain;

[DependsOn(typeof(AbpIdentityDomainModule))]

public class HyperXDomainModule : AbpModule
{

}
