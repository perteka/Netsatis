using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Interfaces;

namespace NetSatis.Entities.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity> : IEntityRepository<TContext, TEntity>

        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        public void AddOrUpdate(TContext context, TEntity entity)
        {
            context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
