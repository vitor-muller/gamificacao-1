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
    }
}
