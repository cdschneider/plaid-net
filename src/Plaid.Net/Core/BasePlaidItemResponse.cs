using Plaid.Net.Items;

namespace Plaid.Net.Core
{
    public class BasePlaidItemResponse : BasePlaidResponse
    {
        public ItemResponse Item { get; set; }
    }
}