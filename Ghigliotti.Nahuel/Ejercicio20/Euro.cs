using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            Euro.cotizRespectoDolar = 1.08;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro()
        {

        }
        #endregion

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizEuro()
        {
            return Euro.cotizRespectoDolar;
        }

        public double GetCantEuro()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Euro moneda)
        {
            return new Dolar(moneda.GetCantEuro() * Euro.GetCotizEuro());
        }

        public static explicit operator Pesos(Euro moneda)
        {
            return new Pesos(((Dolar)moneda).GetCantDolar()* Pesos.GetCotizPesos());
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return ((Euro)d).GetCantEuro() == e.GetCantEuro();
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(((Euro)d).GetCantEuro() == e.GetCantEuro());
        }


    }
}
