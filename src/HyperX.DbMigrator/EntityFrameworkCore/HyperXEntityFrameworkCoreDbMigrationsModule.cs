using HyperX.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace HyperX.DbMigrator.EntityFrameworkCore;
public class HyperXEntityFrameworkCoreDbMigrationsModule:AbpModule
{
    [DependsOn(typeof(HyperXEntityFrameworkCoreModule))]
    public class MeowvBlogEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HyperXMigrationsDbContext>();
        }
    }
}