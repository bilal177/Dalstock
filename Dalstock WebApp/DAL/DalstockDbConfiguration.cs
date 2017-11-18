﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DalstockDbConfiguration : DbConfiguration
    {
        public DalstockDbConfiguration()
        {
            SetDefaultConnectionFactory(new System.Data.Entity.Infrastructure.SqlConnectionFactory());
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);
            SetDatabaseInitializer(new DalstockDbInitializer());
        }
    }
}
