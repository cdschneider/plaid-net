namespace Plaid.Net
{
    public class SandboxTokenCreateRequest
    {
        public string InstitutionId;

        public string PublicKey;

        public string[] InitialProducts;

        public SandboxTokenCreateOptions Options;
    }
}