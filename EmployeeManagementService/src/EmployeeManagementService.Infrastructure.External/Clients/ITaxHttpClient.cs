using EmployeeManagementService.Infrastructure.External.Requests;
using EmployeeManagementService.Infrastructure.External.Responses;

namespace EmployeeManagementService.Infrastructure.External.Clients
{
    public interface ITaxHttpClient
    {
        public Task<IReadOnlyCollection<TaxInformationResponse>> GetTaxInformation(TaxInformationRequest request);
    }
}
