namespace Plaid.Net.Transactions
{
    public class TransactionLocation
    {
        public string Address { get; set; }
        
        public string City { get; set; }
        
        public string Region { get; set; }
        
        public string PostalCode { get; set; }
        
        public string Country { get; set; }
        
        public double Lat { get; set; }
        
        public double Lon { get; set; }
        
        public long StoreNumber { get; set; }
    }
}