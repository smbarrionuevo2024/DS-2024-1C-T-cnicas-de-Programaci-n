/* 3.  Diseñar una función que tenga como parámetros dos números, y que calcule el máximo.
   
Idem al anterior pero que calcule el máximo de 3 números.
Idem al anterior pero que calcule el máximo de un array de n elementos.
*/

using System;
using System.Linq;

namespace Tarea5_Ej5
{
    internal class Program5
    {
        static void Main(string[] args)
        {
            int v, n;


            // Se le pregunta al usuario cuandos nros Va ingresar
            Console.Write("Por favor indique cuantos nros va ingresar: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Se van a ingresar " + n + " números.");

            // Inicio un array de 3 columnas
            int[] numeros = new int[n]; // Creo el array con n registros
            int max = numeros[0], min = numeros[0];


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese un nro(o 0 para salir): ");
                v = int.Parse(Console.ReadLine());
                numeros[i] = v; // utilizo la i del for para posicionarme en el array

            }

            // Termina de Hacer el For y salgo a devolver la respuesta
            Console.WriteLine("\n\nEl numero mayor es: " + numeros.Max());
            Console.WriteLine("\n\nEl número menor es: " + numeros.Min());
        }
    }
}
