using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_de_Contactos
{
    class Program
    {
        static void Main()
        {
            List<string> nombres = new List<string>();
            List<string> telefonos = new List<string>();

            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n===== AGENDA DE CONTACTOS =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Buscar por nombre");
                Console.WriteLine("4. Eliminar contacto");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Nombre del contacto: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Teléfono: ");
                        string telefono = Console.ReadLine();

                        nombres.Add(nombre);
                        telefonos.Add(telefono);

                        Console.WriteLine("Contacto agregado correctamente.");
                        break;

                    case 2:
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("La agenda está vacía.");
                        }
                        else
                        {
                            Console.WriteLine("\n--- Lista de contactos ---");
                            for (int i = 0; i < nombres.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + nombres[i] + " - " + telefonos[i]);
                            }
                        }
                        break;

                    case 3:
                        Console.Write("Nombre a buscar: ");
                        string nombreBuscado = Console.ReadLine();
                        int indiceEncontrado = nombres.IndexOf(nombreBuscado);

                        if (indiceEncontrado == -1)
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Encontrado: " + nombres[indiceEncontrado] + " - " + telefonos[indiceEncontrado]);
                        }
                        break;

                    case 4:
                        Console.Write("Nombre del contacto a eliminar: ");
                        string nombreEliminar = Console.ReadLine();
                        int indiceEliminar = nombres.IndexOf(nombreEliminar);

                        if (indiceEliminar == -1)
                        {
                            Console.WriteLine("Contacto no encontrado.");
                        }
                        else
                        {
                            nombres.RemoveAt(indiceEliminar);
                            telefonos.RemoveAt(indiceEliminar);
                            Console.WriteLine("Contacto eliminado.");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Saliendo de la agenda...");
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
