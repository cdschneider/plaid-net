using Plaid.Net.Core;

namespace Plaid.Net.Accounts
{
    public class AccountGetResponse : BasePlaidResponse
    {
        public AccountResponse[] Accounts { get; set; }
        
        public object Item { get; set; }
    }
}