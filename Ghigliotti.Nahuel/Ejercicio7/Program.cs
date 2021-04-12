using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";

            Int32 anio;
            Int32 mes;
            Int32 dia;
            Int64 totalDias;

            Console.WriteLine("Dia de nacimiento[01/]: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes de nacimiento[/02/]: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Año de nacimiento[/1998]: ");
            anio = int.Parse(Console.ReadLine());

            DateTime birth = new DateTime(anio, mes, dia, 0, 0, 0);
            DateTime now = DateTime.Now;

            TimeSpan diferencia = now - birth;
            totalDias = (int)diferencia.TotalDays;

             Console.WriteLine("{0}", birth);
            Console.WriteLine("{0}", now);
            Console.WriteLine("diferencia de dias: {0:##,###.00}", totalDias);

            Console.ReadKey(true);
        }
    }
}
