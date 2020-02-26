using Plaid.Net.Core;

namespace Plaid.Net.Income
{
    public class IncomeGetResponse : BasePlaidResponse
    {
        public object Item { get; set; }
        
        public IncomeResponse Income { get; set; }
    }
}