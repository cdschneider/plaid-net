using Plaid.Net.Core;

namespace Plaid.Net.Accounts
{
    public class AccountBalancesGetResponse : BasePlaidItemResponse
    {
        public AccountResponse[] Accounts { get; set; }
    }
}