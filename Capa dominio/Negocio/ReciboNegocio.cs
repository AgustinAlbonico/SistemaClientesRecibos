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
                dataRecibo = rd.getReciboFormulario(re.Cliente.ID, re.Importe, re.LineaUno, re.MesLineaUno, re.AnioLineaUno, re.LineaDos, re.MesLineaDos, re.AnioLineaDos, re.LineaTres, re.MesLineaTres, re.AnioLineaTres);
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

        public DataTable detalleCajaPorDia(string fecha)
        {
            DataTable dataCaja = new DataTable();
            try
            {
                dataCaja = rd.detalleCajaPorDia(fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dataCaja;
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

        public void eliminarRecibo(int nro_comprobante)
        {
            try
            {
                rd.eliminarRecibo(nro_comprobante);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public float getSaldoPorMesAnio(int mes, int anio)
        {
            float saldo;
            try
            {
                saldo = rd.getSaldoPorMesAnio(mes, anio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saldo;
        }

        public float getSaldoPorDia(string fecha)
        {
            float saldo;
            try
            {
                saldo = rd.getSaldoPorFecha(fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return saldo;
        }
    }
}
