/* 8. Se necesita una función que calcule y muestre en pantalla el área o el volumen de un cilindro, 
 * según se especifique. Para distinguir un caso de otro, además de pasarle por parámetro el radio 
 * y la altura, se le pasará el carácter ’a’ (para área) o ’v’ (para el volumen). */

using System;

namespace Tarea5_Ej8
{
    internal class Program8
    {
        static void Main(string[] args)
        {
            // Realizo las variables del Area y la Altura
            double radio, altura;

            Console.Write("Ingrese el valor del Radio del Cilindro: ");
            radio = double.Parse(Console.ReadLine());

            Console.Write("\nIngrese el valor de la Altura del Cilindro: ");
            altura = double.Parse(Console.ReadLine());

            PaseParametros(radio, altura);
        }

        static void PaseParametros(double rad, double alt){
            // Realizo las variables
            double area, volumen;

            // Cargo el valor de area( radio * radio * PI )
            area = rad * rad * Math.PI;

            Console.WriteLine("\nEl Area del Circulo es: " + area);
            Console.ReadLine();

            // Cargo el valor del volumen( Pi * radio * radio * altura)
            volumen = Math.PI * rad * rad * alt;

            Console.WriteLine("\nEl Volumen del circuito es: " + volumen +"cm");
        }
    }
}
