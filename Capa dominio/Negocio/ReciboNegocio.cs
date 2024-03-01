using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_datos.Entities;
using Capa_entidades.Entidades;

namespace Capa_negocio.Negocio
{
    public class ReciboNegocio
    {

        ReciboData rd = new ReciboData();

        //public DataTable getReciboFormulario(int nro_cliente, string desc, float importe, int mes, int anio)
        //{
        //    try
        //    {
        //        DataTable infoRecibo = rd.getReciboFormulario(nro_cliente, desc, importe, mes, anio);
        //        return infoRecibo;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public DataTable crearYDevolverRecibo(ReciboEntity re)
        {
            DataTable dataRecibo = new DataTable();
            try
            {
                dataRecibo = rd.getReciboFormulario(re.Cliente.ID, re.Descripcion, re.Importe, re.Mes, re.Anio);
            }catch(Exception ex)
            {
                throw ex;
            }

            return dataRecibo;
        }

        public DataTable recibosPorMesYAnio(int mes, int anio)
        {
            DataTable dataRecibos = new DataTable();
            try
            {
               dataRecibos = rd.recibosPorMesYAnio(mes, anio);
            } catch (Exception ex)
            {
                throw ex;
            }
            return dataRecibos;
        }

        public DataTable getRecibo(int id_recibo)
        {
            DataTable recibo = new DataTable();
            try
            {
                recibo = rd.getRecibo(id_recibo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return recibo;
        }
    }
}
