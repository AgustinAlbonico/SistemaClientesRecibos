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
        private SqlConnection con = new SqlConnection("Data Source=tcp:SERVIDOR\\SQLEXPRESS,47941;Initial Catalog=db_sistema_recibos;User ID=SistemaRecibos;Password=root;Encrypt=True;TrustServerCertificate=True");

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
