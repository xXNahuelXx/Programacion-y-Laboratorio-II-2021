using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double numero;
            double areaCuadrado;
            double b;
            double a;
            double radio;

            Console.Write("Ingrese un numero para calcular el area de un cuadrado: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("El area de un cuadrado es: {0}",CalculoDeArea.CalcularCuadrado(numero));*/

             Console.Write("Ingrese la base para calcular el area de un triangulo: ");
             b = double.Parse(Console.ReadLine());
             Console.Write("Ingrese la alutra para calcular el area de un triangulo: ");
             a = double.Parse(Console.ReadLine());
             Console.WriteLine("El area de un triangulo es: {0}", CalculoDeArea.CalcularTriangulo(a,b));

            Console.Write("Ingrese el radio para calcular el area de un circulo: ");
            radio= double.Parse(Console.ReadLine());
            Console.WriteLine("El area de un triangulo es: {0:#.00}", CalculoDeArea.CalcularCirculo(radio));

            Console.ReadKey(true);
        }
    }
}
