using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Deposit
    {
        [Key]
        public int DepositId { get; set; }
        public int Amount { get; set; }
        public DateTime dateTime { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
