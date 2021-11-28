using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOBateria : ADOStock
    {
        public ADOBateria() : base()
        {

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
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = texto;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                base.lector = comando.ExecuteReader();
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
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
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
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"SELECT * from tabla_stockBateria where codigo = {codigo}";
                base.comando.Connection = this.conexion;

                base.conexion.Open();
                base.lector = comando.ExecuteReader();

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
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
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

                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = sql;
                base.comando.Connection = this.conexion;

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
        /// Modifica una bateria en la bsd
        /// </summary>
        /// <param name="bateria"></param>
        /// <returns></returns>
        public bool ModificarBateria(Bateria bateria)
        {
            bool rta = true;

            try
            {
                base.comando.Parameters.AddWithValue("@codigo", bateria.Codigo);
                base.comando.Parameters.AddWithValue("@marca", bateria.Marca);
                base.comando.Parameters.AddWithValue("@modelo", bateria.Modelo);
                base.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(bateria.EsUsado));
                base.comando.Parameters.AddWithValue("@origen", (int)bateria.Origen);
                base.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Viento);
                base.comando.Parameters.AddWithValue("@costo", bateria.Costo);
                base.comando.Parameters.AddWithValue("@porcentajeGanancia", bateria.PorcentajeGanancia);
                base.comando.Parameters.AddWithValue("@cantidadDeCuerpos", bateria.CantidadDeCuerpos);

                string sql = $"UPDATE tabla_stockBateria SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, cantidadDeCuerpos = @cantidadDeCuerpos WHERE codigo = @codigo";



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
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = texto;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                if (base.comando.ExecuteNonQuery() != 1)
                {
                    rta = false;
                }
            }
            catch (Exception)
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
