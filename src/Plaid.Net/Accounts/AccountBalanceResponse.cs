namespace Plaid.Net.Accounts
{
    public class AccountBalanceResponse
    {
        public decimal? Available { get; set; }
        
        public decimal Current { get; set; }

        public decimal? Limit { get; set; }
        
        public string IsoCurrencyCode { get; set; }
        
        public string UnofficialCurrencyCode { get; set; }
    }
}