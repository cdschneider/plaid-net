using System.Threading.Tasks;
using Plaid.Net.ITests.Core;
using Xunit;

namespace Plaid.Net.ITests
{
    public class CategoriesHttpClientTests : BaseITest
    {
        [Fact]
        public void Get()
        {
            var client = Client.Categories;
            var actual = client.Get();

            AssertResponse(actual);
            Assert.NotEmpty(actual.Categories);
        }
    }
}