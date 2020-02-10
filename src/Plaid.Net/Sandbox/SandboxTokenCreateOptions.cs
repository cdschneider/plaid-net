namespace Plaid.Net.Sandbox
{
    public class SandboxTokenCreateOptions
    {
        public string Webhook { get; set; }

        public string OverrideUser { get; set; }
        
        public string OverridePassword { get; set; }
    }
}