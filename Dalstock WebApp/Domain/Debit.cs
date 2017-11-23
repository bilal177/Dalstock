using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Debit
    {
        [Key]
        public int DebitId { get; set; }
        public string ItemId { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; }
        public string WorkplaceId { get; set; }
        public string Debited_By { get; set; }
        public string Inserted_By { get; set; }
        [ForeignKey("WorkplaceId")]
        public virtual Workplace Workplace { get; set; }
        [ForeignKey("Debited_By")]
        public virtual Staff Debited_By_Staff { get; set; }
        [ForeignKey("Inserted_By")]
        public virtual Staff Inserted_By_Staff { get; set; }
    }
}
