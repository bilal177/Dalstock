using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Debit
    {
        private int DebitId;
        private int Amount;
        private DateTime dateTime;
        private ICollection<Workplace> Workplaces;
        private ICollection<Staff> Staff;
    }
}
