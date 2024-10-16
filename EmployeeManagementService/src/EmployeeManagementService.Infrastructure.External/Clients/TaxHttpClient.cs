using System.Net.Http.Json;
using EmployeeManagementService.Infrastructure.External.Requests;
using EmployeeManagementService.Infrastructure.External.Responses;

namespace EmployeeManagementService.Infrastructure.External.Clients;

public class TaxHttpClient(HttpClient httpClient) : ITaxHttpClient
{
    public async Task<IReadOnlyCollection<TaxInformationResponse>> GetTaxInformation(TaxInformationRequest request)
    {
        var response = await httpClient.GetAsync("");

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadFromJsonAsync<IReadOnlyCollection<TaxInformationResponse>>();
        }

        return null;
    }
}