namespace EmployeeManagementService.Business.Features.Common.Requests
{
    public interface IPaginatedRequest
    {
        public int PageSize { get; set; }

        public int PageNumber { get; set; }
    }
}
