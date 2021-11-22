using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface IGuardar
    {
        /// <summary>
        /// Guarda en un archivo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Objeto a guardar</param>
        /// <param name="ruta">Path</param>
        /// <returns></returns>
        bool Guardar<T>(T obj, string ruta) where T : class;
    }
}
