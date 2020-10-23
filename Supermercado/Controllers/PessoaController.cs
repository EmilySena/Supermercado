using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermercado.Models;

namespace Supermercado.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Cadastro()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }
        [HttpPost]
        public ActionResult Cadastro(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string Login)
        {
            var bancoDeNomesDeExemplo = new Collection<string>
            {
                "Annie",
                "Helen",
                "Emily"
            };
            return Json(bancoDeNomesDeExemplo.All(x => x.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}