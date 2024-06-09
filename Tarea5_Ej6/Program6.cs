/* 6. Se necesita crear una función a la que se le pasan por parámetro dos enteros 
 * y muestra todos los números comprendidos entre ellos, inclusive. */

using System;

namespace Tarea5_Ej6
{
    
    internal class Program6
    {
        static void NroComprendidos(int val1, int val2)
        {
            // Declaro una variable para saber cuantos nro tengo que mostrar
            int varc, i = 0;

            //Busco la diferencia entre val1 y val 2
            varc = val2 - val1;

            Console.WriteLine ("\n\n");
            for (i = val1; i >= val1 && i <= val2; i++)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            // inicio la variables
            int var1, var2;

            // Le solicito al usuario que ingrese el 1er nro
            Console.WriteLine("Ingrese el primer nro: ");
            var1 = int.Parse(Console.ReadLine());
            
            // Le solicito al usuario que ingrese el 2do nro
            Console.WriteLine("Ingrese el segundo nro: ");
            var2 = int.Parse(Console.ReadLine());

            // Llamo a la función NroComprendidos
            NroComprendidos(var1, var2);

        }
    }
}
