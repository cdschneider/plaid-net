using System.Net.Http;
using System.Threading.Tasks;
using Plaid.Net.Core;

namespace Plaid.Net.Income
{
    public class IncomeHttpClient : BasePlaidClient, IIncome
    {
        public IncomeHttpClient(HttpClient client) : base(client)
        {
        }

        public IncomeGetResponse Get(IncomeGetRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<IncomeGetResponse> GetAsync(IncomeGetRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}