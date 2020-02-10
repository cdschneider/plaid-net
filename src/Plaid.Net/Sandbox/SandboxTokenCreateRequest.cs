namespace Plaid.Net.Sandbox
{
    public class SandboxTokenCreateRequest
    {
        public string InstitutionId { get; set; }

        public string PublicKey { get; set; }

        public string[] InitialProducts { get; set; }

        public SandboxTokenCreateOptions Options { get; set; }
    }
}