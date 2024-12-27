using Volo.Abp.Modularity;

namespace HyperX.Application;

// [DependsOn(
//     typeof(HyperXDomainModule),
//     typeof(HyperXApplicationContractsModule),
//     typeof(AbpPermissionManagementApplicationModule),
//     typeof(AbpFeatureManagementApplicationModule),
//     typeof(AbpIdentityApplicationModule),
//     typeof(AbpAccountApplicationModule),
//     typeof(AbpTenantManagementApplicationModule),
//     typeof(AbpSettingManagementApplicationModule)
//     )]


// [DependsOn(
//         typeof(AbpIdentityApplicationModule)
//     )]
public class HyperXApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        // Configure<AbpAutoMapperOptions>(options =>
        // {
        //     options.AddMaps<HyperXApplicationModule>();
        // });
    }
}
