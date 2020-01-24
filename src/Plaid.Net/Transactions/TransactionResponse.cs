using System;

namespace Plaid.Net.Transactions
{
    public class TransactionResponse
    {
        public string TransactionId;

        public string AccountId;

        public string Category;

        public string CategoryId;

        public TransactionType TransactionType;

        public string Name;

        public double Amount;

        public string IsoCurrencyCode;

        public string UnofficialCurrencyCode;

        public DateTime Date;

        public DateTime AuthorizedDate;

        public object Location; //TODO

        public object PaymentMetadata; //TODO

        public object PaymentChannel; //TODO

        public bool Pending;

        public string PendingTransactionId;

        public string AccountOwner;
    }
}