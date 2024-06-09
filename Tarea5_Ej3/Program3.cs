/* 3.  Diseñar una función que tenga como parámetros dos números, y que calcule el máximo. -- */

using System;

namespace Tarea5_Ej3
{
    internal class Program3
    {
        static void ValMaximo(int val1, int val2) {

            // Realizo la verificación de cual es el nro mas grande:
            if (val1 > val2)
            {
                Console.WriteLine("El nro " + val1 + " es mayor a " + val2);
            }
            else
            {
                Console.WriteLine("El nro " + val2 + " es mayor a " + val1);
            }
        }

        static void Main(string[] args)
        {
            // Activo las variables Necesarias:
            int var1, var2;

            // Le solicito al usuario que me ingrese el primer Numero
            Console.WriteLine("Ingrese el 1er Numero: ");
            var1 = int.Parse(Console.ReadLine());

            // Le solicito al usuario que me ingrese el segundo Numero
            Console.WriteLine("Ingrese el 2do Numero: ");
            var2 = int.Parse(Console.ReadLine());

            // LLamo a la función ValMaximo
            ValMaximo(var1, var2);

            Console.ReadLine();

        }
    }
}
