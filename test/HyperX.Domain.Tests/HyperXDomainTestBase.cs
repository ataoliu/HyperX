using Volo.Abp.Modularity;

namespace HyperX;

/* Inherit from this class for your domain layer tests. */
public abstract class HyperXDomainTestBase<TStartupModule> : HyperXTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
