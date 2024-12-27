using HyperX.Samples;
using Xunit;

namespace HyperX.EntityFrameworkCore.Domains;

[Collection(HyperXTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<HyperXEntityFrameworkCoreTestModule>
{

}
