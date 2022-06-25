using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLab4.Models;

namespace MVCLab4.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var model = new Class1();
            model.Imie = "Daniel";
            model.Nazwisko = "Szypniewski";
            return View(model);
        }
    }
}