using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            Int32 numero;
            Double numD;
            String cadena=null; 

            Console.Write("Ingrese un número entero: ");
            numero = Int32.Parse(Console.ReadLine());
            cadena = Conversor.DecimalBinario(numero);

            numD=Conversor.BinarioDecimal(cadena);

            Console.WriteLine("Binario: {0}",cadena);
            Console.WriteLine("Decimal: {0}", numD);


            Console.ReadKey(true);
        }
    }
}
