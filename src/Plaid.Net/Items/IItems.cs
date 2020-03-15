using System.Threading.Tasks;

namespace Plaid.Net.Items
{
    public interface IItems
    {
        ItemGetResponse Get(ItemGetRequest request);
        Task<ItemGetResponse> GetAsync(ItemGetRequest request);
        PublicTokenCreateResponse PublicTokenCreate(PublicTokenCreateRequest request);
        Task<PublicTokenCreateResponse> PublicTokenCreateAsync(PublicTokenCreateRequest request);
        PublicTokenExchangeResponse PublicTokenExchange(PublicTokenExchangeRequest request);
        Task<PublicTokenExchangeResponse> PublicTokenExchangeAsync(PublicTokenExchangeRequest request);
    }
}