using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ch24ShoppingCartMVC.Models;
using Ch24ShoppingCartMVC.Models.DataAccess;

namespace Ch24ShoppingCartMVC.Models {
    public class OrderModel
    {
        private List<ProductViewModel> products;
        public List<ProductViewModel> GetProductsList() {
            if (this.products == null)
                this.products = GetAllProducts();
            return this.products;
        }
        public OrderViewModel GetOrderInfo(string id) {
            OrderViewModel order = new OrderViewModel();
            order.SelectedProduct = GetSelectedProduct(id);
            return order;
        }        
        public ProductViewModel GetSelectedProduct(string id) {
            if (this.products == null)
                return ConvertToViewModel(GetProductByIdFromDataStore(id));
            else
                return this.products.Where(p => p.ProductID == id).FirstOrDefault();
        }
        public List<ProductViewModel> GetAllProducts() {
            List<ProductViewModel> productmodels = new List<ProductViewModel>();
            List<Product> products = GetAllProductsFromDataStore();
            foreach (Product p in products) {
                productmodels.Add(ConvertToViewModel(p));
            }
            return productmodels;
        }
        private ProductViewModel ConvertToViewModel(Product product) {
            ProductViewModel model = new ProductViewModel();
            model.ProductID = product.ProductID;
            model.Name = product.Name;
            model.ShortDescription = product.ShortDescription;
            model.LongDescription = product.LongDescription;
            model.UnitPrice = product.UnitPrice;
            model.ImageFile = product.ImageFile;
            return model;
        }
        //Data Access methods 
        public Product GetProductByIdFromDataStore(string id) {
            using (HalloweenEntities1 data = new HalloweenEntities1()) {
                return data.Products.Where(p => p.ProductID == id).FirstOrDefault();
            }
        }
        public List<Product> GetAllProductsFromDataStore() {
            using (HalloweenEntities1 data = new HalloweenEntities1()) {
                return data.Products.OrderBy(p => p.Name).ToList();
            }
        }
    }
}