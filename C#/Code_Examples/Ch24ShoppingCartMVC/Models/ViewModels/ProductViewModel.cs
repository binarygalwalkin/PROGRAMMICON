using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ch24ShoppingCartMVC.Models {
    public class ProductViewModel
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; } 
        public decimal UnitPrice { get; set; }
        public string ImageFile { get; set; }
        public int Quantity { get; set; }

        //display item's property values
        public string Display()
        {
            string display = string.Format("{0} ({1} at {2} each)",
                Name, Quantity.ToString(), UnitPrice.ToString("c"));
            return display;
        }
    }
}