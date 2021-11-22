using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Xml : IGuardar, IAbrir
    {
        /// <summary>
        /// Implementacion de interfaz IGuardar
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public bool Guardar<T>(T obj, string ruta) where T : class
        {
            bool Nofallo = false;
            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(writer, obj);
                    Nofallo = true;
                }

            }
            catch (Exception e)
            {
                throw new CampoInvalidoException("Hubo un error al serializar", e);
            }
            return Nofallo;
        }
        
        /// <summary>
        /// Implementacion de interfaz IAbrir
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruta"></param>
        /// <returns></returns>
        public T Abrir<T>(string ruta) where T : class
        {

            T obj = null;
            try
            {
                if (!File.Exists(ruta))
                {
                    throw new CampoInvalidoException("No existe ese directorio");
                }
                else
                {
                    using (XmlTextReader reader = new XmlTextReader(ruta))
                    {

                        XmlSerializer ser = new XmlSerializer(typeof(T));

                        obj = ser.Deserialize(reader) as T;
                    }
                }
            }
            catch (Exception e)
            {
                throw new CampoInvalidoException("Hubo un error al deserializar",e);
            }
            return obj;

        }
    }
}
