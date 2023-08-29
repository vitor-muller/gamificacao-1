using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Modelos
{
    public class Produto
    {
        private int? id;
        private string? nome;
        private string? descricao;
        private decimal? preco;
        public Categoria? categoria;

        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
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
        public decimal? Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Produto(int id, string nome, string descricao, decimal preco, Categoria cat)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
            this.preco = preco;
            this.categoria = cat;
        }
    }
}
