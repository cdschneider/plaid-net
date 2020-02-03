using System.Net.Http;

namespace Plaid.Net
{
    public class PlaidClientBuilder
    {
        private string _clientId, _secret, _publicKey;
        private PlaidEnvironment _plaidEnvironment;
        
        private readonly IHttpClientFactory _clientFactory;

        public PlaidClientBuilder ClientId(string clientId)
        {
            _clientId = clientId;
            return this;
        }

        public PlaidClientBuilder Secret(string secret)
        {
            _secret = secret;
            return this;
        }

        public PlaidClientBuilder PublicKey(string publicKey)
        {
            _publicKey = publicKey;
            return this;
        }

        public PlaidClientBuilder ApiEnvironment(PlaidEnvironment plaidEnvironment)
        {
            _plaidEnvironment = plaidEnvironment;
            return this;
        }

        public IPlaidClient Build()
        {
            return null;
        }
    }
}