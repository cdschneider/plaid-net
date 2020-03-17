using System.Threading.Tasks;

namespace Plaid.Net.Identity
{
    public interface IIdentity
    {
        IdentityGetResponse Get(IdentityGetRequest request);
        Task<IdentityGetResponse> GetAsync(IdentityGetRequest request);
    }
}