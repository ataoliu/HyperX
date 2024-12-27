using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace HyperX.Pages;

[Collection(HyperXTestConsts.CollectionDefinitionName)]
public class Index_Tests : HyperXWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
