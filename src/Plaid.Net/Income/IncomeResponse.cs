namespace Plaid.Net.Income
{
    public class IncomeResponse
    {
        public IncomeStream[] IncomeStreams { get; set; } 
        
        public int NumberOfIncomeStreams { get; set; }
        
        public int MaxNumberOfOverlappingIncomeStreams { get; set; }
        
        public int ProjectedYearlyIncome { get; set; }
        
        public int ProjectedYearlyIncomeBeforeTax { get; set; }
        
        public int LastYearIncome { get; set; }
        
        public int LastYearIncomeBeforeTax { get; set; }
    }
}