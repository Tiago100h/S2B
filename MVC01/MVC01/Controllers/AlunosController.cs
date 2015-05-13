using MVC01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC01.Controllers
{
    public class AlunosController : Controller
    {
        // GET: Alunos
        public ActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno("João", "Eng Mecânica", "FAESA"));
            alunos.Add(new Aluno("Maria", "Sistemas de Informação", "UFES"));
            alunos.Add(new Aluno("Joana", "Eng Produção", "FAESA"));
            alunos.Add(new Aluno("Pedro", "Direito", "FDV"));
            //atalho: ctrl + c, ctrl + v - copia linha
            //atalho: shift + del - deleta linha
            return View(alunos);
        }

        public ActionResult Detalhes()
        {
            var aluno = new Aluno("João", "Eng Mecânica", "FAESA");
            return View(aluno);
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Aluno model)
        {
            return RedirectToAction("Index");
        }
    }
}