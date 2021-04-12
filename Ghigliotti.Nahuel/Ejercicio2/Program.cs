using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 2";

            Double num;
            Double cuadrado;
            Double cubo;
            Boolean opcion=true;

            while(opcion==true)
            {

                Console.Write("Ingrese un numero: ");
                num = Double.Parse(Console.ReadLine());
                if(num>0)
                {
                    cuadrado = Math.Pow(num, 2);
                    cubo = Math.Pow(num, 3);

                    Console.Write("{0}^2={1}\n{0}^3={2}", num, cuadrado, cubo);
                    opcion = false;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }               
            }
            /*
            ===========================
            FORMA RUSTICA DE RESOLVERLO
            ===========================
            Int32 num;
            Int32 cuadrado;
            Int32 cubo;
            Boolean opcion=true;

            while(opcion == true)
            {
                Console.Write("Ingrese un numero: ");
                num = Int32.Parse(Console.ReadLine());
                if(num>0)
                {
                    cuadrado = num * num;
                    cubo = num;
                    for(Int32 i=0;i<2;i++ )
                    {
                        cubo*=num;
                    }
                     Console.Write("{0}^2={1}\n{0}^3={2}", num, cuadrado, cubo);
                    opcion = false;
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            }*/
            Console.ReadKey(true);
        }
    }
}
