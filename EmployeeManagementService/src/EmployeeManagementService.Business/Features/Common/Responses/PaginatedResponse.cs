namespace EmployeeManagementService.Business.Features.Common.Responses
{
    public class PaginatedResponse<T>
    {
        public int CurrentPage { get; set; }

        public int PageCount { get; set; }

        public int PageSize { get; set; }

        public IReadOnlyCollection<T> Items { get; set; }
    }
}
