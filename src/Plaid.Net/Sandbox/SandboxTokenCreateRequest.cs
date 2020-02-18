namespace Plaid.Net.Sandbox
{
    public class SandboxTokenCreateRequest
    {
        public string InstitutionId { get; set; }

        public string PublicKey { get; set; }

        public string[] InitialProducts { get; set; }

        public SandboxTokenCreateOptions Options { get; set; }
    }
    
    public class SandboxTokenCreateOptions
    {
        public string Webhook { get; set; }

        public string OverrideUsername { get; set; }
        
        public string OverridePassword { get; set; }
    }
}