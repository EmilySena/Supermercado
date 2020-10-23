﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Supermercado
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Pessoa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Pessoa", action = "Cadastro", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Todos os Produtos",
                url: "produtos/",
                defaults: new { controller = "Produtos", action = "TodosOsProdutos" });
            routes.MapRoute(
                name: "Categoria Especifica",
                url: "produtos/{categoria}",
                defaults: new { controller = "Produtos", action = "MostraCategoria" });
            routes.MapRoute(
                name: "Mostra Produto",
                url: "noticias/{categoria}/{nome}-{codigo}",
                defaults: new { controller = "Produtos", action = "MostraProduto" });
            routes.MapRoute(
                name: "Produtos",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produtos", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
