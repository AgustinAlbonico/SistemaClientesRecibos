using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos.Entities
{
    public class GastoData : Connection
    {
        //Declaracion variables
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public void crearGasto(string descripcion, float importe, string fecha)
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "sp_CrearGasto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("desc", descripcion);
                cmd.Parameters.AddWithValue("importe", importe);
                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable ingresosEgresosPorDia(int mes, int anio)
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "sp_IngresosEgresosPorDia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mes_ingresado", mes);
                cmd.Parameters.AddWithValue("anio_ingresado", anio);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return dt;
        }
    }
}
