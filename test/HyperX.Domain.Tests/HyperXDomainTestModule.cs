using HyperX.Domain;
using Volo.Abp.Modularity;

namespace HyperX;

[DependsOn(
    typeof(HyperXDomainModule),
    typeof(HyperXTestBaseModule)
)]
public class HyperXDomainTestModule : AbpModule
{

}
