using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;
using HyperX.Domain;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using HyperX.Domain.Configurations;

namespace HyperX.EntityFrameworkCore;

[DependsOn(
       typeof(HyperXDomainModule),
       typeof(AbpEntityFrameworkCoreModule),
       // typeof(AbpEntityFrameworkCoreMySQLModule),
       typeof(AbpEntityFrameworkCoreSqlServerModule),
       // typeof(AbpEntityFrameworkCorePostgreSqlModule),
       typeof(AbpEntityFrameworkCoreSqliteModule)
   )]
public class HyperXEntityFrameworkCoreModule : AbpModule
{


    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<HyperXDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {

            switch (AppSettings.DefaultKey)
            {
                case "MySql":
                    // options.UseMySQL();
                    break;
                case "MSSQL":
                    options.UseSqlServer();
                    break;

                case "PostgreSql":
                    // options.UseNpgsql();
                    break;
                case "SQLLite":
                    options.UseSqlite();
                    break;
            }
        });
    }
}
