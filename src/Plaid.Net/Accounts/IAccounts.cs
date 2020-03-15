using System.Threading.Tasks;

namespace Plaid.Net.Accounts
{
    public interface IAccounts
    {
        AccountGetResponse Get(AccountGetRequest request);
        Task<AccountGetResponse> GetAsync(AccountGetRequest request);
        AccountBalancesGetResponse GetBalance(AccountBalancesGetRequest request);
        Task<AccountBalancesGetResponse> GetBalanceAsync(AccountBalancesGetRequest request);
    }
}