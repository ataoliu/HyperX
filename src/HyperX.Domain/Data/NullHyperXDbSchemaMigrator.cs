using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace HyperX.Data;

/* This is used if database provider does't define
 * IHyperXDbSchemaMigrator implementation.
 */
public class NullHyperXDbSchemaMigrator : IHyperXDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
