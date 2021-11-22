using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bateria : Instrumento
    {
        private int cantidadDeCuerpos;
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Bateria()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="cantidadDeCuerpos"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="esUsado"></param>
        /// <param name="porcentajeGanancia"></param>
        /// <param name="origen"></param>
        public Bateria(int cantidadDeCuerpos, int codigo, double precio, string marca, string modelo, bool esUsado,int porcentajeGanancia, EOrigen origen) : base(precio, codigo, marca, modelo, esUsado, porcentajeGanancia,origen, EClasificacion.Percusion)
        {
            this.CantidadDeCuerpos = cantidadDeCuerpos;
        }

        /// <summary>
        /// Propiedad de lectura y escritura de cantidad de cuerpos
        /// </summary>
        public int CantidadDeCuerpos
        {
            set
            {
                if(value <= 0)
                {
                    throw new CampoInvalidoException("No existe una bateria sin cuerpos...");
                }
                else
                {
                    this.cantidadDeCuerpos = value;
                }
            }
            get
            {
                return this.cantidadDeCuerpos;
            }
        }


        /// <summary>
        /// Muestra de una bateria.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------Bateria-------");
            sb.AppendLine($"Cantidad de cuerpos: {this.CantidadDeCuerpos}");
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
            Bateria bateria = obj as Bateria;

            return bateria is not null && bateria == this;
        }
    }
}
