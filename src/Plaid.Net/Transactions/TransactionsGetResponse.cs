using System;

namespace Plaid.Net.Transactions
{
    public class TransactionsGetResponse
    {
        public string TransactionId { get; set; }
        
        public string AccountId { get; set; }
        
        public string[] Category { get; set; }
        
        public string CategoryId { get; set; }
        
        public string TransactionType { get; set; }
        
        public string Name { get; set; }
        
        public decimal Amount { get; set; }
        
        public string IsoCurrencyCode { get; set; }
        
        public string UnofficialCurrencyCode { get; set; }
        
        public DateTime Date { get; set; }
        
        public DateTime AuthorizedDate { get; set; }
        
        public TransactionLocation Location { get; set; }
        
        public TransactionPaymentMeta PaymentMeta { get; set; }
        
        public bool Pending { get; set; }
        
        public string PendingTransactionId { get; set; }
        
        public string AccountOwner { get; set; }
    }
}