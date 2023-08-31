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

            ClienteUI clienteUI = new ClienteUI();
            List<Cliente> listaCliente = new List<Cliente>();

            ProdutoUI prodUI = new ProdutoUI();
            List<Produto> listaProduto = new List<Produto>();

            VendaUI vendaUI = new VendaUI();
            List<Venda> listaVenda = new List<Venda>();
            List<Produto> carrinho = new List<Produto>();

            int controle = 1;
            int controleImprimir;
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
                controle = Convert.ToInt32( Console.ReadLine() );
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
                        carrinho = vendaUI.adicionarItems(listaProduto);
                        listaVenda.Add(vendaUI.criarVenda(listaVenda.Count, carrinho, listaCliente));
                        //carrinho.Clear();
                        break;

                    case 5:
                        controleImprimir = 1;
                        while (controleImprimir != 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Sistema Loja de Roupas");
                            Console.WriteLine("Insira o que você deseja imprimir: ");
                            Console.WriteLine("1 - Imprimir categorias");
                            Console.WriteLine("2 - Imprimir produtos");
                            Console.WriteLine("3 - Imprimir clientes");
                            Console.WriteLine("4 - Imprimir vendas");
                            Console.WriteLine("0 - Sair");
                            controleImprimir = Convert.ToInt16(Console.ReadLine());
                            Console.Clear();

                            switch (controleImprimir)
                            {
                                case 0:
                                    break;
                                case 1:
                                    catUI.imprimirTodasCategorias(listaCategoria);
                                    break;
                                case 2:
                                    prodUI.imprimirTodosProdutos(listaProduto);
                                    break;
                                case 3:
                                    clienteUI.imprimirTodosClientes(listaCliente);
                                    break;
                                case 4:
                                    vendaUI.imprimirTodasVendas(listaVenda);
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida!");
                                    break;
                            }
                            if(controleImprimir != 0)
                            {
                                Console.WriteLine("\nPressione qualquer tecla para continuar");
                                Console.ReadKey();
                            }
                        }
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