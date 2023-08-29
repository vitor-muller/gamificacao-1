using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lojaDeRoupas.Modelos;

namespace lojaDeRoupas.UI
{
    public class CategoriaUI
    {
        public Categoria criarCategoria()
        {
            Console.WriteLine("Entre o nome da Categoria: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Entre a descrição da Categoria: ");
            string desc = Console.ReadLine();

            Categoria categoria = new Categoria(nome, desc);

            return categoria;
        }

        public Categoria buscarCategoria(List<Categoria> listaCategoria)
        {
            Console.WriteLine("Entre o nome da Categoria do produto: ");
            string nomeBuscado = Console.ReadLine();
            // Buscando a categoria
            foreach (Categoria categoria in listaCategoria)
            {
                if (categoria.Nome == nomeBuscado)
                {
                    return categoria; // Retorna a categoria encontrada
                }
            }

            return null;
        }
    }
}
