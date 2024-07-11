using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_datos
{
    public class Connection
    {
        private SqlConnection con = new SqlConnection("Data Source=26.151.152.96,1433\\SQLEXPRESS;Initial Catalog=db_sistema_recibos;User ID=sa;Password=root;Encrypt=True;TrustServerCertificate=True");
        protected SqlConnection OpenConnection()
        {
            if (con.State == ConnectionState.Closed) con.Open();
            return con;
        }

        protected SqlConnection CloseConnection()
        {
            if (con.State == ConnectionState.Open) con.Close();
            return con;
        }
    }
}
