/*--------------------------------------------------------------
                Eduardo Castro Rojas
                Tarea Programada 1
--------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoProgramado1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                try
                {   //Valida que el número sea un entero entre 2 y 45 y que sea entero
                    Console.Write("Pon un numero entero entre 2 y 45: ");
                    if (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.WriteLine("El valor no es un entero.\n");
                        continue;
                    }

                    if (n < 2 || n > 45)
                    {
                        Console.WriteLine("Valor fuera del rango.\n");
                        continue;
                    }

                    break; // El número es válido, sale del bucle
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error inesperado. Por favor, inténtalo de nuevo: {ex.Message}\n");
                }
            }

            try
            {
                // Calcular la ecuacion de Binet para el n número de Fibonacci
                double phi = (1 + Math.Sqrt(5)) / 2;
                Console.WriteLine($"\nPhi ~ {phi}");

                // Realizar la secuencia para el n número de Fibonacci
                int[] fib = new int[n + 1];
                fib[0] = 0;
                fib[1] = 1;

                for (int i = 2; i <= n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }

                // Mostrar las aproximaciones de phi usando la secuencia
                for (int i = 2; i <= n; i++)
                {
                    double Approx = (double)fib[i] / fib[i - 1];
                    double Diff = Math.Abs(phi - Approx);
                    Console.WriteLine($"Fib({i}) / Fib({i - 1}) ~ {Approx} [+- {Diff}]");
                }

                // Mostrar los últimos dos valores de Fibonacci
                Console.WriteLine($"\nFib({n}) = {fib[n]}");
                Console.WriteLine($"Fib({n - 1}) = {fib[n - 1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado. Por favor, inténtalo de nuevo: {ex.Message}");
            }
        }
    }
}
