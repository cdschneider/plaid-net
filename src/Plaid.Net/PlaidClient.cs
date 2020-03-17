using System.Net.Http;
using Plaid.Net.Accounts;
using Plaid.Net.Auth;
using Plaid.Net.Categories;
using Plaid.Net.Identity;
using Plaid.Net.Income;
using Plaid.Net.Institutions;
using Plaid.Net.Items;
using Plaid.Net.Sandbox;
using Plaid.Net.Transactions;

namespace Plaid.Net
{
    public sealed class PlaidClient : IPlaidClient
    {
        public PlaidClient(IHttpClientFactory httpClientFactory)
        {
            var httpClient = httpClientFactory.CreateClient("plaid");
            
            Sandbox = new SandboxHttpClient(httpClient);
            Institutions = new InstitutionsHttpClient(httpClient);
            Categories = new CategoriesHttpClient(httpClient);
            Accounts = new AccountsHttpClient(httpClient);
            Items = new ItemsHttpClient(httpClient);
            Transactions = new TransactionsHttpClient(httpClient);
            Income = new IncomeHttpClient(httpClient);
            Identity = new IdentityHttpClient(httpClient);
            Auth = new AuthHttpClient(httpClient);
        }
        
        public ISandbox Sandbox { get; }
        public IInstitutions Institutions { get; }
        public ICategories Categories { get; }
        public IAccounts Accounts { get; set; }
        public IItems Items { get; set; }
        public ITransactions Transactions { get; }
        public IIncome Income { get; }
        public IIdentity Identity { get; }
        public IAuth Auth { get; set; }
    }
}