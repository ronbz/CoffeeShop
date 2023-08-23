using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace coffeeshop.Models
{
    public class User
    {
        [Required]
        [Key]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}