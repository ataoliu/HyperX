using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Modularity;
using HyperX.Domain;
using Volo.Abp.EntityFrameworkCore.Sqlite;

namespace HyperX.EntityFrameworkCore;

[DependsOn(
       typeof(HyperXDomainModule),
       typeof(AbpEntityFrameworkCoreModule),
       // typeof(AbpEntityFrameworkCoreMySQLModule),
       typeof(AbpEntityFrameworkCoreSqlServerModule),
       // typeof(AbpEntityFrameworkCorePostgreSqlModule),
       typeof(AbpEntityFrameworkCoreSqliteModule)
   )]
public class HyperXFrameworkCoreModule : AbpModule
{
   

    public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<HyperXDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                string  db="";//AppSettings.EnableDb
                switch (db)
                {
                    case "MySql":
                        // options.UseMySQL();
                        break;

                    case "SqlServer":
                        options.UseSqlServer();
                        break;

                    case "PostgreSql":
                        // options.UseNpgsql();
                        break;

                    case "Sqlite":
                        options.UseSqlite();
                        break;
                }
            });
        }
}
