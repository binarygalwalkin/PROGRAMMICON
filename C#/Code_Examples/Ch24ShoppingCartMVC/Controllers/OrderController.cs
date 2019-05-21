using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;

namespace Ch24ShoppingCartMVC.Controllers {
    public class OrderController : Controller
    {
        private OrderModel order = new OrderModel();

        [HttpGet]
        public ActionResult Index(string id) {
            //get list for drop down from temp data or order
            SelectList products = (SelectList)TempData["products"];
            if (products == null) {
                var list = order.GetProductsList();
                products = new SelectList(list, "ProductId", "Name", id);
            } 
            //if no URL parameter, get first product from list and refresh
            if (string.IsNullOrEmpty(id)) {
                id = products.ElementAt(0).Value;
                TempData["products"] = products;
                return RedirectToAction("Index", "Order", new { id });
            }
            else { //get selected product and return in view method
                OrderViewModel model = order.GetOrderInfo(id);
                model.ProductsList = products;
                model.SelectedProduct.Quantity = 1;
                return View(model);
            }
        }
        [HttpPost] //post back - get selected ddl value and refresh
        public RedirectToRouteResult Index(FormCollection collection)
        {
            string pID = collection["ddlProducts"];
            return RedirectToAction("Index", "Order", new { id = pID });
        }      
    }
}
