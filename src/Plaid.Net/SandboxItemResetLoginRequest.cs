namespace Plaid.Net
{
    public class SandboxItemResetLoginRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
    }
}