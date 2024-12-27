using System.Threading.Tasks;

namespace HyperX.Data;

public interface IHyperXDbSchemaMigrator
{
    Task MigrateAsync();
}
