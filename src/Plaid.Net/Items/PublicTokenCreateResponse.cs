using Plaid.Net.Core;

namespace Plaid.Net.Items
{
    public class PublicTokenCreateResponse : BasePlaidResponse
    {
        public string PublicToken { get; set; }
    }
}