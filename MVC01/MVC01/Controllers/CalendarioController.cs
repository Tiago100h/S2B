using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class CalendarioController : Controller
    {
        // GET: Calendario
        [HttpPost]
        public ActionResult QuantidadeDiasMes(int mes, int ano)
        {
            ViewBag.Mes = mes;
            ViewBag.Ano = ano;

            return View();
            
        }
    }
}