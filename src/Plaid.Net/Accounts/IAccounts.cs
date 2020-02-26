using System.Threading.Tasks;

namespace Plaid.Net.Accounts
{
    public interface IAccounts
    {
        AccountGetResponse Get(AccountGetRequest request);
        Task<AccountGetResponse> GetAsync(AccountGetRequest request);
        AccountBalancesGetResponse GetBalances(AccountBalancesGetRequest request);
        Task<AccountBalancesGetResponse> GetBalancesAsync(AccountBalancesGetRequest request);
    }
}