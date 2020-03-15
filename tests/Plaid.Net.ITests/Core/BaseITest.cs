using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Plaid.Net.Core;
using Xunit;

namespace Plaid.Net.ITests.Core
{
    public class BaseITest : IDisposable
    {
        public BaseITest()
        {
            var services = new ServiceCollection();
            services.AddLogging(opts => opts.SetMinimumLevel(LogLevel.Debug).AddConsole());
            services.AddHttpClient("plaid",c => c.BaseAddress = new Uri("https://sandbox.plaid.com/"));
            
            var provider = services.BuildServiceProvider();
            var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
            Client = new PlaidClient(httpClientFactory);
            
            ClientId = Environment.GetEnvironmentVariable("PLAID_API_CLIENT_ID");
            Secret = Environment.GetEnvironmentVariable("PLAID_API_SECRET");
            PublicKey = Environment.GetEnvironmentVariable("PLAID_API_PUBLIC_KEY");
            
            Assert.NotNull(ClientId);
            Assert.NotNull(Secret);
            Assert.NotNull(PublicKey);
        }

        protected string ClientId { get; private set; }
        protected string Secret { get; private set; }
        protected string PublicKey { get; private set; }
        protected IPlaidClient Client { get; private set; }

        protected void AssertResponse(BasePlaidResponse response)
        {
            Assert.NotNull(response);
            Assert.NotNull(response.RequestId);
        }
        
        public void Dispose()
        {
            //TODO
        }
    }
}