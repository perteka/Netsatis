using NetSatis.Entities.Interfaces;

namespace NetSatis.Entities.Repositories
{
    public interface IEntityRepository<Tcontext, TEntity> where TEntity : class, IEntity, new()
    {
    }
}