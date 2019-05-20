using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Models {
    public class CartViewModel
    {
        public List<ProductViewModel> Cart { get; set; }
        public ProductViewModel AddedProduct { get; set; }
    }
}