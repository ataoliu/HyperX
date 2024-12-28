using HyperX.DbMigrator.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


CreateHostBuilder(args).Build().Run();


static IHostBuilder CreateHostBuilder(string[] args) =>
   Host.CreateDefaultBuilder(args)
       .ConfigureAppConfiguration(config =>
       {
           config.AddJsonFile("appsettings.json", optional: false);
       })
       .ConfigureServices((hostContext, services) =>
       {
           services.AddApplication<HyperXEntityFrameworkCoreDbMigrationsModule>();
       });
