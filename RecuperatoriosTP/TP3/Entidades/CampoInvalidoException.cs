using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CampoInvalidoException : Exception
    {
        /// <summary>
        /// Constructor por defecto, llama a la sobrecarga que recibe un mensaje
        /// </summary>
        public CampoInvalidoException() : this("Por favor cargue bien el campo")
        {

        }
        
        /// <summary>
        /// Constructor parametrizado, llama a la sobrecarga que recibe un exception
        /// </summary>
        /// <param name="mensaje"></param>
        public CampoInvalidoException(string mensaje) : this(mensaje, null)
        {

        }
        
        /// <summary>
        /// Constructor parametrizado, llama al constructor de la base.
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="innerException"></param>
        public CampoInvalidoException(string mensaje, Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
