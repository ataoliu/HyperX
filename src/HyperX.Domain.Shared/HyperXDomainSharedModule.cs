using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace HyperX.Domain.Shared;
[DependsOn(typeof(AbpIdentityDomainSharedModule))]

public class HyperXDomainSharedModule : AbpModule
{

}
