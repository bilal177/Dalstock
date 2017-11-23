using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Deposit
    {
        [Key]
        public int DepositId { get; set; }
        public string ItemId { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; }
        public string Deposited_By { get; set; }
        [ForeignKey("Deposited_By")]
        public virtual Staff Deposited_By_Staff { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
    }
}
