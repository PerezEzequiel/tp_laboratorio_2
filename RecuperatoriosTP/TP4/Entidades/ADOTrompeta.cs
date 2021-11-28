using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOTrompeta : ADOStock
    {
        public ADOTrompeta() : base()
        {

        }

        /// <summary>
        /// Obtiene una lista de trompetas de la bsd
        /// </summary>
        /// <returns></returns>
        public List<Trompeta> ObtenerListaTrompeta()
        {
            List<Trompeta> lista = null;

            string texto = "SELECT * FROM tabla_stockTrompetaDos";

            try
            {
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = texto;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                base.lector = comando.ExecuteReader();
                lista = new List<Trompeta>();

                while (lector.Read())
                {
                    Trompeta item = new Trompeta((string)lector["clave"], (int)lector["codigo"], (double)lector["costo"],  (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);

                    lista.Add(item);
                }
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
                }
            }
            return lista;
        }

        
        /// <summary>
        /// Obtiene una trompeta de la bsd
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Trompeta ObtenerTrompeta(int codigo)
        {
            Trompeta trompeta = null;
            try
            {
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"SELECT * from tabla_stockTrompetaDos where codigo = {codigo}";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    trompeta = new Trompeta((string)lector["clave"], (int)lector["codigo"], (double)lector["costo"], (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
                }
            }
            return trompeta;
        }


        /// <summary>
        /// Agrega una trompeta en la bsd
        /// </summary>
        /// <param name="trompeta"></param>
        /// <returns></returns>
        public bool AgregarTrompeta(Trompeta trompeta)
        {
            bool rta = true;
            try
            {
                string sql = $"INSERT into tabla_stockTrompetaDos values ('{trompeta.Codigo}', '{trompeta.Marca}','{trompeta.Modelo}', '{Convert.ToInt32(trompeta.EsUsado)}','{(int)trompeta.Origen}', '{(int)EClasificacion.Viento}', '{trompeta.Costo}','{trompeta.PorcentajeGanancia}', '{trompeta.Clave}')";

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = sql;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                int filasAfectadas = base.comando.ExecuteNonQuery();

                if (filasAfectadas != 1)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
                throw;
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
                }
            }
            return rta;
        }



        /// <summary>
        /// Modifica una trompeta de la bsd
        /// </summary>
        /// <param name="trompeta"></param>
        /// <returns></returns>
        public bool ModificarTrompeta(Trompeta trompeta)
        {
            bool rta = true;

            try
            {
                base.comando.Parameters.AddWithValue("@codigo", trompeta.Codigo);
                base.comando.Parameters.AddWithValue("@marca", trompeta.Marca);
                base.comando.Parameters.AddWithValue("@modelo", trompeta.Modelo);
                base.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(trompeta.EsUsado));
                base.comando.Parameters.AddWithValue("@origen", (int)trompeta.Origen);
                base.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Viento);
                base.comando.Parameters.AddWithValue("@costo", trompeta.Costo);
                base.comando.Parameters.AddWithValue("@porcentajeGanancia", trompeta.PorcentajeGanancia);
                base.comando.Parameters.AddWithValue("@clave", trompeta.Clave);

                string sql = $"UPDATE tabla_stockTrompetaDos SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, clave = @clave WHERE codigo = @codigo";



                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = sql;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                if (base.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
                throw;
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
                }
            }
            return rta;
        }


        /// <summary>
        /// Elimina una trompeta de la bsd
        /// </summary>
        /// <param name="Trompeta"></param>
        /// <returns></returns>
        public bool BorrarTrompeta(Trompeta Trompeta)
        {
            bool rta = true;

            try
            {
                string texto = $"DELETE FROM tabla_stockTrompetaDos where codigo = {Trompeta.Codigo}";
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = texto;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                if (base.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                rta = false;
                throw;
            }
            finally
            {
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
                }
            }
            return rta;
        }
    }
}
