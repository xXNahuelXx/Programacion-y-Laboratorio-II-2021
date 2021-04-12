using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    public class Sumador
    {
        #region Atributos
        private int cantidadSumas;
        #endregion

        #region Constructores
        public Sumador(int cantidadDeSumas)
        {
            this.cantidadSumas = cantidadDeSumas;
        }

        public Sumador() : this(0)
        {
        }
        #endregion

        #region Metodos
        public long Sumar(long num1,long num2)
        {
            this.cantidadSumas++;
            return num1 + num2;
        }

        public string Sumar(string algo1,string algo2)
        {
            this.cantidadSumas++;
            return algo1 + " " + algo2;
        }

        public static explicit operator int (Sumador objeto)
        {
            return objeto.cantidadSumas;
        }

        public static long operator + (Sumador s1,Sumador s2)
        {
            return (long)(s1.cantidadSumas + s2.cantidadSumas);
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }
        #endregion
    }
}
