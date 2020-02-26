using System.Threading.Tasks;

namespace Plaid.Net.Investments
{
    public interface IInvestments
    {
        InvestmentsGetHoldingsResponse GetHoldings();
        Task<InvestmentsGetHoldingsResponse> GetHoldingsAsync();
        InvestmentsGetTransactionsResponse GetTransactions();
        Task<InvestmentsGetTransactionsResponse> GetTransactionsAsync();
    }
}