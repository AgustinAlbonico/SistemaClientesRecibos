using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_datos.Entities;
using Capa_entidades.Entidades;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Capa_negocio.Negocio
{
    public class ClienteNegocio
    {
        ClienteData pData = new ClienteData();

        public DataTable GetClientes()
        {
            DataTable dt = new DataTable();
            dt = pData.getClientes();
            return dt;
        }

        public void EliminarCliente(string id_cliente)
        {
            int id = Int32.Parse(id_cliente);
            pData.eliminarCliente(id);
        }

        public void CrearCliente(string nombre, string direccion, string localidad, string cod_postal, string telefono, string cuit, string provincia, string categoria)
        {
            ClienteEntity p = new ClienteEntity();
            p.Nombre = nombre.ToUpper();
            p.Direccion = direccion.ToUpper();
            p.Localidad = localidad.ToUpper();
            p.CodPostal = cod_postal;
            p.Telefono = telefono.ToUpper();
            p.Cuit = convertirCuit(cuit);
            p.Provincia = provincia.ToUpper();
            switch (categoria)
            {
                case "Responsable inscripto":
                    p.Categoria = ClienteEntity.CategoriaCliente.ResponsableInscripto; break;
                case "Monotributo":
                    p.Categoria = ClienteEntity.CategoriaCliente.Monotributo; break;
                case "Exento":
                    p.Categoria = ClienteEntity.CategoriaCliente.Exento; break;
                case "Consumidor final":
                    p.Categoria = ClienteEntity.CategoriaCliente.ConsumidorFinal; break;
            }

            PropertyInfo[] lst = typeof(ClienteEntity).GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                if (oProperty.Name != "ID" && oProperty.Name != "Categoria")
                {
                    if ((string)oProperty.GetValue(p) == "")
                    {
                        oProperty.SetValue(p, null);
                    }
                }
            }
            try { pData.crearCliente(p); } catch (Exception ex) { throw ex; }

        }

        public void ModificarCliente(int id_cliente, string nombre, string direccion, string localidad, string cod_postal, string telefono, string cuit, string provincia, string categoria)
        {
            ClienteEntity p = new ClienteEntity();

            p.ID = id_cliente;
            p.Nombre = nombre.ToUpper();
            p.Direccion = direccion.ToUpper();
            p.Localidad = localidad.ToUpper();
            p.CodPostal = cod_postal;
            p.Telefono = telefono.ToUpper();
            p.Cuit = convertirCuit(cuit);
            p.Provincia = provincia.ToUpper();
            switch (categoria)
            {
                case "Responsable inscripto":
                    p.Categoria = ClienteEntity.CategoriaCliente.ResponsableInscripto; break;
                case "Monotributo":
                    p.Categoria = ClienteEntity.CategoriaCliente.Monotributo; break;
                case "Exento":
                    p.Categoria = ClienteEntity.CategoriaCliente.Exento; break;
                case "Consumidor final":
                    p.Categoria = ClienteEntity.CategoriaCliente.ConsumidorFinal; break;
            }

            PropertyInfo[] lst = typeof(ClienteEntity).GetProperties();
            foreach (PropertyInfo oProperty in lst)
            {
                if (oProperty.Name != "ID" && oProperty.Name != "Categoria")
                {
                    if ((string)oProperty.GetValue(p) == "-")
                    {
                        oProperty.SetValue(p, null);
                    }
                }
            }

            try
            {
                pData.modificarCliente(p);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string convertirCuit(string cuit)
        {
            string cuitConvertido = Regex.Replace(cuit, @"(\d{2})(\d{8})(\d{1})", "$1-$2-$3"); ;

            return cuitConvertido;
        }
    }
}
