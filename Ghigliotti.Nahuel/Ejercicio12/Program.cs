using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            Boolean seguir=true;
            Int32 num;
            Int32 acum = 0;
            Char opcion;
            Char opcion2;
            do
            {
                Console.Write("Ingrese un numero: ");
                num=Int32.Parse(Console.ReadLine());
                acum += num;
                Console.Write("Desea seguir? (S/N): ");
                opcion = Char.Parse(Console.ReadLine());
                opcion2=Char.ToUpper(opcion);

                if (ValidarRespuesta.ValidaS_N(opcion2)!=true)
                {
                    break;
                }
            } while (seguir == true);

            Console.WriteLine("La suma de los numeros ingresados es: {0}", acum);
            Console.ReadKey(true);
        }
    }
}
