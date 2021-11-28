using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClaseExtension
    {
        /// <summary>
        /// Obtiene TODO el stock de la bsd
        /// </summary>
        /// <param name="local"></param>
        /// <returns></returns>
        public static List<Instrumento>ObtenerTodos(this Local<Instrumento> local)
        {
            ADOGuitarra adoGuitarra = new ADOGuitarra();
            List<Guitarra> listaGuitarra = adoGuitarra.ObtenerListaGuitarra();

            ADOBateria adoBateria = new ADOBateria();
            List<Bateria> listaBateria = adoBateria.ObtenerListaBateria();

            ADOTrompeta adoTrompeta = new ADOTrompeta();
            List<Trompeta> listaTrompeta = adoTrompeta.ObtenerListaTrompeta();

            List<Instrumento> listaCompleta = new List<Instrumento>();

            foreach (Guitarra item in listaGuitarra)
            {
                listaCompleta.Add(item);
            }
            foreach (Trompeta item in listaTrompeta)
            {
                listaCompleta.Add(item);
            }
            foreach (Bateria item in listaBateria)
            {
                listaCompleta.Add(item);
            }

            return listaCompleta;
        }
    }
}
