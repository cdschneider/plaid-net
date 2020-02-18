using System.Threading.Tasks;

namespace Plaid.Net.Institutions
{
    public interface IInstitutions
    {
        InstitutionsGetResponse Get(InstitutionsGetRequest request);
        Task<InstitutionsGetResponse> GetAsync(InstitutionsGetRequest request);
        InstitutionsGetByIdResponse GetById(InstitutionsGetByIdRequest request);
        Task<InstitutionsGetByIdResponse> GetByIdAsync(InstitutionsGetByIdRequest request);
        InstitutionsSearchResponse Search(InstitutionsSearchRequest request);
        Task<InstitutionsSearchResponse> SearchAsync(InstitutionsSearchRequest request);
    }
}