using System.Linq.Expressions;

namespace EmployeeManagementService.Infrastructure.Persistence.Repositories
{
    public interface IGenericRepository<T, in TU> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter);
        Task<T> Get(TU id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Remove(T entity);
        Task Remove(TU id);
    }
}
