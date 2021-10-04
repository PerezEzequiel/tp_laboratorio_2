using System;
using System.Text;

namespace Entidades
{
    public class Suv : Vehiculo
    {
        #region Constructor 
        public Suv(EMarca marca, string chasis, ConsoleColor color)
        : base(chasis, marca, color)
        {

        }
        #endregion

        #region Propiedad
        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;
            }
        }

        #endregion

        #region Metodo
        /// <summary>
        /// Devuelve las caracteristicas del Suv.
        /// </summary>
        /// <returns></returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.Append($"TAMAÑO : {this.Tamanio}");
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        #endregion
    }
}
