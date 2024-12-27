using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using HyperX.Application;

namespace HyperX.HttpApi
{
    // [DependsOn(
    //    typeof(HyperXApplicationContractsModule),
    //    typeof(AbpPermissionManagementHttpApiModule),
    //    typeof(AbpSettingManagementHttpApiModule),
    //    typeof(AbpAccountHttpApiModule),
    //    typeof(AbpIdentityHttpApiModule),
    //    typeof(AbpTenantManagementHttpApiModule),
    //    typeof(AbpFeatureManagementHttpApiModule)
    //    )]
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(HyperXApplicationModule)
    )]
    public class HyperXHttpApiModule : AbpModule
    {
       
    }
}
