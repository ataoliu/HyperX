
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

using Volo.Abp;
using Volo.Abp.Modularity;
using HyperX.Domain;

namespace HyperX.Swagger;

[DependsOn(
    //...other dependencies
    typeof(HyperXDomainModule) // <-- Add module dependency like that
    )]
public class HyperXSwaggerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddSwagger();
        // services.AddAbpSwaggerGen(
        //     options =>
        //     {
        //         options.SwaggerDoc("v1", new OpenApiInfo
        //         {
        //             Title = "HyperX API",
        //             Version = "v1",
        //             Contact = new OpenApiContact
        //             {
        //                 Name = "lat",
        //                 Email = "liuatao218@gmail.com",
        //                 Url = new Uri("https://www.example.com")
        //             },
        //             License = new OpenApiLicense
        //             {
        //                 Name = "MIT",
        //                 Url = new Uri("https://opensource.org/licenses/MIT")
        //             }
        //         });
        //         options.DocInclusionPredicate((docName, description) => true);
        //         options.CustomSchemaIds(type => type.FullName);
        //     }
        // );
    }
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        var app = context.GetApplicationBuilder();

        app.UseSwagger();  // 启用 Swagger
        app.UseSwaggerUI();

    }
}
