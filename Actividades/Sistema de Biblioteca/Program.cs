using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Biblioteca
{
    class Program
    {
        static void Main()
        {
            List<string> titulos = new List<string>();
            List<string> autores = new List<string>();

            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n===== SISTEMA DE BIBLIOTECA =====");
                Console.WriteLine("1. Registrar libro");
                Console.WriteLine("2. Buscar libro");
                Console.WriteLine("3. Mostrar catálogo");
                Console.WriteLine("4. Contar cantidad de libros");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Título del libro: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Autor: ");
                        string autor = Console.ReadLine();

                        titulos.Add(titulo);
                        autores.Add(autor);

                        Console.WriteLine("Libro registrado correctamente.");
                        break;

                    case 2:
                        Console.Write("Título a buscar: ");
                        string tituloBuscado = Console.ReadLine();
                        int indiceEncontrado = titulos.IndexOf(tituloBuscado);

                        if (indiceEncontrado == -1)
                        {
                            Console.WriteLine("Libro no encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Encontrado: \"" + titulos[indiceEncontrado] + "\" - " + autores[indiceEncontrado]);
                        }
                        break;

                    case 3:
                        if (titulos.Count == 0)
                        {
                            Console.WriteLine("El catálogo está vacío.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Catálogo de libros ---");
                            for (int i = 0; i < titulos.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". \"" + titulos[i] + "\" - " + autores[i]);
                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("Cantidad de libros registrados: " + titulos.Count);
                        break;

                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
