using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VShop.Models;
using PagedList;

namespace VShop.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        VShopEnities storeDB = new VShopEnities();
        public ActionResult ProductSearch()
        {
            return PartialView();
        }
        public ViewResult Index(string currentFilter, string searchString, int? page)
        {
            //ViewBag.CurrentSort = sortOrder;
            //ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            ViewBag.ShowSearch = true;

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var products = from p in storeDB.Products
                           select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.ProductName.Contains(searchString)).OrderBy(p => p.ProductName);
            }
            products = products.OrderByDescending(a => a.OrderDetails.Count());
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(products.ToPagedList(pageNumber, pageSize));
        }
        [ChildActionOnly]
        public ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();
            return PartialView(categories);
        }
       
        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);
            return View(product);
        }
        public ActionResult Browse(int id)
        {
            var categoryModel = storeDB.Categories.Include("Products").Single(c => c.CategoryId == id);
            return View(categoryModel);
        }
    }
}