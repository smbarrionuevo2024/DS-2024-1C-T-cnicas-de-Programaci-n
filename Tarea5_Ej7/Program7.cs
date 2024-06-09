/* 7. Armar una función que muestre en pantalla el doble del valor que se le pasa como parámetro. */

using System;

namespace Tarea5_Ej7
{
    internal class Program7
    {
        static void ValorDoble(int nro1)
        {
            Console.WriteLine("El doble del nro " + nro1 + " es: " + (nro1 * 2));
        }
        static void Main(string[] args)
        {
            // Creo la variable 
            int var1;

            Console.WriteLine("Ingrese el nro que quiera saber su valor doble: ");
            var1 = int.Parse(Console.ReadLine());

            ValorDoble(var1);

            Console.ReadLine();
        }
    }
}
