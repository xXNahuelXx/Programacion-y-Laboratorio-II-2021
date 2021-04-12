using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            char operador;
            Console.Write("Ingrese primer numero a calcular: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo numero a calcular: ");
            numero2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la operacion a calcular (+ - * /): ");
            operador=char.Parse(Console.ReadLine());
            if(numero2==0 && operador=='/')
            {
                Console.WriteLine("No se puede dividir por 0.");
            }
            else
            {
                Console.WriteLine("El resulado de {1}{3}{2}={0}", Calculadora.Calcular(numero1, numero2, operador), numero1, numero2, operador);
            }
            Console.ReadKey(true);
        }
    }
}
