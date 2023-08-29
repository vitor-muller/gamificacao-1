using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.UI
{
    public class ProdutoUI
    {
        private CategoriaUI catUI = new CategoriaUI();
        public Produto criarProduto(int id, List<Categoria> listaCategoria)
        {
            Console.WriteLine("Entre o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Entre o preco do produto: ");
            decimal preco = Convert.ToDecimal( Console.ReadLine() );

            Categoria cat = catUI.buscarCategoria(listaCategoria);

            Produto produto = new Produto(id, nome, descricao, preco, cat);

            return produto;
        }

        public decimal calcularPreco(List<Produto> produtos)
        {
            decimal valor = 0;

            foreach (Produto produto in produtos)
            {
                valor += produto.Preco;
            }

            return valor;
        }
    }
}
