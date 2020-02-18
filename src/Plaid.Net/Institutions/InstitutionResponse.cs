namespace Plaid.Net.Institutions
{
    public class InstitutionResponse
    {
        public string InstitutionId { get; set; }
        
        public string Name { get; set; }
        
        public string[] Products { get; set; }
        
        public string[] CountryCodes { get; set; }
        
        public InstitutionStatus Status { get; set; }
        
        public string Url { get; set; }
        
        public string PrimaryColor { get; set; }
        
        public string Logo { get; set; }
        
        public string[] RoutingNumbers { get; set; }
    }
}