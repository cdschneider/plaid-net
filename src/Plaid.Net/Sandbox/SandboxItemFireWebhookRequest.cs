namespace Plaid.Net.Sandbox
{
    public class SandboxItemFireWebhookRequest
    {
        public string ClientId { get; set; }
        
        public string Secret { get; set; }
        
        public string AccessToken { get; set; }
        
        public string WebhookCode { get; set; }
    }
}