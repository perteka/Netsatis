﻿using NetSatis.Entities.Context;
using NetSatis.Entities.Repositories;
using NetSatis.Entities.Tables;
using NetSatis.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NetSatis.Entities.Data_Access
{
    public class StokDAL:EntityRepositoryBase<NetSatisContext,Stok,StokValidator>
    {
     
   
    }
}
