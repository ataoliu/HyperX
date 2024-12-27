using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HyperX.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HyperXDbContextFactory : IDesignTimeDbContextFactory<HyperXDbContext>
{
    public HyperXDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        HyperXEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<HyperXDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new HyperXDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../HyperX.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
