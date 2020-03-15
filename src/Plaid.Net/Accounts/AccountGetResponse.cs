using Plaid.Net.Core;

namespace Plaid.Net.Accounts
{
    public class AccountGetResponse : BasePlaidItemResponse
    {
        public AccountResponse[] Accounts { get; set; }
    }
}