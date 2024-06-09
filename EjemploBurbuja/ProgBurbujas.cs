/* Algoritmo Burbuja: Compara cada elemento del array y mueve el elemento hasta la última posición */

using System;

namespace EjemploBurbuja
{
    internal class ProgBurbujas
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 17, 16, 8, 67, 1, 4 };

        // Muestro el Array
        mostrar(array);
            Console.ReadLine();

            int x;
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        x = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = x;
                    }
                }
            }

            // Invocamos la funcion matrar
            mostrar(array);
        }

        public static void mostrar(int[] array)
        {
            foreach (int i in array)
                Console.Write(" " + i.ToString());
        
        }
    }
}
