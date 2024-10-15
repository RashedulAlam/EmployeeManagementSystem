using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementService.Infrastructure.Persistence.Repositories;

public class GenericRepository<T, TU>(DbContext context) : IGenericRepository<T, TU>
    where T : class
{
    private readonly DbSet<T> DbSet = context.Set<T>();

    public IQueryable<T> GetAll()
    {
        return this.DbSet.AsQueryable();
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> filter)
    {
        return this.DbSet.Where(filter).AsQueryable();
    }

    public async Task<T> Get(TU id)
    {
        return await this.DbSet.FindAsync(id);
    }

    public async Task<T> Add(T entity)
    {
        var newEntity = await this.DbSet.AddAsync(entity);

        return newEntity.Entity;
    }

    public Task<T> Update(T entity)
    {
        var updatedEntity = this.DbSet.Update(entity);

        return Task.FromResult(updatedEntity.Entity);
    }

    public async Task Remove(T entity)
    {
        this.DbSet.Remove(entity);

        await Task.CompletedTask;
    }

    public async Task Remove(TU id)
    {
        var entity = await this.DbSet.FindAsync(id);

        if (entity != null)
        {
            await this.Remove(entity);
        }
    }
}