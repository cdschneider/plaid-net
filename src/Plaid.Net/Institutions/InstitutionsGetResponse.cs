using Plaid.Net.Core;

namespace Plaid.Net.Institutions
{
    public class InstitutionsGetResponse : BasePlaidResponse
    {
        public InstitutionResponse[] Institutions { get; set; }
        
        public int Total { get; set; }
    }
}