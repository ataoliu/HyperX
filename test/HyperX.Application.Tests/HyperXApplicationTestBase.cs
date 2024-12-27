using Volo.Abp.Modularity;

namespace HyperX;

public abstract class HyperXApplicationTestBase<TStartupModule> : HyperXTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
