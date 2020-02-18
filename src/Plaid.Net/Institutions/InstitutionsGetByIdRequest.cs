namespace Plaid.Net.Institutions
{
    public class InstitutionsGetByIdRequest
    {
        public string InstitutionId { get; set; }
        
        public string PublicKey { get; set; }
        
        public InstitutionsGetByIdOptions Options { get; set; }
    }

    public class InstitutionsGetByIdOptions
    {
        public bool IncludeOptionalMetadata { get; set; }
        
        public bool IncludeStatus { get; set; }
    }
}