﻿using ShopMe.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMe.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddToCart(Product product)
        {
            List<Product> products = (List<Product>) Session["CartItems"];

            if(products == null)
            {
                products = new List<Product>();
            }

            products.Add(product);
            Session["CartItems"] = products;
            return PartialView("~/Views/Home/_ProductSuccessModal.cshtml",product);
        }
    }
}