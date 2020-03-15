using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Plaid.Net.Http
{
    public class PlaidApiCredentialHandler : DelegatingHandler
    {
        public PlaidApiCredentialHandler()
        {
            
        }
        
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            
            return null;
        }
    }
}