using System;

namespace Plaid.Net.Investments
{
    public class InvestmentsStatusResponse
    {
        public DateTime? LastSuccessfulUpdate { get; set; }
        
        public DateTime? LastFailedUpdate { get; set; }
    }
}