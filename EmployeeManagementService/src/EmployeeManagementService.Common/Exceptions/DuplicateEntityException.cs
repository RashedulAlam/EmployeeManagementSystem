namespace EmployeeManagementService.Common.Exceptions
{
    public class DuplicateEntityException(string entityName, string propertyName) : ValidationException(string.Format(ExceptionMessageFormat,entityName, propertyName))
    {
        private const string ExceptionMessageFormat = "The {0} given by {1} already exist.";
    }
}
