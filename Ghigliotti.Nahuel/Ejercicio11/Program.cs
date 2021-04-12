using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";
            Int32 i;
            Int32 num;
            Int32 min=int.MaxValue;
            Int32 max=int.MinValue;
            Int32 acum=0;
            Single prom;

            for(i=0;i<10;i++)
            {
                Console.Write("Ingrese un numero: ");
                num = Int32.Parse(Console.ReadLine());
                if(Validacion.Validar(num, -100, 100)==true)
                {
                    if(i==0 || num<min)
                    {
                        min = num;
                    }
                    if (i == 0 || num>max)
                    {
                        max = num;
                    }
                    acum += num;
                }
                else
                {
                    Console.WriteLine("Fuera de rango!");
                }
            }
            prom = (float)acum / 10;
            Console.WriteLine("El minimo es: {0}\nEl maximo es: {1}\nEl promedio es: {2}",min,max,prom);
            Console.ReadKey();
        }
    }
}
