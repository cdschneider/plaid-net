using System;

namespace Plaid.Net.Items
{
    public class ItemResponse
    {
        public string ItemId { get; set; }
        
        public string InstitutionId { get; set; }
        
        public string Webhook { get; set; }
        
        public ItemErrorResponse Error { get; set; }
        
        public string[] AvailableProducts { get; set; }
        
        public string[] BilledProducts { get; set; }
        
        public DateTime? ConsentExpirationTime { get; set; }
    }
}