using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShop.Models;

namespace VShop.Controllers
{
    public class HomeController : Controller
    {
        VShopEnities storeDB = new VShopEnities();
        private List<Product> GetTopSellingProducts(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.Products
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

        public ActionResult Index()
        {
            // Get most popular albums
            var products = GetTopSellingProducts(5);
            return View(products);
        }
        public ActionResult About()
        {
             return View();
        }

        public ActionResult Contact()
        {
           return View();
        }

    }
}