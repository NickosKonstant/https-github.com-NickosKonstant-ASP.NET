using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MastersMVC.Models;

namespace MastersMVC.Controllers
{
    public class CoursesController : Controller
    {
        private MastersDBContext db = new MastersDBContext();

        // GET: Courses
        public ActionResult Index()
        {
            return View(db.Courses.ToList());
        }

        public ActionResult Category(string id)
        {
            string searchString = id;
            var courses = from m in db.Courses
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                courses = courses.Where(s => s.Category == id );
            }

            return View(courses);
            //return View(db.Courses.ToList());
        }
        public ActionResult University(int id)
        {
            
            var courses = from m in db.Courses
                          select m;

                courses = courses.Where(s => s.University.ID == id);
            

            return View(courses);
            //return View(db.Courses.ToList());
        }

    }
}
