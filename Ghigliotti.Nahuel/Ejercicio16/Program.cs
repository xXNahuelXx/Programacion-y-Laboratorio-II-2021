using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Nahuel","Ghigliotti",106161);
            alumno1.Estudiar(7, 8);
            alumno1.CalcularFinal();

            Alumno alumno2 = new Alumno("Antonella", "Tilbes", 117272);
            alumno2.Estudiar(9, 10);
            alumno2.CalcularFinal();

            Alumno alumno3 = new Alumno("Natasha", "Romanoff", 128383);
            alumno3.Estudiar(4, 3);
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine("");
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine("");
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey(true);
        }
    }
}
