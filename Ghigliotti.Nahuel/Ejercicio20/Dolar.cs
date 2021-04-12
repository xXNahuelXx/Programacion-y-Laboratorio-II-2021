using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar()
        {
           
        }
        #endregion

        #region Getters
        public static double GetCotizDolar()
        {
            return Dolar.cotizRespectoDolar;
        }

        public double GetCantDolar()
        {
            return this.cantidad;
        }
        #endregion
        public Dolar(double cantidad,double cotizacion):this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public static explicit operator Euro(Dolar moneda)
        {
            return new Euro((moneda.GetCantDolar()/Euro.GetCotizEuro()));
        }

        public static explicit operator Pesos(Dolar moneda)
        {
            return new Pesos((moneda.GetCantDolar()*Pesos.GetCotizPesos()));
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return ((Dolar)e).GetCantDolar() == d.GetCantDolar();
        }
        public static bool operator !=(Dolar d,Euro e)
        {
            return !(((Dolar)e).GetCantDolar() == d.GetCantDolar());
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return ((Dolar)p).GetCantDolar() == d.GetCantDolar();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(((Dolar)p).GetCantDolar() == d.GetCantDolar());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantDolar() == d2.GetCantDolar();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.GetCantDolar() == d2.GetCantDolar());
        }

        public static Dolar operator -(Dolar d,Euro e)
        {
            return new Dolar(d.GetCantDolar() - ((Dolar)e).GetCantDolar());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantDolar() - ((Dolar)p).GetCantDolar());
        }

        public static Dolar operator -(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantDolar()-d2.GetCantDolar());
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantDolar() + ((Dolar)e).GetCantDolar());
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantDolar() + ((Dolar)p).GetCantDolar());
        }

        public static Dolar operator +(Dolar d1, Dolar d2)
        {
            return new Dolar(d1.GetCantDolar() + d2.GetCantDolar());
        }
    }
}
