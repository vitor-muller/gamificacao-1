using lojaDeRoupas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaDeRoupas.Interface
{
    internal class ClienteUI
    {
        private List<Cliente> clientes = new List<Cliente>();
        private int nextClienteId = 1;

        private void RegistrarCliente()
        {
            Console.WriteLine("Informe o nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o sobrenome do cliente:");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Informe o endereço do cliente:");
            string endereco = Console.ReadLine();
            Console.WriteLine("Informe o número de telefone do cliente:");
            string numeroTelefone = Console.ReadLine();

            Cliente cliente = new Cliente
            {
                Id = nextClienteId++,
                Nome = nome,
                Sobrenome = sobrenome,
                Endereco = endereco,
                NumeroTelefone = numeroTelefone
            };

            clientes.Add(cliente);
            Console.WriteLine("Cliente registrado com sucesso!");
        }

        private void ListarClientes()
        {
            Console.WriteLine("Listagem de Clientes:");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome} {cliente.Sobrenome}, Endereço: {cliente.Endereco}, Telefone: {cliente.NumeroTelefone}");
            }
        }

        private void BuscarClientePorId()
        {
            Console.WriteLine("Informe o ID do cliente que deseja buscar:");
            int id = int.Parse(Console.ReadLine());

            Cliente clienteEncontrado = clientes.Find(c => c.Id == id);

            if (clienteEncontrado != null)
            {
                Console.WriteLine($"ID: {clienteEncontrado.Id}, Nome: {clienteEncontrado.Nome} {clienteEncontrado.Sobrenome}, Endereço: {clienteEncontrado.Endereco}, Telefone: {clienteEncontrado.NumeroTelefone}");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        private void RemoverCliente()
        {
            Console.WriteLine("Informe o ID do cliente que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Cliente clienteParaRemover = clientes.Find(c => c.Id == id);

            if (clienteParaRemover != null)
            {
                clientes.Remove(clienteParaRemover);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public void MenuCliente()
        {
            while (true)
            {
                Console.WriteLine("Menu de Clientes:");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Buscar Cliente por ID");
                Console.WriteLine("4. Remover Cliente");
                Console.WriteLine("0. Voltar");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarCliente();
                        break;
                    case 2:
                        ListarClientes();
                        break;
                    case 3:
                        BuscarClientePorId();
                        break;
                    case 4:
                        RemoverCliente();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
