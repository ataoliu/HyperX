using HyperX.Domain.Blog;
using Microsoft.EntityFrameworkCore;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;

namespace HyperX.EntityFrameworkCore;


[ConnectionStringName("MSSQL")]
public class HyperXDbContext : AbpDbContext<HyperXDbContext>
{
    public HyperXDbContext(DbContextOptions<HyperXDbContext> options) : base(options)
    {

    }

    #region Entities from the modules
    public DbSet<Post> Posts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<PostTag> PostTags { get; set; }
    public DbSet<FriendLink> FriendLinks { get; set; }
    #endregion



    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Configure();

    }
}
