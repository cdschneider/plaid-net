using Plaid.Net.Accounts;
using Plaid.Net.Categories;
using Plaid.Net.Institutions;
using Plaid.Net.Items;
using Plaid.Net.Sandbox;
using Plaid.Net.Transactions;

namespace Plaid.Net
{
    public interface IPlaidClient
    {
        ISandbox Sandbox { get; }
        IInstitutions Institutions { get; }
        ICategories Categories { get; }
        IAccounts Accounts { get; set; }
        IItems Items { get; set; }
        ITransactions Transactions { get; }
    }
}