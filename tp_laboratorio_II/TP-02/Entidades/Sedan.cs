using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {

        #region Atributos
        private ETipo tipo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : base(chasis, color, marca)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructor que sobrecarga con el de pordefecto y ademas setea el tipo.
        /// </summary>
        /// <param name="marca">Marca a asignar</param>
        /// <param name="chasis">Chasis a asignar</param>
        /// <param name="color">Color a asignar</param>
        /// <param name="tipo">Tipo a asignar</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : this(marca, chasis, color)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Enumerados
        /// <summary>
        /// Enumerado para el tipo, con valores por defecto 0 y 1.
        /// </summary>
        public enum ETipo 
        { 
            CuatroPuertas, 
            CincoPuertas 
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve el tamaño mediano para esta clase de vehiculo.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo que muestra los datos del vehiculo de esta clase.
        /// </summary>
        /// <returns>Retorna los datos del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
