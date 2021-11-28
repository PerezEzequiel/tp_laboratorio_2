using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Entidades
{
    public class ADOGuitarra : ADOStock
    {

        public ADOGuitarra() : base()
        {

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
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = texto;
                base.comando.Connection = base.conexion;

                base.conexion.Open();

                base.lector = comando.ExecuteReader();
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
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
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
                base.comando.CommandType = System.Data.CommandType.Text;
                base.comando.CommandText = $"SELECT * from tabla_stockGuitarra where codigo = {codigo}";
                base.comando.Connection = base.conexion;

                base.conexion.Open();
                base.lector = comando.ExecuteReader();

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
                if (base.conexion.State == System.Data.ConnectionState.Open)
                {
                    base.conexion.Close();
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
        /// Modifica una guitarra en la bsd
        /// </summary>
        /// <param name="guitarra"></param>
        /// <returns></returns>
        public bool ModificarGuitarra(Guitarra guitarra)
        {
            bool rta = true;

            try
            {
                base.comando.Parameters.AddWithValue("@codigo", guitarra.Codigo);
                base.comando.Parameters.AddWithValue("@marca", guitarra.Marca);
                base.comando.Parameters.AddWithValue("@modelo", guitarra.Modelo);
                base.comando.Parameters.AddWithValue("@esUsado", Convert.ToInt32(guitarra.EsUsado));
                base.comando.Parameters.AddWithValue("@origen", (int)guitarra.Origen);
                base.comando.Parameters.AddWithValue("@tipoInstrumento", (int)EClasificacion.Cuerda);
                base.comando.Parameters.AddWithValue("@costo", guitarra.Costo);
                base.comando.Parameters.AddWithValue("@porcentajeGanancia", guitarra.PorcentajeGanancia);
                base.comando.Parameters.AddWithValue("@cantidadDeCuerdas", guitarra.CantidadDeCuerdas);
                base.comando.Parameters.AddWithValue("@tipo", (int)guitarra.Tipo);

                string sql = $"UPDATE tabla_stockGuitarra SET  marca = @marca, modelo = @modelo, esUsado = @esUsado, origen = @origen, tipoInstrumento = @tipoInstrumento, costo = @costo, porcentajeGanancia = @porcentajeGanancia, cantidadDeCuerdas = @cantidadDeCuerdas, tipo = @tipo WHERE codigo = @codigo";



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
