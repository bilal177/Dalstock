using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dalstock_WebApp.Models
{
    public class DebitViewModel
    {
        [Required(ErrorMessage = "Please select at least one option")]
        public Item SelectedItem;
        public List<Workplace> Workplaces { get; set; }
        [Required]
        public virtual List<Item> Items { get; set; }
    }

}