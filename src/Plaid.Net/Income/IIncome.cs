using System.Threading.Tasks;

namespace Plaid.Net.Income
{
    public interface IIncome
    {
        IncomeGetResponse Get(IncomeGetRequest request);
        Task<IncomeGetResponse> GetAsync(IncomeGetRequest request);
    }
}