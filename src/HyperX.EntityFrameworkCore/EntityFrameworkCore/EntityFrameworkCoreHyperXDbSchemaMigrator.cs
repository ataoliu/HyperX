using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using HyperX.Data;
using Volo.Abp.DependencyInjection;

namespace HyperX.EntityFrameworkCore;

public class EntityFrameworkCoreHyperXDbSchemaMigrator
    : IHyperXDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreHyperXDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the HyperXDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<HyperXDbContext>()
            .Database
            .MigrateAsync();
    }
}
