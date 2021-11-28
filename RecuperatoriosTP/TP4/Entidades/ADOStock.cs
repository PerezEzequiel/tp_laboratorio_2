using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class ADOStock
    {
        protected static string stringConexion;
        protected SqlConnection conexion;
        protected SqlCommand comando;
        protected SqlDataReader lector;

        static ADOStock()
        {
            ADOStock.stringConexion = @"Server=LAPTOP-JCK5KOU2;Initial Catalog=bd-local; Integrated Security=true";
        }
        public ADOStock()
        {
            this.conexion = new SqlConnection(ADOStock.stringConexion);
            this.comando = new SqlCommand();
        }

    }
}
