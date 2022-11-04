using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NetSatis.Entities.Context;
using NetSatis.Entities.İnterfaces;
using NetSatis.Entities.Tables;

namespace NetSatis.Entities.Data_Access
{
    public class CariDAL : IEntityRepository<NetSatisContext, Cari>
    {
        public void AddOrUpdate(NetSatisContext context, Cari entity)
        {
            context.Cariler.AddOrUpdate(entity);
        }

        public void Delete(NetSatisContext context, Expression<Func<Cari, bool>> filter)
        {
            context.Cariler.RemoveRange(context.Cariler.Where(filter));
        }

        public void Save(NetSatisContext context)
        {
            context.SaveChanges();
        }
    }
}
