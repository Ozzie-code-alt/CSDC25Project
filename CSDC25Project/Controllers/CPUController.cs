using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSDC25Project.Controllers
{
    public class CPUController : Controller
    {
        // GET: CPU
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Teacher_Dashboard()
        {
            return View();
        }
        public ActionResult Student_Dashboard()
        {
            return View();
        }

        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult FileMaintenance()
        {
            return View();
        }
    }
}