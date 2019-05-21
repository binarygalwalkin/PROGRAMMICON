using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Models {
    public class OrderViewModel
    {
        public SelectList ProductsList { get; set; }
        public ProductViewModel SelectedProduct { get; set; }
    }
}