namespace Plaid.Net.Accounts
{
    public class AccountResponse
    {
        public string AccountId { get; set; }
        
        public object Balances { get; set; }
        
        public string Name { get; set; }
        
        public string Mask { get; set; }
        
        public string OfficialName { get; set; }
        
        public string Type { get; set; }
        
        public string Subtype { get; set; }
        
        public string VerificationStatus { get; set; }
    }
}