using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using DAL.Repository;

namespace BL
{
    public class ItemManager : ItemManagerService
    {
        ItemRepositoryService repo;

        public ItemManager()
        {
            repo = new ItemRepository();
        }

        public Item AddItem(Item item)
        {
            return repo.CreateItem(item);
        }

        public Item ChangeItem(Item item)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(string id)
        {
            return repo.ReadItem(id);
        }

        public IEnumerable<Item> GetItems()
        {
            return repo.ReadItems();
        }

        public Workplace GetWorkplace(string id)
        {
            return repo.ReadWorkplace(id);
        }

        public IEnumerable<Workplace> GetWorkplaces()
        {
            return repo.ReadWorkplaces();
        }
    }
}
