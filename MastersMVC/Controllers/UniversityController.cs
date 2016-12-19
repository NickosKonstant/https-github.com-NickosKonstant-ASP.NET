using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MastersMVC.Controllers
{
    public class UniversityController : Controller
    {
        // GET: University
        public ActionResult Index(string uni)
        {
            return View();
        }
    }
}