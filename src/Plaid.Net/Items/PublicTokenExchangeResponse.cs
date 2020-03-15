using Plaid.Net.Core;

namespace Plaid.Net.Items
{
    public class PublicTokenExchangeResponse : BasePlaidResponse
    {
        public string AccessToken { get; set; }
        
        public string ItemId { get; set; }
    }
}