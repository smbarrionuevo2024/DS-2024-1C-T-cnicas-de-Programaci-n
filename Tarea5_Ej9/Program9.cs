/* 8. Se necesita una función que calcule y muestre en pantalla el área o el volumen de un cilindro, 
 * según se especifique. Para distinguir un caso de otro, además de pasarle por parámetro el radio y 
 * la altura, se le pasará el carácter ’a’ (para área) o ’v’ (para el volumen).
 * 
 * 9. Idem al anterior pero que devuelva un array con ambos cálculos: el área y el volumen.  */

using System;

namespace Tarea5_Ej9
{
    internal class Program9
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

        static void PaseParametros(double rad, double alt)
        {
            // Realizo las variables
            double radio, altura;

            // Cargo el valor de area( radio * radio * PI )
            double[] area = { rad * rad * Math.PI };


            Console.WriteLine("\nEl Area del Circulo es: " + area[0]);


            // Cargo el valor del volumen( Pi * radio * radio * altura)
            double[] volumen = { Math.PI * rad * rad * alt };

            Console.WriteLine("\nEl Volumen del circuito es: " + volumen[0] + " cm3");
            Console.ReadLine();
        }
    }
}
