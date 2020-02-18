namespace Plaid.Net.Transactions
{
    public class TransactionLocation
    {
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string Region { get; set; }
        
        public string PostalCode { get; set; }
        
        public string Country { get; set; }
        
        public decimal Lat { get; set; }
        
        public decimal Lon { get; set; }
        
        public int StoreNumber { get; set; }
    }
}