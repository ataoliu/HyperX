using Microsoft.EntityFrameworkCore;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity;

namespace HyperX.EntityFrameworkCore;


[ConnectionStringName("Default")]
public class HyperXDbContext :
    AbpDbContext<HyperXDbContext>
    // ITenantManagementDbContext,
    // IIdentityDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */


    #region Entities from the modules

    /* Notice: We only implemented IIdentityProDbContext and ISaasDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityProDbContext and ISaasDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    // Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }
    public DbSet<IdentitySession> Sessions { get; set; }

    // Tenant Management
    // public DbSet<Tenant> Tenants { get; set; }
    // public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public HyperXDbContext(DbContextOptions<HyperXDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        // builder.ConfigurePermissionManagement();
        // builder.ConfigureSettingManagement();
        // builder.ConfigureBackgroundJobs();
        // builder.ConfigureAuditLogging();
        // builder.ConfigureFeatureManagement();
        // builder.ConfigureIdentity();
        // builder.ConfigureOpenIddict();
        // builder.ConfigureTenantManagement();
        // builder.ConfigureBlobStoring();
        
        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(HyperXConsts.DbTablePrefix + "YourEntities", HyperXConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
    }
}