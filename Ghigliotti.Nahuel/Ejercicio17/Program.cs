using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerBoli;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";

            string dibujo = "";

            Boligrafo tintaAzul = new Boligrafo(5,ConsoleColor.Blue);
            Boligrafo tintaRoja = new Boligrafo(50, ConsoleColor.Red);

           if(tintaAzul.Pintar(30,out dibujo)==true)
            {
                Console.WriteLine(dibujo);
            }
           else
            {
                Console.WriteLine(dibujo);
            }
            Console.WriteLine("Le queda {0}% de tinta, necesita recargar!",tintaAzul.GetTinta());
            tintaAzul.Recargar();
            Console.WriteLine("Le queda {0}% de tinta, necesita recargar!", tintaAzul.GetTinta());
            Console.ReadKey(true);


        }
    }
}
