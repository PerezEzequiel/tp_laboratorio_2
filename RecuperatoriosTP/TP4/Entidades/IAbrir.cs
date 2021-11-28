using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IAbrir
    {
        /// <summary>
        /// Abre un archivo y devuelve lo que cargo en un objeto.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruta">PATH</param>
        /// <returns></returns>
        T Abrir<T>(string ruta) where T : class;
    }
}
