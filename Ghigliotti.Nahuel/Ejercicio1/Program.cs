using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 1";

            Int32 num;
            Int32 max=Int32.MinValue;
            Int32 min=Int32.MaxValue;
            Int32 acum = 0;
            Single promedio;

            for(Int32 i=0;i<5;i++)
            {
                Console.Write("Ingrese un numero: ");
                num=Int32.Parse(Console.ReadLine());
                acum += num;
                if(num<min)
                {
                    min = num;      
                }
                if (num>max)
                {
                    max = num;
                }
            }
            promedio = (Single)acum / 5;

            Console.WriteLine("El numero maximo es: {0}\nEl numero minimo es: {1}\nEl promedio es: {2:#,###.00}",max,min,promedio);

            Console.ReadKey(true);
        }
    }
}