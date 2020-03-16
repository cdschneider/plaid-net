using System.Threading.Tasks;
using Plaid.Net.ITests.Core;
using Plaid.Net.Transactions;
using Xunit;

namespace Plaid.Net.ITests
{
    public class TransactionsHttpClientTests : BaseItemITest
    {
        protected override string InstitutionId => TestData.Institution1;
        protected override string Product => "transactions";
        
        [Fact]
        public void Get()
        {
            var client = Client.Transactions;
            var resp = client.Get(new TransactionsGetRequest
            {
                AccessToken = AccessToken,
                ClientId = ClientId,
                Secret = Secret
            });
            
            AssertItem(resp);
        }
    }
}