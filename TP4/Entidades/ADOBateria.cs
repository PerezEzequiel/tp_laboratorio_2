using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOBateria
    {
        private static string stringConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static ADOBateria()
        {
            ADOBateria.stringConexion = @"Server=LAPTOP-JCK5KOU2;Initial Catalog=bd-local; Integrated Security=true";
        }

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ADOBateria()
        {
            this.conexion = new SqlConnection(ADOBateria.stringConexion);
            this.comando = new SqlCommand();
        }

        /// <summary>
        /// Obtiene la lista que se encuentra en la bsd
        /// </summary>
        /// <returns></returns>
        public List<Bateria> ObtenerListaBateria()
        {
            List<Bateria> lista = null;

            string texto = "SELECT * FROM tabla_stockBateria";

            try
            {
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = texto;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();
                lista = new List<Bateria>();

                while (lector.Read())
                {
                    Bateria item = new Bateria((int)lector["cantidadDeCuerpos"], (int)lector["codigo"], (double)lector["costo"], (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);

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
        /// Obtiene solo una bateria, la que recibe por parametro
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Bateria ObtenerBateria(int codigo)
        {
            Bateria bateria = null;
            try
            {
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT * from tabla_stockBateria where codigo = {codigo}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    bateria = new Bateria((int)lector["cantidadDeCuerpos"], (int)lector["codigo"], (double)lector["costo"], (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);
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
            return bateria;
        }

        /// <summary>
        /// Agrega una bateria en la bsd
        /// </summary>
        /// <param name="bateria"></param>
        /// <returns></returns>
        public bool AgregarBateria(Bateria bateria)
        {
            bool rta = true;
            try
            {
                string sql = $"INSERT into tabla_stockBateria values ('{bateria.Codigo}', '{bateria.Marca}','{bateria.Modelo}', '{Convert.ToInt32(bateria.EsUsado)}','{(int)bateria.Origen}', '{(int)EClasificacion.Percusion}', '{bateria.Costo}','{bateria.PorcentajeGanancia}', '{bateria.CantidadDeCuerpos}')";

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
        /// Modifica una bateria en la bsd
        /// </summary>
        /// <param name="bateria"></param>
        /// <returns></returns>
        public bool ModificarBateria(Bateria bateria)
        {
            bool rta = true;

            try
            {
                this.comando.Parameters.AddWithValue("@codigo", bateria.Codigo);
                this.comando.Parameters.AddWithValue("@marca", bateria.Marca);
                this.comando.Parameters.AddWithValue("@modelo", bateria.Modelo);
                this.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(bateria.EsUsado));
                this.comando.Parameters.AddWithValue("@origen", (int)bateria.Origen);
                this.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Viento);
                this.comando.Parameters.AddWithValue("@costo", bateria.Costo);
                this.comando.Parameters.AddWithValue("@porcentajeGanancia", bateria.PorcentajeGanancia);
                this.comando.Parameters.AddWithValue("@cantidadDeCuerpos", bateria.CantidadDeCuerpos);

                string sql = $"UPDATE tabla_stockBateria SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, cantidadDeCuerpos = @cantidadDeCuerpos WHERE codigo = @codigo";



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
        /// Elimina una bateria de la bsd
        /// </summary>
        /// <param name="bateria"></param>
        /// <returns></returns>
        public bool BorrarBateria(Bateria bateria)
        {
            bool rta = true;

            try
            {
                string texto = $"DELETE FROM tabla_stockBateria where codigo = {bateria.Codigo}";
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = texto;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                if (this.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }
            }
            catch (Exception)
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
            return rta;
        }
    }
}
