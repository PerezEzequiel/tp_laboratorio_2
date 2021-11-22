using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoTexto : IGuardar
    {
        /// <summary>
        /// Implementacion de interfaz IGuardar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public bool Guardar<T>(T obj, string ruta) where T : class
        {
            bool seGuardo = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    sw.WriteLine(obj);
                    seGuardo = true;
                }
            }
            catch (Exception e)
            {
                throw new CampoInvalidoException("Ocurrio un error al guardar archivo texto",e);
            }
            return seGuardo;
        }
    }
}
