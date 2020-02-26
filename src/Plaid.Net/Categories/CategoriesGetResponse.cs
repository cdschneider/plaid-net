using Plaid.Net.Core;

namespace Plaid.Net.Categories
{
    public class CategoriesGetResponse : BasePlaidResponse
    {
        public CategoriesResponse[] Categories { get; set; }
    }
}