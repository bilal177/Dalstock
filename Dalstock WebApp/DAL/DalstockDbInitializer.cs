using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DalstockDbInitializer : CreateDatabaseIfNotExists<DalstockDbContext>
    {
        protected override void Seed(DalstockDbContext context)
        {
            Item item = new Item
            {
                ItemId = 2016768,
                Name = "test"
            };
            context.Items.Add(item);
            base.Seed(context);
        }
    }
}
