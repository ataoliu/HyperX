using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HyperX.DbMigrator.EntityFrameworkCore;

public class HyperXMigrationsDbContextFactory : IDesignTimeDbContextFactory<HyperXMigrationsDbContext>
{
    public HyperXMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HyperXMigrationsDbContext>().UseSqlServer(configuration.GetConnectionString("Default"));

        return new HyperXMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        return builder.Build();
    }
}