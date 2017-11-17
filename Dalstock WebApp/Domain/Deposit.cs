using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Deposit
    {
        private int DepositId;
        private int Amount;
        private DateTime dateTime;
        private ICollection<Staff> Staff;
    }
}
