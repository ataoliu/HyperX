using HyperX.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HyperX.DbMigrator.EntityFrameworkCore;
[DependsOn(typeof(HyperXEntityFrameworkCoreModule))]

public class HyperXEntityFrameworkCoreDbMigrationsModule : AbpModule
{

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<HyperXMigrationsDbContext>();
    }

}