using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 19";
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador();

            Console.WriteLine(sumador.Sumar(5, 5));
            Console.WriteLine(sumador.Sumar("Hola","Chau"));
            Console.WriteLine(sumador2.Sumar(5, 5));
            Console.WriteLine(sumador2.Sumar("Hola", "Chau"));
            Console.WriteLine((int)sumador);
            Console.WriteLine((int)sumador2);
            Console.WriteLine(sumador+sumador2);
            Console.WriteLine(sumador | sumador2);

            Console.ReadKey(true);
        }
    }
}
