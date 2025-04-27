using LibraryAutomation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAutomation.Infrastructure.Repositories;

public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : EntityBase, new()
{
    protected RepositoryBase(DbContext dbContext)
    {
        DbContext = dbContext;
        DbSet = dbContext.Set<TEntity>();
    }

    public DbContext DbContext { get; }
    public DbSet<TEntity> DbSet { get; }
    public IQueryable<TEntity> Query => DbSet.AsQueryable();
    public virtual TEntity? Get(int id) => DbSet.Find(id);
    public virtual ICollection<TEntity> GetAll() => DbSet.AsNoTracking().ToList();
    public virtual TEntity Add(TEntity entity)
    {
        DbSet.Add(entity);
        DbContext.SaveChanges();
        return entity;
    }
    public virtual TEntity Update(TEntity entity)
    {
        DbSet.Update(entity);
        DbContext.SaveChanges();
        return entity;
    }
    public virtual bool Delete(int id)
    {
        var entity = Get(id);
        if (entity == null) return false;
        DbSet.Remove(entity);
        DbContext.SaveChanges();
        return true;
    }
}

public class GenericReposirtory<TEntity> : RepositoryBase<TEntity> where TEntity : EntityBase, new()
{
    public GenericReposirtory(DbContext dbContext) : base(dbContext)
    {
    }
}
