using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bobbin
    {
        [Key]
        public string BobbinId { get; set; }
        public string CableTypeId { get; set; }
        [ForeignKey("CableTypeId")]
        public virtual CableType CableType { get; set; }
        public int CableLength { get; set; }
        public bool Returned { get; set; }
        public DateTime FetchDate { get; set; }
        public int AmountRemains { get; set; }
        public virtual ICollection<BobbinDebit> BobbinDebits { get; set; }
    }
}
