
using HyperX.EntityFrameworkCore;
using HyperX.Swagger;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HyperX.HttpApi.Hosting;

/// <summary>
/// This module is used to register services to the host.
/// </summary>
[DependsOn(
    typeof(AbpAspNetCoreMvcModule),
    typeof(AbpAutofacModule),
    typeof(HyperXHttpApiModule),
    typeof(HyperXSwaggerModule),
    typeof(HyperXFrameworkCoreModule)
)]

public class HyperXHttpApiHostingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
    }

    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        // 环境变量，开发环境
        if (env.IsDevelopment())
        {
            // 生成异常页面
            app.UseDeveloperExceptionPage();
        }

        // 路由
        app.UseRouting();

        // 路由映射
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
