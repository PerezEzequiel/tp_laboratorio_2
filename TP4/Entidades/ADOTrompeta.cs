using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOTrompeta
    {
        private static string stringConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static ADOTrompeta()
        {
            ADOTrompeta.stringConexion = @"Server=LAPTOP-JCK5KOU2;Initial Catalog=bd-local; Integrated Security=true";
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ADOTrompeta()
        {
            this.conexion = new SqlConnection(ADOTrompeta.stringConexion);
            this.comando = new SqlCommand();
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
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = texto;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();
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
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
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
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT * from tabla_stockTrompetaDos where codigo = {codigo}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = comando.ExecuteReader();

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
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
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

                this.comando = new SqlCommand();

                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas != 1)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                throw;
                rta = false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
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
                this.comando.Parameters.AddWithValue("@codigo", trompeta.Codigo);
                this.comando.Parameters.AddWithValue("@marca", trompeta.Marca);
                this.comando.Parameters.AddWithValue("@modelo", trompeta.Modelo);
                this.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(trompeta.EsUsado));
                this.comando.Parameters.AddWithValue("@origen", (int)trompeta.Origen);
                this.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Viento);
                this.comando.Parameters.AddWithValue("@costo", trompeta.Costo);
                this.comando.Parameters.AddWithValue("@porcentajeGanancia", trompeta.PorcentajeGanancia);
                this.comando.Parameters.AddWithValue("@clave", trompeta.Clave);

                string sql = $"UPDATE tabla_stockTrompetaDos SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, clave = @clave WHERE codigo = @codigo";



                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                if (this.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                throw;
                rta = false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
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
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = texto;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                if (this.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                throw;
                rta = false;
            }
            finally
            {
                if (this.conexion.State == System.Data.ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return rta;
        }
    }
}
