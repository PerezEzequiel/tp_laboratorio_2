using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Trompeta : Instrumento
    {
        private string clave;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Trompeta()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="esUsado"></param>
        /// <param name="porcentajeGanancia"></param>
        /// <param name="origen"></param>
        public Trompeta(string clave, int codigo, double precio, string marca, string modelo, bool esUsado, int porcentajeGanancia, EOrigen origen) : base(precio,codigo, marca, modelo, esUsado, porcentajeGanancia, origen, EClasificacion.Viento)
        {
            this.clave = clave;
        }

        /// <summary>
        /// Propiedad de lectura clave.
        /// </summary>
        public string Clave
        {
            get
            {
                return this.clave;
            }
        }

        /// <summary>
        /// Muestra de trompeta
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------Trompeta-------");
            sb.AppendLine($"Clave: {this.Clave}");
            sb.Append($"{base.ToString()}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescritura de equals utilizando la sobrecarga del operador == implementado en instrumento
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            Trompeta trompeta = obj as Trompeta;

            return trompeta is not null && trompeta == this;
        }

    }
}
