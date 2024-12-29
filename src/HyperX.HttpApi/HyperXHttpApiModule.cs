using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using HyperX.Application;
using Microsoft.AspNetCore.Mvc;
using HyperX.HttpApi.Filters;

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
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            // 使用泛型重载方式注册过滤器
            Configure<MvcOptions>(options =>
            {
                options.Filters.Add<WebGlobalExceptionFilter>(); // 使用泛型方式添加过滤器
            });
        }
    }
}
