using Plaid.Net.Accounts;
using Plaid.Net.Core;

namespace Plaid.Net.Identity
{
    public class IdentityGetResponse : BasePlaidItemResponse
    {
        public AccountResponse[] Accounts { get; set; }
    }
}