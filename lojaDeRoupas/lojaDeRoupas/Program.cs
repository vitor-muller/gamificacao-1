﻿using lojaDeRoupas.Interface;
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
            VendaUI vendaUI = new VendaUI();

            while (true)
            {
                Console.Clear();
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
                        categoriaUI.MenuCategoria();
                        break;
                    case 2:
                        clienteUI.MenuCliente();
                        break;
                    case 3:
                        vendaUI.MenuVenda(clienteUI.clientes,produtoUI.produtos);
                        break;
                    case 4:
                        produtoUI.MenuProduto(categoriaUI.categorias);
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