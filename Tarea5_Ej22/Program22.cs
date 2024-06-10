/* 22. Escribir una función que sume los n primeros números impares. */

using System;

namespace Tarea5_Ej22
{
    internal class Program22
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            int nro=1, respuesta=0, Total=0;


            while (nro != 0) 
            {
                // Le pido al usuario que ingrese un Número: 
                Console.WriteLine("Ingrese un Numero(o 0 para salir)");
                nro = int.Parse(Console.ReadLine());

                respuesta = EsImpar(nro);
                if (respuesta != 0)
                {
                    Console.WriteLine("Sumo " + respuesta + " " + Total);

                    // Sumo los numeros
                    Total += respuesta;

                    Console.WriteLine("\nTotal: " + Total);
                }
                
            }

        }

        static int EsImpar(int numero)
        {
            if(numero %2 != 0)
            {
                Console.WriteLine(numero + " es un numero ES IMPAR ");
            }
            else {
                Console.WriteLine(numero + " NO ES un numero IMPAR!!! ");
                numero = 0;
            }
            
            return numero;
        }
    }
}
