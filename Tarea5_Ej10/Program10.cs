/* 10. Crear una función a la que se le pasa un número entero y devuelve la cantidad de 
 * divisores primos que tiene. */

using System;

namespace Tarea5_Ej10
{
    internal class Program10
    {
        static void Main(string[] args)
        {
            // Declaro las Variables
            int nro;

            // Le pido al usuario que ingrese un nro
            Console.WriteLine("Ingrese un Número: ");
            nro = int.Parse(Console.ReadLine());

            // Llamo a la función CantDivisores
            CantDivisores(nro);
        }

        static void CantDivisores(int numero)
        {
            for (int i = 1; i <= 9; i++)
            {
                if(numero %i == 0)
                {
                    Console.WriteLine("\nEl nro " + numero + " es divisible por " + i);
                }
            }
        }
    }
}
