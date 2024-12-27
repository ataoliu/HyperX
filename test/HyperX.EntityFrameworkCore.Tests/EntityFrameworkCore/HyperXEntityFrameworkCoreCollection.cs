using Xunit;

namespace HyperX.EntityFrameworkCore;

[CollectionDefinition(HyperXTestConsts.CollectionDefinitionName)]
public class HyperXEntityFrameworkCoreCollection : ICollectionFixture<HyperXEntityFrameworkCoreFixture>
{

}
