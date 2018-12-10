using ETradeSite.Business.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETradeSite.Solution.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ProductManager productManager = new ProductManager();
            productManager.List();
            return View();
        }
    }
}