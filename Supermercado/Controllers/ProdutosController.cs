using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermercado.Models;

namespace Supermercado.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IEnumerable<Produto> todosOsProdutos;

        public ProdutosController()
        {
            todosOsProdutos = new Produto().TodosOsProdutos();
        }
        public ActionResult Index()
        {
            var maisComprados = todosOsProdutos.Take(3);
            var todasAsCategorias = todosOsProdutos.Select(x => x.Categoria).Distinct().ToList();
            ViewBag.Categorias = todasAsCategorias;

            return View(maisComprados);
        }

        public ActionResult TodosOsProdutos()
        {
            return View(todosOsProdutos);
        }

        public ActionResult MostraProduto(int codigo, string nome, string categoria)
        {
            return View(todosOsProdutos.FirstOrDefault(x => x.Codigo == codigo));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todosOsProdutos.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;
            return View(categoriaEspecifica);

        }
    }
}