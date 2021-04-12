using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;
namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro euro = new Euro(1);
            Dolar dolar = new Dolar(1);

            /*Console.WriteLine(dolar==euro);
            Console.WriteLine(euro == dolar);*/

            Dolar resultado;
            resultado = dolar - euro;
            Console.WriteLine(resultado.GetCantDolar());
            Console.ReadKey(true);
        }   
    }
}
