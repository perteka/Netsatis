using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.İnterfaces
{
    public interface IEntityRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
    {
        void AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);
    }
}
