using System.Threading.Tasks;
using Xunit;

namespace Plaid.Net.ITests
{
    public class CategoriesHttpClientTests : BaseITest
    {
        public CategoriesHttpClientTests(ITestFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task Get()
        {
            var client = Client().Categories;
            var actual = await client.GetAsync();
            
            Assert.NotNull(actual);
            Assert.NotNull(actual.RequestId);
            Assert.NotEmpty(actual.Categories);
        }
    }
}