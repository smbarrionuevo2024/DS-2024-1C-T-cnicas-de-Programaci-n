/* 3.  Diseñar una función que tenga como parámetros dos números, y que calcule el máximo.
   
Idem al anterior pero que calcule el máximo de 3 números.
*/

using System;
using System.Linq;

namespace Tarea5_Ej4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            // Inicio un array de 3 columnas
            int[] numeros = new int[3];

            int v, max = numeros[0], min = numeros[0];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese un nro: ");
                v = int.Parse(Console.ReadLine());
                numeros[i] = v; // utilizo la i del for para posicionarme en el array
            }
            Console.WriteLine("\n\nEl numero mayor es: " + numeros.Max());
            Console.WriteLine("\n\nEl número menor es: " + numeros.Min());
        }
    }
}
