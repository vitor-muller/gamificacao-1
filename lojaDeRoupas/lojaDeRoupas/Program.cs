using lojaDeRoupas.Interface;
using lojaDeRoupas.Modelos;


namespace lojaDeRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CategoriaUI categoriaUI = new CategoriaUI();
            ClienteUI clienteUI = new ClienteUI();
            ProdutoUI produtoUI = new ProdutoUI();
            List<Categoria> categorias = new List<Categoria>();
            while (true)
            {
                Console.WriteLine("Menu Principal:");
                Console.WriteLine("1. Gerenciar Categoria");
                Console.WriteLine("2. Gerenciar Clientes");
                Console.WriteLine("3. Gerenciar Vendas");
                Console.WriteLine("4. Gerenciar Produtos");
                Console.WriteLine("0. Sair");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        categoriaUI.MenuCategoria(categorias);
                        break;
                    case 2:
                        clienteUI.MenuCliente();
                        break;
                    case 3:
                        //clienteUI.MenuVendas();
                        break;
                    case 4:
                        produtoUI.MenuProduto(categorias);
                        break;
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