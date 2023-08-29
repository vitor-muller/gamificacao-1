using lojaDeRoupas.Modelos;
using lojaDeRoupas.UI;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lojaDeRoupas
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoriaUI catUI = new CategoriaUI();
            List<Categoria> listaCategoria = new List<Categoria>();
            listaCategoria.Add(catUI.criarCategoria());

            ProdutoUI prodUI = new ProdutoUI();
            List<Produto> listaProduto = new List<Produto>();
            listaProduto.Add(prodUI.criarProduto(listaProduto.Count, listaCategoria));

            Console.WriteLine(">Categoria");
            Console.WriteLine("Nome: " + listaCategoria[0].Nome);
            Console.WriteLine("Descrição: "+ listaCategoria[0].Descricao);

            Console.WriteLine(">Produto");
            Console.WriteLine("Nome: " + listaProduto[0].Nome);
            Console.WriteLine("Descrição: " + listaProduto[0].Descricao);
            Console.WriteLine("Categoria: " + listaProduto[0].Categoria.Nome);
        }
    }
}