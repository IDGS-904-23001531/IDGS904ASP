using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        ////redirigir
        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com.mx");
        //}

        
        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }

        //public JsonResult Index()
        //{
        //    var alumno1 = new Persona() { Nombre = "Juan", Edad = 32, Empleado = true };
        //    var alumno2 = new Persona() { Nombre = "Mario", Edad = 23, Empleado = false };
        //    return Json(new List<Persona>() { alumno1, alumno2}, JsonRequestBehavior.AllowGet);
        //    // return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}