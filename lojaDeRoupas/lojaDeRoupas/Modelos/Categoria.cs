using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Modelos
{
    public class Categoria
    {
        private string? nome;
        private string? descricao;

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string? Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Categoria(string nome  = "Unknown", string descricao = "Descrição aqui") {
            this.nome = nome;
            this.descricao = descricao;
        }
    }
}
