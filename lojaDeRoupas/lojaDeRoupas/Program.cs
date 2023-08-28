using lojaDeRoupas.Modelos;


namespace lojaDeRoupas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Cliente cliente = new Cliente
            {
                Nome = "Bruno",
                Endereco = "Rua riachuelo",
                Sobrenome = "Gomes",
                Numerotelefone = "69999181330"
            };

            Console.WriteLine("Cliente " + cliente.Nome + " " + cliente.Sobrenome + " Cadastrado");
        }
    }
}