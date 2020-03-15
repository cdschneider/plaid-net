using Plaid.Net.Investments;
using Plaid.Net.Transactions;
using Plaid.Net.Webhooks;

namespace Plaid.Net.Items
{
    public class ItemStatusResponse
    {
        public InvestmentsStatusResponse Investments { get; set; }
        
        public TransactionsStatusResponse Transactions { get; set; }
        
        public WebhookStatusResponse LastWebhook { get; set; }
    }
}