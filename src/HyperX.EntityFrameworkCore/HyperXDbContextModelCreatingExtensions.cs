using HyperX.Domain.Blog;
using HyperX.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace HyperX.EntityFrameworkCore;

public static class HyperXDbContextModelCreatingExtensions
{
    public static void Configure(this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        builder.Entity<Post>(b =>
           {
               b.ToTable(HyperXConsts.DbTablePrefix + DbTableName.Posts);
               b.HasKey(x => x.Id);
               b.Property(x => x.Title).HasMaxLength(200).IsRequired();
               b.Property(x => x.Author).HasMaxLength(10);
               b.Property(x => x.Url).HasMaxLength(100).IsRequired();
               
               b.Property(x => x.Html).HasColumnType("nvarchar(max)").IsRequired();
               b.Property(x => x.Markdown).HasColumnType("nvarchar(max)").IsRequired();
               b.Property(x => x.CategoryId).HasColumnType("int");
               b.Property(x => x.CreateTime).HasColumnType("datetime");
           });
           
        builder.Entity<Category>(b =>
        {
            b.ToTable(HyperXConsts.DbTablePrefix + DbTableName.Categories);
            b.HasKey(x => x.Id);
            b.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
            b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
        });

        builder.Entity<Tag>(b =>
        {
            b.ToTable(HyperXConsts.DbTablePrefix + DbTableName.Tags);
            b.HasKey(x => x.Id);
            b.Property(x => x.TagName).HasMaxLength(50).IsRequired();
            b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
        });

        builder.Entity<PostTag>(b =>
        {
            b.ToTable(HyperXConsts.DbTablePrefix + DbTableName.PostTags);
            b.HasKey(x => x.Id);
            b.Property(x => x.PostId).HasColumnType("int").IsRequired();
            b.Property(x => x.TagId).HasColumnType("int").IsRequired();
        });

        builder.Entity<FriendLink>(b =>
        {
            b.ToTable(HyperXConsts.DbTablePrefix + DbTableName.Friendlinks);
            b.HasKey(x => x.Id);
            b.Property(x => x.Title).HasMaxLength(20).IsRequired();
            b.Property(x => x.LinkUrl).HasMaxLength(100).IsRequired();
        });
    }
}