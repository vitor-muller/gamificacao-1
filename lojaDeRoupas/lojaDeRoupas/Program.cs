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
            //listaCategoria.Add(catUI.criarCategoria());//adicionando uma categoria a lista

            ClienteUI clienteUI = new ClienteUI();
            List<Cliente> listaCliente = new List<Cliente>();
            //listaCliente.Add(clienteUI.criarCliente());

            ProdutoUI prodUI = new ProdutoUI();
            List<Produto> listaProduto = new List<Produto>();
            //listaProduto.Add(prodUI.criarProduto(listaProduto.Count, listaCategoria));

            VendaUI vendaUI = new VendaUI();
            List<Venda> listaVenda = new List<Venda>();
            //listaVenda.Add(vendaUI.criarVenda(listaVenda.Count, listaProduto, listaCliente));

            int controle = 1;
            while (controle != 0)
            {
                Console.Clear();
                Console.WriteLine("Sistema Loja de Roupas");
                Console.WriteLine("Insira a operação que você deseja realizar: ");
                Console.WriteLine("1 - Adicionar uma categoria");
                Console.WriteLine("2 - Adicionar um cliente");
                Console.WriteLine("3 - Adicionar um produto");
                Console.WriteLine("4 - Adicionar uma venda");
                Console.WriteLine("5 - Imprimir");
                Console.WriteLine("0 - Sair");
                controle = Convert.ToInt16( Console.ReadLine() );
                Console.Clear();

                switch (controle)
                {
                    case 0:
                        break;

                    case 1:
                        listaCategoria.Add(catUI.criarCategoria());
                        break;

                    case 2:
                        listaCliente.Add(clienteUI.criarCliente());
                        break;

                    case 3:
                        listaProduto.Add(prodUI.criarProduto(listaProduto.Count, listaCategoria));
                        break;

                    case 4:
                        listaVenda.Add(vendaUI.criarVenda(listaVenda.Count, listaProduto, listaCliente));
                        break;

                    case 5:
                        catUI.imprimirCategoria(listaCategoria[0]);

                        prodUI.imprimirTodosProdutos(listaProduto);

                        clienteUI.imprimirCliente(listaCliente[0]);

                        //vendaUI.imprimirVenda(listaVenda[0]);
                        Console.WriteLine("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        Console.WriteLine("Pressione qualquer tecla para continuar");
                        Console.ReadKey();
                        break;
                }

            }

        }
    }
}