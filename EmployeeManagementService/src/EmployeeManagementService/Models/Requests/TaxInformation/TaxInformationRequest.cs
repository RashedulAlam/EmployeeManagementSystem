using EmployeeManagementService.Business.Features.Common.Requests;

namespace EmployeeManagementService.Models.Requests.TaxInformation;

public class TaxInformationRequest : IPaginatedRequest
{
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
}