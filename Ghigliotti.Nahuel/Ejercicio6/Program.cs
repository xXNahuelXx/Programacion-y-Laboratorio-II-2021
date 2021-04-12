using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            Int32 añoInicio;
            Int32 añoFin;
            Int32 i;

            Console.WriteLine("Ingrese un año de inicio: ");
            añoInicio=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un año de fin: ");
            añoFin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nLISTA DE AÑOS BICIESTOS");
            for(i=añoInicio;i<=añoFin;i++)
            {
                if (i%4==0 && (i%400==0 || i%100!=0))
                {
                    Console.WriteLine("{0}",i);
                
                }
            }
            Console.ReadKey(true);
        }
    }
}
