namespace Plaid.Net.Institutions
{
    public class InstitutionStatus
    {
        public dynamic ItemLogins { get; set; }
        
        public dynamic TransactionUpdates { get; set; }
        
        public dynamic Auth { get; set; }
        
        public dynamic Balance { get; set; }
        
        public dynamic Identity { get; set; }
    }
}