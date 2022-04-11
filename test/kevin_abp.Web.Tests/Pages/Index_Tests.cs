using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace kevin_abp.Pages;

public class Index_Tests : kevin_abpWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
