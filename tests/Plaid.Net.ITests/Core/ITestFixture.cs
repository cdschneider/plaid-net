using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Plaid.Net.ITests
{
    public class ITestFixture : IDisposable
    {
        public ITestFixture()
        {
            var services = new ServiceCollection().AddLogging(opts => opts.SetMinimumLevel(LogLevel.Debug).AddConsole());
            services.AddHttpClient("plaid", client => 
                client.BaseAddress = new Uri("https://sandbox.plaid.com/"));
            
            ServiceProvider = services.BuildServiceProvider();
        }

        internal readonly IServiceProvider ServiceProvider;
        
        public void Dispose()
        {
        }
    }
}