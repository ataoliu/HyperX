using HyperX.Samples;
using Xunit;

namespace HyperX.EntityFrameworkCore.Applications;

[Collection(HyperXTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<HyperXEntityFrameworkCoreTestModule>
{

}
