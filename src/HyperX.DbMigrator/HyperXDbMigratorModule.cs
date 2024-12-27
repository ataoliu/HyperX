using HyperX.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace HyperX.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HyperXEntityFrameworkCoreModule),
    typeof(HyperXApplicationContractsModule)
)]
public class HyperXDbMigratorModule : AbpModule
{
}
