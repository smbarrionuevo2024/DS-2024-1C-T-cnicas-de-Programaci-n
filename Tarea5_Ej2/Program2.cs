/* 2. Escribir una función que nos salude, pasándole un nombre por parámetro. 
 * Su salida debe decir por ejemplo ”Hola Aristoteles, ¿cómo estás?”.*/

using System;

namespace Tarea5_Ej2
{
    internal class Program2
    {
        static void PasNombre(string nombre)
        {
            Console.WriteLine("Hola " + nombre + ", ¿cómo estás ?");
        }
        static void Main(string[] args)
        {
            // Declaro la variables
            string nomb;

            Console.WriteLine("Ingrese un Nombre: ");
            nomb = Console.ReadLine();

            PasNombre(nomb);
            Console.ReadLine();
        }
    }
}
