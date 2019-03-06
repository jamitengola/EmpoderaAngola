using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Empodera.Controllers
{
    public class EmpoderaController : Controller
    {
        // GET: Empodera
        public ActionResult Agricultura()
        {
            return View();
        }
        public ActionResult Agroindustria()
        {
            return View();
        }
        public ActionResult Tecnologia()
        {
            return View();
        }
        public ActionResult Turismo()
        {
            return View();
        }
    }
}