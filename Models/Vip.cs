using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coffeeshop.Models
{
    public class Vip
    {
        [Key]
        [Required]
        [RegularExpression("^[0-9]${9}", ErrorMessage = "ID must contain 9 digits")]
        public int vipId { get; set; }
        public int vipCount { get; set; }
        [Required]
        public string vipName { get; set; }
    }
}