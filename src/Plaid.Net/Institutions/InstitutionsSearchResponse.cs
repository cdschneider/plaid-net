using Plaid.Net.Core;

namespace Plaid.Net.Institutions
{
    public class InstitutionsSearchResponse : BasePlaidResponse
    {
        public InstitutionResponse[] Institutions { get; set; }
    }
}