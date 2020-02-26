using System.Threading.Tasks;

namespace Plaid.Net.Categories
{
    public interface ICategories
    {
        CategoriesGetResponse Get();
        Task<CategoriesGetResponse> GetAsync();
    }
}