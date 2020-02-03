namespace Plaid.Net
{
    public class PlaidClient : IPlaidClient
    {
        public PlaidClient(BasePlaidClient client)
        {
            
        }
        
        public ISandbox Sandbox { get; }
    }
}