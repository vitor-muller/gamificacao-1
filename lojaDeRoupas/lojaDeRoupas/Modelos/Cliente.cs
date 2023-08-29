using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Modelos
{
    public class Cliente
    {
        private string? nome;
        private string? sobrenome;
        private string? endereco;
        private string? telefone;

        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string? Sobrenome 
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string? Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string? Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Cliente(string nome, string sobrenome, string endereco, string telefone)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Endereco = endereco;
            this.Telefone = telefone;
        }
    }
}
