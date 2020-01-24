namespace Plaid.Net
{
    public interface IPlaidClient
    {
        IAssets Assets { get; }
        
        IBalance Balance { get; }
        
        IIdentity Identity { get; }
        
        IIncome Income { get; }
        
        IInstitutions Institutions { get;  }
        
        IInvestments Investments { get; }
        
        ILiabilities Liabilities { get; }
        
        ITransactions Transactions { get; }
    }
}