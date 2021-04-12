using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public class Conversor
    {
        public static string DecimalBinario(Int32 numero)
        {
            String cadena=null;
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = numero / 2;
                }
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            return cadena;
        }

        public static double BinarioDecimal(String cadena)
        {
            Int32 cant=cadena.Length;
            Double expo;
            Double acum = 0;
            expo = cant - 1;
            foreach (Char auxNum in cadena)
            {
                if (auxNum=='1')
                {
                    acum +=Math.Pow(2,expo);
                }
                expo--;
            }
            return acum;
        }
    }
}
