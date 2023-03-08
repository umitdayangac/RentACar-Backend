using System.Linq.Expressions;
using Core.DataAccess.Abstract;
using Core.Entities;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.Concrete.EntityFramework;

public class EntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> 
    where TEntity : class,IEntity,new() 
    where TContext : DbContext,new()
{
    public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
    {
        using var context = new TContext();
        return filter == null
            ? context.Set<TEntity>().ToList()
            : context.Set<TEntity>().Where(filter).ToList();
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
        using var context = new TContext();
        return context.Set<TEntity>().SingleOrDefault(filter)!;
    }

    public void Add(TEntity entity)
    {
        using var context = new TContext();
        var addedEntity = context.Entry(entity);
        addedEntity.State = EntityState.Added;
        context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        using var context = new TContext();
        var updateEntity = context.Entry(entity);
        updateEntity.State = EntityState.Modified;
        context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        using var context = new TContext();
        var deleteEntity = context.Entry(entity);
        deleteEntity.State = EntityState.Deleted;
        context.SaveChanges();
    }
}