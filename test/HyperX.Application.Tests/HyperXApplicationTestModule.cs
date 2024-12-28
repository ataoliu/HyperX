using HyperX.Application;
using Volo.Abp.Modularity;

namespace HyperX;

[DependsOn(
    typeof(HyperXApplicationModule),
    typeof(HyperXDomainTestModule)
)]
public class HyperXApplicationTestModule : AbpModule
{

}
