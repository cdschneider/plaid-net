namespace Plaid.Net.Institutions
{
    public class InstitutionsGetRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public int Count { get; set; }

        public int Offset { get; set; } = 0;
        
        public InstitutionsGetOptions Options { get; set; }
    }

    public class InstitutionsGetOptions
    {
        public string[] Products { get; set; }
        
        public bool IncludeOptionalMetadata { get; set; }
        
        public string[] CountryCodes { get; set; }
        
        public string[] RoutingNumbers { get; set; }
    }
}