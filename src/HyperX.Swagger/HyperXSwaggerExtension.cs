using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace HyperX.Swagger;
public static class HyperXSwaggerExtension
{
    public static IServiceCollection AddSwagger(this IServiceCollection services)
    {
        return services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
             {
                    Title = "HyperX API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "lat",
                        Email = "liuatao218@gmail.com",
                        Url = new Uri("https://www.example.com")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "HyperX.HttpApi.xml"));
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "HyperX.Domain.xml"));
            options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "HyperX.Application.Contracts.xml"));
        });
    }

    public static void UseSwaggerUI(this IApplicationBuilder app)
    {
        app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint($"/swagger/v1/swagger.json", "默认接口");
        });
    }
}