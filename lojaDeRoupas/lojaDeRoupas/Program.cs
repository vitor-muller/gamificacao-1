using lojaDeRoupas.Interface;
using lojaDeRoupas.Modelos;


namespace lojaDeRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriaUI categoriaUI = new CategoriaUI();
            while (true)
            {
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1. Gerenciar Categoria");
                Console.WriteLine("2. Ver Categoria");
                Console.WriteLine("3. Gerenciar Clientes");
                Console.WriteLine("4. Gerenciar Vendas");
                Console.WriteLine("0. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        categoriaUI.MenuCategoria();
                        break;
                    /*case 2:
                        categoriaUI.ListarCategorias();
                        break;
                    case 2:
                        produtoUI.MenuProduto();
                        break;
                    case 3:
                        clienteUI.MenuCliente();
                        break;
                    case 4:
                        vendaUI.MenuVenda();
                        break;*/
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}