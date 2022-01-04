using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        PM_BanLinhKienPCEntities _db = new PM_BanLinhKienPCEntities();
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Customer cus)
        {
            _db.Customers.Add(cus);
            _db.SaveChanges();
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
    }
}