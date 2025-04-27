using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.Infrastructure.Repositories;

public interface IRepository<TEntity> where TEntity : EntityBase
{
    DbContext DbContext { get; }
    DbSet<TEntity> DbSet { get; }
    IQueryable<TEntity> Query { get; }

    TEntity? Get(int id);
    ICollection<TEntity> GetAll();
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    bool Delete(int id);
}
