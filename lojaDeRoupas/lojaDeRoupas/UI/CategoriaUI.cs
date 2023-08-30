using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lojaDeRoupas.Modelos;

namespace lojaDeRoupas.Interface
{


    class CategoriaUI
    {
        public List<Categoria> categorias = new List<Categoria>();
        private int nextCategoryId = 1;

        public void MenuCategoria()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu de Categorias:");
                Console.WriteLine("1. Registrar Categoria");
                Console.WriteLine("2. Listar Categorias");
                Console.WriteLine("3. Remover Categoria");
                Console.WriteLine("4. Buscar Categoria por Id");
                Console.WriteLine("0. Voltar");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        RegistrarCategoria();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        ListarCategorias();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        ListarCategorias();
                        RemoverCategoria();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        BuscarCategoriaPorId();
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void RegistrarCategoria()
        {
            Console.WriteLine("Informe o nome da categoria:");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a descrição da categoria:");
            string descricao = Console.ReadLine();

            Categoria categoria = new Categoria
            {
                Id = nextCategoryId++,
                Nome = nome,
                Descricao = descricao
            };

            categorias.Add(categoria);
            Console.WriteLine("Categoria registrada com sucesso!");
        }

        private void ListarCategorias()
        {
            Console.WriteLine("Listagem de Categorias:");
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Nome}, Descrição: {categoria.Descricao}");
            }
        }

        private void RemoverCategoria()
        {
            Console.WriteLine("Informe o ID da categoria que deseja remover:");
            int id = int.Parse(Console.ReadLine());

            Categoria categoriaParaRemover = categorias.Find(c => c.Id == id);

            if (categoriaParaRemover != null)
            {
                categorias.Remove(categoriaParaRemover);
                Console.WriteLine("Categoria removida com sucesso!");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

        private void BuscarCategoriaPorId()
        {
            Console.WriteLine("Informe o ID da categoria que deseja buscar:");
            int id = int.Parse(Console.ReadLine());
            Categoria categoriaParaBusca = categorias.Find(c => c.Id == id);
            if (categoriaParaBusca != null)
            {
                Console.WriteLine($"ID: {categoriaParaBusca.Id}, Nome: {categoriaParaBusca.Nome}, Descrição: {categoriaParaBusca.Descricao}");
            }
            else
            {
                Console.WriteLine("Categoria não encontrada.");
            }
        }

       
    }
}
