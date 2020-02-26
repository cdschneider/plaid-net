using Plaid.Net.Categories;
using Plaid.Net.Institutions;
using Plaid.Net.Sandbox;

namespace Plaid.Net
{
    public interface IPlaidClient
    {
        ISandbox Sandbox { get; }
        
        IInstitutions Institutions { get; }
        
        ICategories Categories { get; }
    }
}