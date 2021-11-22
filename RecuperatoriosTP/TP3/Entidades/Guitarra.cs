using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guitarra : Instrumento
    {
        private int cantidadDeCuerdas;
        private ETipoGuitarra tipo;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Guitarra()
        {

        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="cantidadDeCuerdas"></param>
        /// <param name="tipo"></param>
        /// <param name="costo"></param>
        /// <param name="codigo"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="esUsado"></param>
        /// <param name="porcentajeGanancia"></param>
        /// <param name="origen"></param>
        public Guitarra(int cantidadDeCuerdas, ETipoGuitarra tipo, double costo, int codigo, string marca, string modelo, bool esUsado, int porcentajeGanancia, EOrigen origen) : base(costo, codigo, marca, modelo, esUsado, porcentajeGanancia, origen, EClasificacion.Cuerda)
        {
            this.CantidadDeCuerdas = cantidadDeCuerdas;
            this.tipo = tipo;
        }
      
        /// <summary>
        /// Propiedad de lectura y escritura de cantidad de cuerdas.
        /// </summary>
        public int CantidadDeCuerdas
        {
            set
            {
                if(value < 6 || value > 8)
                {
                    throw new CampoInvalidoException("Numero de cantidad de cuerdas menor a 6 y mayor a 8 no es valido");
                }
                else
                {
                    this.cantidadDeCuerdas = value;
                }  
            }
            get
            {
                return this.cantidadDeCuerdas;
            }
        }
        
        /// <summary>
        /// Propiedad de lectura y escritura de tipo de guitarra
        /// </summary>
        public ETipoGuitarra Tipo
        {
            set
            {
                this.tipo = value;
            }
            get
            {
                return this.tipo;
            }
        }


        /// <summary>
        /// Muestra de guitarra
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("-------Guitarra-------");
            sb.AppendLine($"Cantidad de cuerdas: {this.cantidadDeCuerdas}");
            sb.AppendLine($"Tipo de guitarra: {this.Tipo}");
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
            Guitarra guitarra = obj as Guitarra;

            return guitarra is not null && guitarra == this;
        }
    }
}
