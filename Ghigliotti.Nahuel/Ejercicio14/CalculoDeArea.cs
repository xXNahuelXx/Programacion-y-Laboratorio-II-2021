using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public class CalculoDeArea
    { 
        public static double CalcularCuadrado(double lado)
        {
            double area = 0;
            if(lado>0)
            {
                area= lado * lado;
            }
            return area;
        }

        public static double CalcularTriangulo(double b, double a)
        {
            double resultado = 0;
            if(b>0 && a>0)
            {
                resultado= (b * a) / 2;
            }
            return resultado;
        }

        public static double CalcularCirculo(double radio)
        {
            double area = Math.PI * (Math.Pow(radio, 2));
            return area;
        }

    }
}
