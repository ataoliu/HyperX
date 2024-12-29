
using HyperX.EntityFrameworkCore;
using HyperX.Swagger;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.AntiForgery;
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
    typeof(HyperXEntityFrameworkCoreModule)
)]

public class HyperXHttpApiHostingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        // 仅在开发环境禁用防伪验证
        if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            //预防 CSRF攻击的验证
            Configure<AbpAntiForgeryOptions>(options =>
            {
                options.AutoValidate = false;
            });

        }
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
