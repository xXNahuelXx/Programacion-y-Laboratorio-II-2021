using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        #region Atributos
        private double cantidad;
        private static double cotizRespectoDolar;
        #endregion

        #region Constructores
        private Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static double GetCotizPesos()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantPesos()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Pesos moneda)
        {
            return new Dolar((moneda.GetCantPesos() * Pesos.GetCotizPesos()));
        }

        public static explicit operator Euro(Pesos moneda)
        {
            return (Euro)((Dolar)moneda);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return ((Pesos)d).GetCantPesos() == p.GetCantPesos();
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(((Pesos)d).GetCantPesos() == p.GetCantPesos());
        }
    }
}
