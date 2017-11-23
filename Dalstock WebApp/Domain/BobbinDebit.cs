using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BobbinDebit
    {
        [Key]
        public int BobbinDebitId { get; set; }
        public string BobbinId { get; set; }
        [ForeignKey("BobbinId")]
        public virtual Bobbin Bobbin { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public int AmountUsed { get; set; }
        public string WorkplaceId { get; set; }
        [ForeignKey("WorkplaceId")]
        public virtual Workplace Workplace { get; set; }
    }
}
