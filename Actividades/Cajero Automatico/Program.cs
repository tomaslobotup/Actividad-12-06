using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cajero_Automatico
{
    class Program
    {
        static void Main()
        {
            double saldo = 1000; 
            int opcion = 0;

            while (opcion != 5)
            {
                Console.WriteLine("\n===== CAJERO AUTOMÁTICO =====");
                Console.WriteLine("1. Mostrar saldo inicial");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Extraer dinero");
                Console.WriteLine("4. Consultar saldo");
                Console.WriteLine("5. Salir");
                Console.Write("Elegí una opción: ");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Saldo inicial: $" + saldo);
                        break;

                    case 2:
                        Console.Write("¿Cuánto querés depositar? $");
                        double deposito = Convert.ToDouble(Console.ReadLine());
                        saldo += deposito;
                        Console.WriteLine("Depósito realizado. Nuevo saldo: $" + saldo);
                        break;

                    case 3:
                        Console.Write("¿Cuánto querés extraer? $");
                        double extraccion = Convert.ToDouble(Console.ReadLine());

                        if (extraccion > saldo)
                        {
                            Console.WriteLine("Saldo insuficiente.");
                        }
                        else
                        {
                            saldo -= extraccion;
                            Console.WriteLine("Extracción realizada. Nuevo saldo: $" + saldo);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Tu saldo actual es: $" + saldo);
                        break;

                    case 5:
                        Console.WriteLine("Gracias por usar el cajero. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intentá de nuevo.");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
