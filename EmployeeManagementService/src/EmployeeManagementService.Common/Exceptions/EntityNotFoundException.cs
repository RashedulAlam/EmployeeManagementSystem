namespace EmployeeManagementService.Common.Exceptions
{
    public class EntityNotFoundException(string entityName, string entityId)
        : ValidationException(string.Format(ExceptionMessageFormat,entityName, entityId))
    {
        private const string ExceptionMessageFormat = "The {0} given by {1} does not exist.";
    }
}
