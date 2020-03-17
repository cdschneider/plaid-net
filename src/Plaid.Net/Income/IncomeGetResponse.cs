using Plaid.Net.Core;

namespace Plaid.Net.Income
{
    public class IncomeGetResponse : BasePlaidItemResponse
    {
        public IncomeResponse Income { get; set; }
    }
}