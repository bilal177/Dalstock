using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bobbin : Item
    {
        public int StartAmount { get; set; }
        public int EndAmount { get; set; }
    }
}
