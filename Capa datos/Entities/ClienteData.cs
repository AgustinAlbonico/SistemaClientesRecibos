using Capa_datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_entidades.Entidades;

namespace Capa_datos.Entities
{
    public class ClienteData : Connection
    {
        //Declaracion variables
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable dt = new DataTable();

        public DataTable getClientes()
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "SELECT * FROM clientes ORDER BY nombre";
                dr = cmd.ExecuteReader();
                dt.Load(dr);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                cmd.Connection = this.CloseConnection();
            }
            return dt;
        }

        public void eliminarCliente(int id_cliente)
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "DELETE FROM recibos WHERE id_cliente = @id_cliente";
                cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.ExecuteNonQuery();
                //cmd.Parameters.Clear();

                cmd.CommandText = "DELETE FROM clientes WHERE id_cliente = @id_cliente";
                //cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void modificarCliente(ClienteEntity p)
        {
            try
            {
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "UPDATE clientes SET " +
                    "nombre = @nombre, direccion = @direccion, localidad = @localidad, cod_postal = @cod_postal, " +
                    "telefono = @telefono, cuit = @cuit, categoria = @categoria, provincia = @provincia " +
                    "WHERE id_cliente = @id_cliente";
                cmd.Parameters.AddWithValue("@nombre", p.Nombre != null ? (object)p.Nombre : DBNull.Value);
                cmd.Parameters.AddWithValue("@direccion", p.Direccion != null ? (object)p.Direccion : DBNull.Value);
                cmd.Parameters.AddWithValue("@localidad", p.Localidad != null ? (object)p.Localidad : DBNull.Value);
                cmd.Parameters.AddWithValue("@cod_postal", p.CodPostal != null ? (object)p.CodPostal : DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono != null ? (object)p.Telefono : DBNull.Value);
                cmd.Parameters.AddWithValue("@cuit", p.Cuit != null ? (object)p.Cuit : DBNull.Value);
                cmd.Parameters.AddWithValue("@categoria", (char)p.Categoria);
                cmd.Parameters.AddWithValue("@provincia", p.Provincia != null ? (object)p.Provincia : DBNull.Value);
                cmd.Parameters.AddWithValue("@id_cliente", p.ID);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
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
        }

        public void crearCliente(ClienteEntity p)
        {
            try
            {
                p.toStringMio();
                cmd.Connection = this.OpenConnection();
                cmd.CommandText = "INSERT INTO clientes(nombre, direccion, localidad, cod_postal, telefono, cuit, categoria, provincia) VALUES" +
                    "(@nombre, @direccion, @localidad, @cod_postal," +
                    "@telefono, @cuit, @categoria, @provincia)";
                cmd.Parameters.AddWithValue("@nombre", p.Nombre != null ? (object)p.Nombre : DBNull.Value);
                cmd.Parameters.AddWithValue("@direccion", p.Direccion != null ? (object)p.Direccion : DBNull.Value);
                cmd.Parameters.AddWithValue("@localidad", p.Localidad != null ? (object)p.Localidad : DBNull.Value);
                cmd.Parameters.AddWithValue("@cod_postal", p.CodPostal != null ? (object)p.CodPostal : DBNull.Value);
                cmd.Parameters.AddWithValue("@telefono", p.Telefono != null ? (object)p.Telefono : DBNull.Value);
                cmd.Parameters.AddWithValue("@cuit", p.Cuit != null ? (object)p.Cuit : DBNull.Value);
                cmd.Parameters.AddWithValue("@categoria", (char)p.Categoria);
                cmd.Parameters.AddWithValue("@provincia", p.Provincia != null ? (object)p.Provincia : DBNull.Value);
                cmd.ExecuteNonQuery();
                //IMPORTANTE, SINO LOS PARAMS QUEDAN CACHEADOS Y DA ERROR
                cmd.Parameters.Clear();
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
        }
    }
}
