using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using coffeeshop.Models;


namespace coffeeshop.ModelView
{
    public class MenuViewModel
    {
        public Item item { get; set; }
        public List<Item> items { get; set; }
        public Vip vip { get; set; }
        public List<Vip> vips { get; set; }
    }
}