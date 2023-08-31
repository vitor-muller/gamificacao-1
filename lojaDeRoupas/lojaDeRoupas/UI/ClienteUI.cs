using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.UI
{
    public class ClienteUI
    {
        public Cliente criarCliente()
        {
            Console.WriteLine("\n>>>>>>Adicionando um Cliente<<<<<<");
            Console.WriteLine("Entre o nome do Cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre o sobrenome do Cliente: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Entre o endereço do Cliente: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Entre o telefone do Cliente: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, sobrenome, endereco, telefone);

            return cliente;
        }

        public Cliente buscarCliente(List<Cliente> listaCliente)
        {
            Console.WriteLine("Entre o nome do Cliente: ");
            string nomeBuscado = Console.ReadLine();
            // Buscando o cliente
            foreach (Cliente cliente in listaCliente)
            {
                if (cliente.Nome == nomeBuscado)
                {
                    return cliente; // Retorna o cliente se ele foi encontrado
                }
            }

            return null;
        }

        public void imprimirCliente(Cliente cliente)
        {
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("Sobrenome: " + cliente.Sobrenome);
            Console.WriteLine("Endereco: " + cliente.Endereco);
            Console.WriteLine("Telefone: " + cliente.Telefone);
            Console.WriteLine("-----------------------");
        }

        public void imprimirTodosClientes(List<Cliente> clientes)
        {
            Console.WriteLine(">Lista de Clientes");
            Console.WriteLine("-----------------------");
            foreach (Cliente cliente in clientes)
            {
                imprimirCliente(cliente);
            }
        }
    }
}
