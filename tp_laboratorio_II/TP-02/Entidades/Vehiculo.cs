using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region Atributos
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que setea los valores enviados
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        public Vehiculo(string chasis, ConsoleColor color, EMarca marca)
        {
            this.chasis = chasis;
            this.color = color;
            this.marca = marca;
        }
        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerados de las marcas de los vehiculos, con valor de 0 a 6 por defecto.
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerados de los tamaños de los vehiculos, con valor por defecto de 0 a 2.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        { 
            get; 
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Realiza el casteo explicito para que realice el metodo donde se muestran los datos del vehiculo.
        /// </summary>
        /// <returns>Retorna el objeto casteado a string</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        /// <summary>
        /// Realiza la sobracarga del tipo de dato string para que muestre los datos del vehiculo cuando se requiera castear.
        /// </summary>
        /// <param name="p">Recbe un vehiculo para luego ser mostrado</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}\r");
            sb.AppendLine($"MARCA : {p.marca.ToString()}\r");
            sb.AppendLine($"COLOR : {p.color.ToString()}\r");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">Recibe vehiculo1</param>
        /// <param name="v2">Recibe vehiculo2</param>
        /// <returns>Retorna la comparacion</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Realiza la comparacion de dos vehiculos y lo que devuelva lo niega para marcar distincion.
        /// </summary>
        /// <param name="v1">Recibe vehiculo1</param>
        /// <param name="v2">Recibe vehiculo2</param>
        /// <returns></returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.chasis == v2.chasis);
        }
        #endregion
    }
}
