using Plaid.Net.Core;

namespace Plaid.Net.Items
{
    public class ItemGetResponse : BasePlaidResponse
    {
        public ItemResponse Item { get; set; }
        
        public ItemStatusResponse Status { get; set; }
    }
}