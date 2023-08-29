using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Modelos
{
    public class Venda
    {
        private int? id;
        private Cliente? cliente;
        private List<Produto>? produtos;
        private DateTime? dataVenda;
        private decimal? valorTotal;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        public Cliente? Cliente { 
            get {  return cliente; } 
            set {  cliente = value; } 
        }
        public List<Produto>? Produtos
        {
            get { return produtos; }
            set { produtos = value; }
        }
        public DateTime? DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }
        public decimal? ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

    }
}
