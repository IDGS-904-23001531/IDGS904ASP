using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904ASP.Models;

namespace IDGS904ASP.Controllers
{
    public class CinepolisController : Controller
    {
        // GET: Cinepolis
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Cinepolis cine)
        {
            double precioBoleto = 12;
            double subtotal = cine.CantidadBoletos * precioBoleto;
            double total = subtotal;

            if(cine.CantidadBoletos > 5)
            {
                total = subtotal - (subtotal * 0.15);
            }
            else if (cine.CantidadBoletos >= 3 && cine.CantidadBoletos <= 5)
            {
                total = subtotal - (subtotal * 0.10);
            }

            if (cine.Tarjeta)
            {
                total = total - (total * 0.10);
            }

            cine.TotalPagar = total;
            return View(cine);
        }
    }
}