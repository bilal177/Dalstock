using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Workplace
    {
        [Key]
        public string WorkplaceId { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public virtual ICollection<Debit> Debits { get; set; }
        public virtual ICollection<BobbinDebit> BobbinDebits { get; set; }
    }
}
