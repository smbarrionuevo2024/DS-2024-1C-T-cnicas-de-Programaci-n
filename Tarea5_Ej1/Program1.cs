/* 1. Armar una función, a la que se le pase como parámetro un número N, 
 * y muestre por pantalla N veces el mensaje: “Módulo ejecutándose”. */

using System;


namespace Tarea5_Ej1
{
    internal class Program1
    {
        static void IngrParametros(int nro)
        {
            Console.WriteLine("Módulo ejecutándose");
        }
        static void Main(string[] args)
        {
            // Inicio la variable
            int nro = 1;


            while (nro != 0)
            {

                Console.WriteLine("Ingrese un número( o 0 para salir): ");
                nro = int.Parse(Console.ReadLine());

                if (nro != 0)
                {
                    IngrParametros(nro);
                }
                else
                {
                    Console.WriteLine("Ingreso el nro 0... Salgo");
                }

                Console.ReadLine();

            }
        }

    }
}
