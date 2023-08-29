using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.UI
{
    internal class ClienteUI
    {
        public Cliente criarProduto()
        {
            Console.WriteLine("Entre o nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre o nome do Cliente: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Entre o endereço do Cliente: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Entre o telefone do Cliente: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, sobrenome, endereco, telefone);

            return cliente;
        }
    }
}
