using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Interface
{
    internal class VendaUI
    { 
        private List<Venda> vendas = new List<Venda>();
        private int nextVendaId = 1;

        public void RegistrarVenda(List<Cliente> clientes, List<Produto> produtos)
        {
            Console.WriteLine("Selecione o ID do cliente que realizou a venda:");
            ListarClientes(clientes);
            int clienteId = int.Parse(Console.ReadLine());

            Cliente clienteSelecionado = clientes.Find(c => c.Id == clienteId);

            if (clienteSelecionado == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            List<Produto> produtosVenda = new List<Produto>();
            decimal? valorTotal = 0;

            Console.WriteLine("Adicione produtos à venda. Digite 0 para finalizar.");
            while (true)
            {
                Console.WriteLine("Informe o ID do produto a ser adicionado:");
                ListarProdutos(produtos);
                int produtoId = int.Parse(Console.ReadLine());

                if (produtoId == 0)
                    break;

                Produto produtoSelecionado = produtos.Find(p => p.Id == produtoId);

                if (produtoSelecionado == null)
                {
                    Console.WriteLine("Produto não encontrado.");
                    continue;
                }

                produtosVenda.Add(produtoSelecionado);
                valorTotal += produtoSelecionado.Preco;
            }

            Venda venda = new Venda
            {
                Id = nextVendaId++,
                Cliente = clienteSelecionado,
                Produtos = produtosVenda,
                DataVenda = DateTime.Now,
                ValorTotal = valorTotal
            };

            vendas.Add(venda);
            Console.WriteLine("Venda registrada com sucesso!");
        }

        public void ListarVendas()
        {
            Console.WriteLine("Listagem de Vendas:");
            foreach (var venda in vendas)
            {
                Console.WriteLine($"ID: {venda.Id}, Cliente: {venda.Cliente.Nome} {venda.Cliente.Sobrenome}, Data: {venda.DataVenda}, Valor Total: {venda.ValorTotal:C}");
            }
        }

        public void DetalhesVenda()
        {
            Console.WriteLine("Informe o ID da venda que deseja ver os detalhes:");
            int id = int.Parse(Console.ReadLine());

            Venda vendaEncontrada = vendas.Find(v => v.Id == id);

            if (vendaEncontrada != null)
            {
                Console.WriteLine($"Detalhes da Venda ID {vendaEncontrada.Id}:");
                Console.WriteLine($"Cliente: {vendaEncontrada.Cliente.Nome} {vendaEncontrada.Cliente.Sobrenome}");
                Console.WriteLine("Produtos:");
                foreach (var produto in vendaEncontrada.Produtos)
                {
                    Console.WriteLine($"- {produto.Nome}, Preço: {produto.Preco:C}");
                }
                Console.WriteLine($"Data da Venda: {vendaEncontrada.DataVenda}");
                Console.WriteLine($"Valor Total: {vendaEncontrada.ValorTotal:C}");
            }
            else
            {
                Console.WriteLine("Venda não encontrada.");
            }
        }

        public void MenuVenda(List<Cliente> clientes, List<Produto> produtos)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Vendas:");
                Console.WriteLine("1. Registrar Venda");
                Console.WriteLine("2. Listar Vendas");
                Console.WriteLine("3. Ver Detalhes de uma Venda");
                Console.WriteLine("0. Voltar");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarVenda(clientes, produtos);
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        ListarVendas();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        DetalhesVenda();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }

        private void ListarClientes(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome} {cliente.Sobrenome}");
            }
        }

        private void ListarProdutos(List<Produto> produtos)
        {
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.Id}, Nome: {produto.Nome}, Preço: {produto.Preco:C}");
            }
            Console.WriteLine("0. Finalizar Venda");
        }
    }

}

