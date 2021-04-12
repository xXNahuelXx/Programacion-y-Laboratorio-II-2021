using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            Int32 limite;
            Int32 i=1;
            Int32 j;
            Int32 k;
            Int32 anterior;
            Int32 posterior;
            Int32 numCentral;

            Console.WriteLine("Ingrese un numero para calcular los centros numericos!");
            limite = Int32.Parse(Console.ReadLine());

            while(i!=limite)
            {
                numCentral = i;
                anterior = 0;
                posterior = 0;
                if(numCentral>1)
                {
                    for(j=numCentral-1;j>=1;j--)
                    {
                        anterior += j;
                    }
                    for(k=numCentral+1;k<=limite;k++)
                    {
                        posterior += k;
                        if(anterior==posterior)
                        {
                         Console.WriteLine("{0}", i);
                        }
                    }
                }
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
