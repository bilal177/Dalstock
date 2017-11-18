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
        public int WorkplaceId { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
    }
}
