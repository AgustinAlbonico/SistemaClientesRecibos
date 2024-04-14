﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_datos.Entities
{
    public class ReciboData : Connection
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable getReciboFormulario(int id_cliente, string lineaUno, float importe, int mes, int anio)
        {
            try
            {
                Console.WriteLine(lineaUno, importe, mes, anio, id_cliente);

                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "sp_CrearReciboNuevo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id_cliente", id_cliente);
                cmd.Parameters.AddWithValue("desc", lineaUno);
                cmd.Parameters.AddWithValue("importe", importe);
                cmd.Parameters.AddWithValue("mes", mes);
                cmd.Parameters.AddWithValue("anio", anio);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "sp_BuscarUltimoRecibo";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return dt;
        }

        public DataTable recibosPorMesYAnio(int mes, int anio)
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "sp_RecibosPorMesYAnio";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("mes", mes);
                cmd.Parameters.AddWithValue("anio", anio);
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return dt;
        }

        public DataTable getRecibo(int id_recibo)
        {
            DataTable recibo = new DataTable();
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "SELECT * FROM recibos r INNER JOIN clientes c ON c.id_cliente = r.id_cliente WHERE r.id_recibo = @id_recibo";
                cmd.Parameters.AddWithValue("id_recibo", id_recibo);
                dr = cmd.ExecuteReader();
                recibo.Load(dr);
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
            return recibo;
        }

        //public DataTable getReciboFormulario2(int nro_cliente, string desc, float importe, int mes, int anio)
        //{
        //    DataTable dta = new DataTable();
        //    try
        //    {
        //        SqlDataAdapter sqlDa = new SqlDataAdapter("sp_CrearReciboNuevo", this.OpenConnection());

        //        sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        sqlDa.SelectCommand.Parameters.AddWithValue("nro_cliente", nro_cliente);
        //        sqlDa.SelectCommand.Parameters.AddWithValue("desc", desc);
        //        sqlDa.SelectCommand.Parameters.AddWithValue("importe", importe);
        //        sqlDa.SelectCommand.Parameters.AddWithValue("mes", mes);
        //        sqlDa.SelectCommand.Parameters.AddWithValue("anio", anio);
        //        sqlDa.Fill(dta);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        throw ex;
        //    }
        //    finally
        //    {
        //        this.CloseConnection();
        //    }
        //    return dta;
        //}

    }
}
