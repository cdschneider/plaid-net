namespace Plaid.Net.Institutions
{
    public class InstitutionsSearchRequest
    {
        public string Query { get; set; }
        
        public string[] Products { get; set; }
        
        public string PublicKey { get; set; }
        
        public dynamic Options { get; set; }
    }

    public class InstitutionsSearchOptions
    {
        public bool IncludeOptionalMetadata { get; set; }
        
        public string[] CountryCodes { get; set; }
        
        public string[] RoutingNumbers { get; set; }
    }
}