/* 26. Escribir una función a la que se le pasa dos arrays, el número de elementos útiles 
 * y que operación se desea realizar: sumar, restar, multiplicar o dividir 
 * (mediante un carácter: ’s’, ’r’, ’m’, ’d’). La función debe devolver un array con 
 * los resultados. */

using System;

namespace Tarea5_Ej26
{
    internal class Program26
    {
        static void Main(string[] args)
        {
            // Declaro las variables
            String Opcion;

            // Le pido al usuario que Ingrese las siguientes opciones
            Console.WriteLine("Bienvenido al Prg elementos útiles");
            Console.WriteLine("\n     s: Para Suman");
            Console.WriteLine("\n     r: Para Restar");
            Console.WriteLine("\n     m: Para Multiplicar");
            Console.WriteLine("\n     d: Para Dividir");
            Console.Write("\nIngrese las Siguientes opciones: ");
            Opcion = Console.ReadLine();

            RealizarOperacion(Opcion);
        }

        static void RealizarOperacion(string operacion)
        {
            int[] PrimerArray = { 1, 3, 5, 7, 9 };
            int[] SegundoArray = { 8, 6, 4, 2, 1 };
            int Total = 0;

            // Creo un Swich para sumar(s), restar(r), multiplicar(m) o dividir(d)
            switch (operacion)
            {
                case "s":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Sumo los siguientes valores: ");
                        Total = PrimerArray[i] + SegundoArray[i];
                        Console.WriteLine("\n" + PrimerArray[i] + " + " + SegundoArray[i] + " = " + Total);
                    }
                break;

                case "r":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Resto los siguientes valores: ");
                        Total = PrimerArray[i] - SegundoArray[i];
                        Console.WriteLine("\n" + PrimerArray[i] + " - " + SegundoArray[i] + " = " + Total);
                    }
                break;

                case "m":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Multiplico los siguientes valores: ");
                        Total = PrimerArray[i] * SegundoArray[i];
                        Console.WriteLine("\n" + PrimerArray[i] + " * " + SegundoArray[i] + " = " + Total);
                    }
                    break;

                case "d":
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Divido los siguientes valores: ");
                        Total = PrimerArray[i] / SegundoArray[i];
                        Console.WriteLine("\n" + PrimerArray[i] + " % " + SegundoArray[i] + " = " + Total);
                    }
                    break;

            }
        }
    }
}
