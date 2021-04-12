using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";

            Int32 tam = 9000;
            Int32 numero = 1;
            Int32 acum;

            while (numero <= tam)
            {
                acum = 0;
                for (Int32 i = 1; i <= tam; i++)
                {
                    if (numero%i == 0 && numero!=i)
                    {
                        acum += i;  
                    }
                }
                if (acum == numero)
                {
                    Console.WriteLine("{0} Es perfecto", numero);
                }
                numero++;
            }

            Console.ReadKey(true);
        }
    }
}
