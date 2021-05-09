using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor que setea en la sobrecarga de la clase padre los parametros recibidos.
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Marca a asignar</param>
        /// <param name="color">Marca a asignar</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color):base (chasis,color,marca)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el tamaño chico para esta clase de vehiculo.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que dedvuelve los datos del vehiculo de esta clase.
        /// </summary>
        /// <returns>Retorna los datos del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
