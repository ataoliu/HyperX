using System;
using HyperX.DbMigrator;
using HyperX.DbMigrator.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


using var host = CreateHostBuilder(args).Build();

// 应用迁移并更新数据库
ApplyMigrations(host);

Console.WriteLine("Database migration completed. Application is ready to run.");


static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddDbContext<HyperXMigrationsDbContext>(options =>
            {
                var connectionString = hostContext.Configuration.GetConnectionString("Default");
                options.UseSqlServer(connectionString);
            });

            services.AddHostedService<MigrationHostedService>();
        });

static void ApplyMigrations(IHost host)
{
    using var scope = host.Services.CreateScope();
    var dbContext = scope.ServiceProvider.GetRequiredService<HyperXMigrationsDbContext>();
    Console.WriteLine("Applying migrations...");
    dbContext.Database.Migrate();
}
