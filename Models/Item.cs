using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coffeeshop.Models
{
    public class Item
    {
        [Required]
        [Key]
        [RegularExpression("^[0-9]$",ErrorMessage ="Item code can contain numbers only")]
        public int itemCode { get; set; }
        [Required]
        public string itemName { get; set; }
       
        public string itemDesc { get; set; }
        [Required]
        public double itemPrice { get; set; }
        public double itemDiscount { get; set; }
        public bool itemAvailable { get; set; }
        public bool itemAge { get; set; }
        public string itemImg { get; set; }
        public int itemCount { get; set; }
    }
}