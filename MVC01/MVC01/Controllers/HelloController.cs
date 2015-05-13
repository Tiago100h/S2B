using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Mensagem(int id, string nome)
        {
            ViewBag.id = id;
            ViewBag.Nome = nome;
            return View();
        }

        //atalho mcva - criar ActionResult
        //atalho ctrl + m , ctrl + g - ir para a view
        [HttpPost]
        public ActionResult RepeteNome(int vezes, string nome)
        {
            ViewBag.Vezes = vezes;
            ViewBag.Nome = nome;
            return View();
        }
    }
}