using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904ASP.Models;

namespace IDGS904ASP.Controllers
{
    public class ResistenciaController : Controller
    {
        // GET: Resistencia
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // POST: Resistencia
        [HttpPost]
        public ActionResult Index(Resistencia r)
        {
            int banda1 = 0;
            int banda2 = 0;
            int multiplicador = 1;

            //Primera banda
            switch (r.Color1)
            {
                case "Negro":
                    banda1 = 0;
                    break;
                case "Cafe":
                    banda1 = 1;
                    break;
                case "Rojo":
                    banda1 = 2;
                    break;
                case "Naranja":
                    banda1 = 3;
                    break;
                case "Amarillo":
                    banda1 = 4;
                    break;
                case "Verde":
                    banda1 = 5;
                    break;
                case "Azul":
                    banda1 = 6;
                    break;
                case "Violeta":
                    banda1 = 7;
                    break;
                case "Gris":
                    banda1 = 8;
                    break;
                case "Blanco":
                    banda1 = 9;
                    break;
            }

            //Segunda banda
            switch (r.Color2)
            {
                case "Negro":
                    banda2 = 0;
                    break;
                case "Cafe":
                    banda2 = 1;
                    break;
                case "Rojo":
                    banda2 = 2;
                    break;
                case "Naranja":
                    banda2 = 3;
                    break;
                case "Amarillo":
                    banda2 = 4;
                    break;
                case "Verde":
                    banda2 = 5;
                    break;
                case "Azul":
                    banda2 = 6;
                    break;
                case "Violeta":
                    banda2 = 7;
                    break;
                case "Gris":
                    banda2 = 8;
                    break;
                case "Blanco":
                    banda2 = 9;
                    break;
            }

            //Tercera banda
            switch (r.Color3)
            {
                case "Negro":
                    multiplicador = 1;
                    break;
                case "Cafe":
                    multiplicador = 10;
                    break;
                case "Rojo":
                    multiplicador = 100;
                    break;
                case "Naranja":
                    multiplicador = 1000;
                    break;
                case "Amarillo":
                    multiplicador = 10000;
                    break;
                case "Verde":
                    multiplicador = 100000;
                    break;
                case "Azul":
                    multiplicador = 1000000;
                    break;
                case "Violeta":
                    multiplicador = 10000000;
                    break;
                case "Gris":
                    multiplicador = 100000000;
                    break;
                case "Blanco":
                    multiplicador = 1000000000;
                    break;
            }

            // Calcular valor
            double valor = ((banda1 * 10) + banda2) * multiplicador;
            double porcentaje = 0;

            //Tolerancia
            if(r.Tolerancia == "Oro")
            {
                porcentaje = 0.05;
            }
            else
            {
                porcentaje = 0.10;
            }

            double minimo= valor - (valor * porcentaje);
            double maximo = valor + (valor * porcentaje);

            r.Valor = valor;
            r.ValorMin = minimo;
            r.ValorMax = maximo;

            return View(r);
        }
    }
}