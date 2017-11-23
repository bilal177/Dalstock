using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface ItemManagerService
    {
        IEnumerable<Item> GetItems();
        Item GetItem(string id);
        Item AddItem(Item item);
        Item ChangeItem(Item item);
        IEnumerable<Workplace> GetWorkplaces();
        Workplace GetWorkplace(string id);
    }
}
