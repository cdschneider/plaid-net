using Plaid.Net.Core;
using Plaid.Net.Items;
using Plaid.Net.Sandbox;
using Xunit;

namespace Plaid.Net.ITests.Core
{
    public abstract class BaseItemITest : BaseITest
    {
        public BaseItemITest()
        {
            var tokenCreateResponse = Client.Sandbox.TokenCreate(NewTokenRequest());
            Assert.NotNull(tokenCreateResponse);
            Assert.NotNull(tokenCreateResponse.RequestId);

            var tokenExchangeResponse = Client.Items.PublicTokenExchange(new PublicTokenExchangeRequest
            {
                PublicToken = tokenCreateResponse.PublicToken,
                ClientId = ClientId,
                Secret = Secret
            });
            
            Assert.NotNull(tokenExchangeResponse);
            Assert.NotNull(tokenExchangeResponse.RequestId);
            Assert.NotNull(tokenExchangeResponse.AccessToken);

            AccessToken = tokenExchangeResponse.AccessToken;
        }
        
        protected string AccessToken { get; private set; }
        
        protected abstract string InstitutionId { get; }
        // valid values are: transactions, auth, identity, income, assets, investments, liabilities
        protected abstract string Product { get; }

        private SandboxTokenCreateRequest NewTokenRequest()
        {
            return new SandboxTokenCreateRequest
                { PublicKey = PublicKey, InitialProducts = new[] { Product }, InstitutionId = InstitutionId };
        }

        protected void AssertItem(BasePlaidItemResponse itemResponse)
        {
            AssertResponse(itemResponse);
            Assert.NotNull(itemResponse.Item);
            Assert.Null(itemResponse.Item.Error);
            
            Assert.DoesNotContain(Product, itemResponse.Item.AvailableProducts);
            Assert.Contains(Product, itemResponse.Item.BilledProducts);
            Assert.Equal(InstitutionId, itemResponse.Item.InstitutionId);
        }
    }
}