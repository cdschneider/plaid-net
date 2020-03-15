using System.Threading.Tasks;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class CategoriesHttpClientTests : BaseITest
    {
        [Fact]
        public async Task GetAsync()
        {
            var client = Client.Categories;
            var actual = await client.GetAsync();

            AssertResponse(actual);
            Assert.NotEmpty(actual.Categories);
        }
    }
}