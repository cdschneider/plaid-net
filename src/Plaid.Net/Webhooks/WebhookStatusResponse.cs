using System;

namespace Plaid.Net.Webhooks
{
    public class WebhookStatusResponse
    {
        public DateTime SentAt { get; set; }
        
        public string CodeSent { get; set; }
    }
}