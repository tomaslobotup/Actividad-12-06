using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            string[] nombres = new string[5];
            int aprobados = 0;
            double suma = 0;
            double notaMasAlta = 0;
            double notaMasBaja = 10;

            Console.WriteLine("=== SISTEMA DE GESTIÓN DE NOTAS ===\n");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Ingresá el nombre del alumno {i + 1}: ");
                nombres[i] = Console.ReadLine();

                Console.Write($"Ingresá la nota de {nombres[i]}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                suma += notas[i];

                if (notas[i] > notaMasAlta)
                    notaMasAlta = notas[i];

                if (notas[i] < notaMasBaja)
                    notaMasBaja = notas[i];

                if (notas[i] >= 6)
                    aprobados++;
            }

            double promedio = suma / 5;

            Console.WriteLine("\n=== RESULTADOS ===\n");

            for (int i = 0; i < 5; i++)
            {
                string estado = notas[i] >= 6 ? "APROBADO ✓" : "DESAPROBADO ✗";
                Console.WriteLine($"{nombres[i]}: {notas[i]} - {estado}");
            }

            Console.WriteLine($"\nPromedio general:  {Math.Round(promedio, 2)}");
            Console.WriteLine($"Nota más alta:     {notaMasAlta}");
            Console.WriteLine($"Nota más baja:     {notaMasBaja}");
            Console.WriteLine($"Aprobados:         {aprobados} de 5");
            Console.WriteLine($"Desaprobados:      {5 - aprobados} de 5");

            Console.WriteLine("\nPresioná Enter para salir...");
            Console.ReadLine();
        }
    }
}
