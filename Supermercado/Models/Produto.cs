using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Supermercado.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }


        public IEnumerable<Produto> TodosOsProdutos()
        {
            var retorno = new Collection<Produto>()
            {
                new Produto
                {
                    Codigo = 1,
                    Categoria = "Limpeza",
                    Nome = "Desinfetante",
                    Marca = "VEJA",
                    Preco ="R$5.00"
                },
                new Produto
                {
                    Codigo = 2,
                    Categoria = "Limpeza",
                    Nome = "Sabão em pó",
                    Marca = "OMO",
                    Preco = "R$18.99"
                },
                new Produto
                {
                    Codigo = 3,
                    Categoria = "Carne",
                    Nome = "Picanha",
                    Marca = "Seara",
                    Preco = "R$16.89"
                },
                new Produto
                {
                    Codigo = 4,
                    Categoria = "Carne",
                    Nome = "Peito de Frango",
                    Marca = "Sadia",
                    Preco = "R$9.99"
                },
                new Produto
                {
                    Codigo = 5,
                    Categoria = "Carne",
                    Nome = "Bacalhau",
                    Marca = "Frutos do Mar",
                    Preco = "R$50.00"
                },
                new Produto
                {
                    Codigo = 6,
                    Categoria = "Carne",
                    Nome = "Atum",
                    Marca = "Frutos do Mar",
                    Preco = "R$20.00"
                },
                new Produto
                {
                    Codigo = 7,
                    Categoria = "Frutas",
                    Nome = "Banana Prata",
                    Marca = "Produtos Orgânicos",
                    Preco = "R$3.99"
                },
                new Produto
                {
                    Codigo = 7,
                    Categoria = "Massas",
                    Nome = "Macarrão",
                    Marca = "Vilma",
                    Preco = "R$2.00"
                },
                new Produto
                {
                    Codigo = 8,
                    Categoria = "Massas",
                    Nome = "Lasanha",
                    Marca = "Galo",
                    Preco = "R$5.99"
                },
                new Produto
                {
                    Codigo = 9,
                    Categoria = "Frutas",
                    Nome = "Maçã",
                    Marca = "Produtos Orgânicos",
                    Preco = "R$8.00"
                },
                new Produto
                {
                    Codigo = 10,
                    Categoria = "Frutas",
                    Nome = "Uvas",
                    Marca = "Produtos Orgânicos",
                    Preco = "R$7.99"
                },
                new Produto
                {
                    Codigo = 11,
                    Categoria = "Frutas",
                    Nome = "Morango",
                    Marca = "Produtos Orgânicos",
                    Preco = "R$2.99"
                },
                new Produto
                {
                    Codigo = 12,
                    Categoria = "Hortaliças",
                    Nome = "Couve",
                    Marca = "Horta",
                    Preco = "R$1.00"
                },
                new Produto
                {
                    Codigo = 13,
                    Categoria = "Hortaliças",
                    Nome = "Espinafre",
                    Marca = "Horta",
                    Preco = "R$3.00"
                },
                new Produto
                {
                    Codigo = 14,
                    Categoria = "Hortaliças",
                    Nome = "Tomate",
                    Marca = "Horta",
                    Preco = "R$3.99"
                },
                new Produto
                {
                    Codigo = 15,
                    Categoria = "Padaria",
                    Nome = "Pão Francês",
                    Marca = "Panificadora",
                    Preco = "R$5.00"
                },
                new Produto
                {
                    Codigo = 16,
                    Categoria = "Padaria",
                    Nome = "Bolo",
                    Marca = "Panificadora",
                    Preco = "R$6.00"
                },
                new Produto
                {
                    Codigo = 16,
                    Categoria = "Padaria",
                    Nome = "Biscoito",
                    Marca = "Panificadora",
                    Preco = "R$2.50"
                },
                new Produto
                {
                    Codigo = 17,
                    Categoria = "Padaria",
                    Nome = "Broa de milho",
                    Marca = "Panificadora",
                    Preco = "R$1.49"
                },
                new Produto
                {
                    Codigo = 18,
                    Categoria = "Utilidades",
                    Nome = "Vassoura",
                    Marca = "Casa",
                    Preco = "R$9.49"
                },
                new Produto
                {
                    Codigo = 19,
                    Categoria = "Utilidades",
                    Nome = "Rodo",
                    Marca = "Casa",
                    Preco = "R$5.99"
                },
                new Produto
                {
                    Codigo = 20,
                    Categoria = "Utilidades",
                    Nome = "Pano de Chão",
                    Marca = "Casa",
                    Preco = "R$0.80"
                }
        };
            return retorno;
        }
    }
}