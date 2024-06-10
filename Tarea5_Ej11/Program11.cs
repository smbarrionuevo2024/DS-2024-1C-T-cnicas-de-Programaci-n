/* 11.  Crear una función a la que se le pasa un número entero y devuelve un array con los 
 * divisores primos de dicho número. */

using System;

namespace Tarea5_Ej11
{
    internal class Program11
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
            // Creo una array 
            int[] divisores = new int [9];

            for (int i = 0; i < 10; i++)
            {
                if (numero % i == 0)
                {
                    divisores[i] = i;
                }
                else
                {

                }
            }

            // Recoro la variabla para saber que nro son divisibles
            for(int x = 0; x < 10; x++)
            {
                if (divisores[x] != 0) 
                { 
                Console.WriteLine("El numero " + numero + " es divisor de ");
                Console.WriteLine(divisores[x]);
                }
            }
        }
    }
}
