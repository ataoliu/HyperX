using HyperX.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace HyperX.DbMigrator.EntityFrameworkCore;


public class HyperXMigrationsDbContext : AbpDbContext<HyperXMigrationsDbContext>
{
    public HyperXMigrationsDbContext(DbContextOptions<HyperXMigrationsDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configure();
    }
}