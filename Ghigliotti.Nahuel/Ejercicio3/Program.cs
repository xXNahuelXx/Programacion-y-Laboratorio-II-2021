using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 3";

            Int32 limitador;
            Int32 otroNum = 2;
            Int32 sePuede;
            
            Console.Write("Ingrese un numero: ");
            limitador=Int32.Parse(Console.ReadLine());
            Console.WriteLine("NUMEROS PRIMOS");

            while (otroNum<=limitador)
            {
                sePuede = 0;
                for (Int32 i=1;i<=limitador;i++)
                {
                    if(otroNum%i==0)
                    {
                        sePuede++;
                    }
                    if(sePuede>2)
                    {
                        break;
                    }
                }
                if (sePuede == 2)
                {
                    Console.WriteLine("{0}", otroNum);
                }
                otroNum++;
            }
            Console.ReadKey(true);
        }
    }
}
