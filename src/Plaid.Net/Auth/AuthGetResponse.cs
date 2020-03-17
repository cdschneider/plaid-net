using Plaid.Net.Accounts;
using Plaid.Net.Core;

namespace Plaid.Net.Auth
{
    public class AuthGetResponse : BasePlaidItemResponse
    {
        public AccountResponse[] Accounts { get; set; }
        
        //TODO add numbers
    }
}