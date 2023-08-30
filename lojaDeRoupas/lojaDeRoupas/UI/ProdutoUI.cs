using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Interface
{
    internal class ProdutoUI
    {
        public List<Produto> produtos = new List<Produto>();
        private int nextProdutoId = 1;

        public void RegistrarProduto(List<Categoria> categorias)
        {
            Console.WriteLine("Informe o nome do produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a descrição do produto:");
            string descricao = Console.ReadLine();
            Console.WriteLine("Informe o preço do produto:");
            decimal preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a categoria do produto:");
            ListarCategorias(categorias);
            int categoriaId = int.Parse(Console.ReadLine());

            Categoria categoriaSelecionada = categorias.Find(c => c.Id == categoriaId);

            if (categoriaSelecionada != null)
            {
                Produto produto = new Produto
                {
                    Id = nextProdutoId++,
                    Nome = nome,
                    Descricao = descricao,
                    Preco = preco,
                    Categoria = categoriaSelecionada
                };

                produtos.Add(produto);
                Console.WriteLine("Produto registrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

        private void ListarProdutos()
        {
            Console.WriteLine("Listagem de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}, Categoria: {produto.Categoria.Nome}");
            }
        }

        private void BuscarProdutoPorId()
        {
            Console.WriteLine("Informe o ID do produto que deseja buscar:");
            int id = int.Parse(Console.ReadLine());

            Produto produtoEncontrado = produtos.Find(p => p.Id == id);

            if (produtoEncontrado != null)
            {
                Console.WriteLine($"ID: {produtoEncontrado.Id}, Nome: {produtoEncontrado.Nome}, Preço: {produtoEncontrado.Preco:C}, Categoria: {produtoEncontrado.Categoria.Nome}");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        private void RemoverProduto()
        {
            Console.WriteLine("Informe o ID do produto que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Produto produtoParaRemover = produtos.Find(p => p.Id == id);

            if (produtoParaRemover != null)
            {
                produtos.Remove(produtoParaRemover);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        private void ListarCategorias(List<Categoria> categorias)
        {
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}");
            }
        }

        public void MenuProduto(List<Categoria> categorias)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Produtos:");
                Console.WriteLine("1. Registrar Produto");
                Console.WriteLine("2. Listar Produtos");
                Console.WriteLine("3. Buscar Produto por ID");
                Console.WriteLine("4. Remover Produto");
                Console.WriteLine("0. Voltar");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarProduto(categorias);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        ListarProdutos();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        BuscarProdutoPorId();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        ListarProdutos();
                        RemoverProduto();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
