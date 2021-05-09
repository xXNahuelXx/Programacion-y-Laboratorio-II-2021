using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor que setea los parametros recibido con la sobrecarga del constructor de la clase padre.
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        public Suv(EMarca marca, string chasis, ConsoleColor color): base(chasis,color,marca)
        {
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el tamaño grande para esta clase de vehiculo.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los datos del vehiculo de esta clase.
        /// </summary>
        /// <returns>Retorna los datos del vehiculo de esta clase</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
