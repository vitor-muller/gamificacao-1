using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Modelos
{
    internal class Venda
    {
        public int? Id { get; set; }
        public Cliente? Cliente { get; set; }
        public List<Produto>? Produtos { get; set; }
        public DateTime? DataVenda { get; set; }
        public decimal? ValorTotal { get; set; }
    }
}
