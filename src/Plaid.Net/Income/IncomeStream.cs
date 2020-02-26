namespace Plaid.Net.Income
{
    public class IncomeStream
    {
        public string Name { get; set; }
        
        public decimal Confidence { get; set; }
        
        public int MonthlyIncome { get; set; }
        
        public int Days { get; set; }
    }
}