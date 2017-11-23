using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Repository
{
    public class ItemRepository : ItemRepositoryService
    {
        private DalstockDbContext ctx;

        public ItemRepository()
        {
            ctx = new DalstockDbContext();
        }
        public Item CreateItem(Item item)
        {
            var newItem = ctx.Items.Add(item);
            ctx.SaveChanges();
            return newItem;
        }

        public Item ReadItem(string id)
        {
            return ctx.Items.Single(x => x.ItemId.Equals(id));
        }

        public IEnumerable<Item> ReadItems()
        {
            return ctx.Items;
        }

        public Workplace ReadWorkplace(string id)
        {
            return ctx.Workplaces.Single(x => x.WorkplaceId.Equals(id));
        }

        public IEnumerable<Workplace> ReadWorkplaces()
        {
            return ctx.Workplaces;
        }

        public Item UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
