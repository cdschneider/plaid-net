using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Plaid.Net.ITests
{
    public class BaseITest : IClassFixture<ITestFixture>
    {
        private ITestFixture iTestFixture;

        public BaseITest(ITestFixture iTestFixture)
        {
            this.iTestFixture = iTestFixture;
            
            HttpClientFactory = iTestFixture.ServiceProvider.GetRequiredService<IHttpClientFactory>();
        }

        private readonly IHttpClientFactory HttpClientFactory;
        
        protected IPlaidClient Client()
        {
            return new PlaidClient(HttpClientFactory);
        }
    }
}