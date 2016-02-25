using SuperAwesomeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NumberName;

namespace SuperAwesomeApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Results(SuperAwesomeClass anything)
        {
            if (anything.Input != 0)
                anything.Result = NumberName.NumberName.GetNumberName(anything.Input);
            return View(anything);
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
