using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Plaid.Net.ITests
{
    public class BaseITest : IClassFixture<ITestFixture>
    {
        public BaseITest(ITestFixture iTestFixture)
        {
            _httpClientFactory = iTestFixture.ServiceProvider.GetRequiredService<IHttpClientFactory>();
        }

        private readonly IHttpClientFactory _httpClientFactory;
        
        protected IPlaidClient Client()
        {
            return new PlaidClient(_httpClientFactory);
        }
    }
}