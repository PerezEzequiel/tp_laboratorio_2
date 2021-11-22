using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOGuitarra
    {
        private static string stringConexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static ADOGuitarra()
        {
            ADOGuitarra.stringConexion = @"Server=LAPTOP-JCK5KOU2;Initial Catalog=bd-local; Integrated Security=true";
        }
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public ADOGuitarra()
        {
            this.conexion = new SqlConnection(ADOGuitarra.stringConexion);
            this.comando = new SqlCommand();
        }

        /// <summary>
        /// Obtiene una lista de guitarras de la bsd
        /// </summary>
        /// <returns></returns>
        public List<Guitarra> ObtenerListaGuitarra()
        {
            List<Guitarra> lista = null;

            string texto = "SELECT * FROM tabla_stockGuitarra";

            try
            {
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = texto;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();
                lista = new List<Guitarra>();

                while (lector.Read())
                {
                    Guitarra item = new Guitarra((int)lector["cantidadDeCuerdas"], (ETipoGuitarra)lector["tipo"], (double)lector["costo"], (int)lector["codigo"], (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);

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
        /// Obtiene solo una guitarra de la bsd
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Guitarra ObtenerGuitarra(int codigo)
        {
            Guitarra guitarra = null;
            try
            {
                this.comando.CommandType = System.Data.CommandType.Text;
                this.comando.CommandText = $"SELECT * from tabla_stockGuitarra where codigo = {codigo}";
                this.comando.Connection = this.conexion;

                this.conexion.Open();
                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    guitarra = new Guitarra((int)lector["cantidadDeCuerdas"], (ETipoGuitarra)lector["tipo"], (double)lector["costo"], (int)lector["codigo"], (string)lector["marca"], (string)lector["modelo"], Convert.ToBoolean(lector["esUsado"]), (int)lector["porcentajeGanancia"], (EOrigen)lector["origen"]);
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
            return guitarra;
        }

        /// <summary>
        /// Agrega una guitarra a la bsd
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public bool AgregarGuitarra(Guitarra guitarra)
        {
            bool rta = true;
            try
            {
                string sql = $"INSERT into tabla_stockGuitarra values ('{guitarra.Codigo}', '{guitarra.Marca}','{guitarra.Modelo}', '{Convert.ToInt32(guitarra.EsUsado)}','{(int)guitarra.Origen}', '{(int)EClasificacion.Cuerda}','{guitarra.Costo}', '{guitarra.PorcentajeGanancia}','{guitarra.CantidadDeCuerdas}', '{(int)guitarra.Tipo}')";

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
        /// Modifica una guitarra en la bsd
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public bool ModificarGuitarra(Guitarra guitarra)
        {
            bool rta = true;

            try
            {
                this.comando.Parameters.AddWithValue("@codigo", guitarra.Codigo);
                this.comando.Parameters.AddWithValue("@marca", guitarra.Marca);
                this.comando.Parameters.AddWithValue("@modelo", guitarra.Modelo);
                this.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(guitarra.EsUsado));
                this.comando.Parameters.AddWithValue("@origen", (int)guitarra.Origen);
                this.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Cuerda);
                this.comando.Parameters.AddWithValue("@costo", guitarra.Costo);
                this.comando.Parameters.AddWithValue("@porcentajeGanancia", guitarra.PorcentajeGanancia);
                this.comando.Parameters.AddWithValue("@cantidadDeCuerdas", guitarra.CantidadDeCuerdas);
                this.comando.Parameters.AddWithValue("@tipo", (int)guitarra.Tipo);

                string sql = $"UPDATE tabla_stockGuitarra SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, cantidadDeCuerdas = @cantidadDeCuerdas, tipo = @tipo WHERE codigo = @codigo";



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
        /// Elimina una guitarra de la bsd
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public bool BorrarGuitarra(Guitarra guitarra)
        {
            bool rta = true;

            try
            {
                string texto = $"DELETE FROM tabla_stockGuitarra where codigo = {guitarra.Codigo}";
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
