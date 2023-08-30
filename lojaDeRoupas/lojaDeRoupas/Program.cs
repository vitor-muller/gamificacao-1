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
            CategoriaUI catUI = new CategoriaUI();//instanciando a UI
            List<Categoria> listaCategoria = new List<Categoria>();//Criando uma lista de Categorias
            listaCategoria.Add(catUI.criarCategoria());//adicionando uma categoria a lista

            ClienteUI clienteUI = new ClienteUI();
            List<Cliente> listaCliente = new List<Cliente>();
            listaCliente.Add(clienteUI.criarCliente());

            ProdutoUI prodUI = new ProdutoUI();
            List<Produto> listaProduto = new List<Produto>();
            listaProduto.Add(prodUI.criarProduto(listaProduto.Count, listaCategoria));

            VendaUI vendaUI = new VendaUI();
            List<Venda> listaVenda = new List<Venda>();
            listaVenda.Add(vendaUI.criarVenda(listaVenda.Count, listaProduto, listaCliente));

            //imprimindo
            Console.Clear();
            catUI.imprimirCategoria(listaCategoria[0]);

            prodUI.imprimirTodosProdutos(listaProduto);

            clienteUI.imprimirCliente(listaCliente[0]);
        }
    }
}