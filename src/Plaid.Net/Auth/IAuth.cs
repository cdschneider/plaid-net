using System.Threading.Tasks;

namespace Plaid.Net.Auth
{
    public interface IAuth
    {
        AuthGetResponse Get(AuthGetRequest request);
        Task<AuthGetResponse> GetAsync(AuthGetRequest request);
    }
}