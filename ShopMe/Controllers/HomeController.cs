using ShopMe.BusinessLayer;
using ShopMe.BusinessLayer.Implementation;
using ShopMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            ProductDetails productDetails = new ProductDetails();
            ProductsViewModel productsViewModel = new ProductsViewModel();
            productsViewModel.Products = productDetails.GetProducts();

            return View(productsViewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}