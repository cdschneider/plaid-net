namespace Plaid.Net
{
    public class PlaidClient : IPlaidClient
    {
        internal PlaidClient() {}
        
        public ISandbox Sandbox { get; }

        public static PlaidClientBuilder Builder()
        {
            return new PlaidClientBuilder();
        }
    }
}