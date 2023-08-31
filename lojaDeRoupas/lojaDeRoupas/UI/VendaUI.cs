using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.UI
{
    public class VendaUI
    {
        private ClienteUI clienteUI = new ClienteUI();
        private ProdutoUI produtoUI = new ProdutoUI();
        public Venda criarVenda(int id, List<Produto> produtos, List<Cliente> clientes) 
        {
            Cliente cliente = clienteUI.buscarCliente(clientes);//buscando o cliente na base de dados
            DateTime data = DateTime.Now;//pegando a data da venda
            decimal valorTotal = produtoUI.calcularPreco(produtos);//calculando o valor dos produtos
            Venda venda = new Venda(id, cliente, produtos, data, valorTotal);

            return venda;
        }

        public void imprimirVenda(Venda venda)
        {
            Console.WriteLine("ID: " + venda.Id);
            Console.WriteLine("Nome do Cliente: " + venda.Cliente.Nome + " " + venda.Cliente.Sobrenome);
            Console.WriteLine("Data: " + venda.DataVenda);
            Console.WriteLine("Items na lista: "+venda.Produtos.Count());
            produtoUI.imprimirTodosProdutos(venda.Produtos);
            Console.WriteLine("Preço Total: " + venda.ValorTotal);
            Console.WriteLine("-----------------------");
        }

        public void imprimirTodasVendas(List<Venda> vendas)
        {
            Console.WriteLine(">Lista de Vendas");
            Console.WriteLine("-----------------------");
            foreach (Venda venda in vendas)
            {
                imprimirVenda(venda);
            }
        }

        public List<Produto> adicionarItems(List<Produto> produtos)
        {
            List<Produto> carrinho = new List<Produto>();

            int controle = 1;
            while(controle != 0)
            {
                Console.Clear();
                produtoUI.imprimirTodosProdutos(produtos);
                Console.WriteLine("Entre o ID do produto que deseja adicionar(0 p/ sair): ");
                controle = int.Parse( Console.ReadLine() );
                if(controle > 0 && controle <= (produtos.Count))
                {
                    carrinho.Add( produtos[controle-1] );
                }
            }

            return carrinho;
        }
    }
}
