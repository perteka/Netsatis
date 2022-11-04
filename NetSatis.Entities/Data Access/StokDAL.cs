using NetSatis.Entities.Context;
using NetSatis.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Data_Access
{
    public class StokDAL
    {
        public void AddOrUpdate(NetSatisContext context, Stok entity)
        {
            context.Stoklar.AddOrUpdate(entity);
        }

        public void Delete(NetSatisContext context, Expression<Func<Stok, bool>> filter)
        {
            context.Stoklar.RemoveRange(context.Stoklar.Where(filter));
        }

        public void Save(NetSatisContext context)
        {
            context.SaveChanges();
        }
    }
}
