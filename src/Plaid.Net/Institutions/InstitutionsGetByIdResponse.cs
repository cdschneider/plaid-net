using Plaid.Net.Core;

namespace Plaid.Net.Institutions
{
    public class InstitutionsGetByIdResponse : BasePlaidResponse
    {
        public InstitutionResponse Institution { get; set; }
    }
}