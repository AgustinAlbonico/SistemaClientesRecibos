using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_datos.Entities;
using Capa_entidades.Entidades;
using System.Data;

namespace Capa_dominio.Negocio
{
    public class GastoNegocio
    {
        GastoData gd = new GastoData();

        public void crearGasto(GastoEntity gasto)
        {
            try
            {
                gd.crearGasto(gasto.Descripcion, gasto.Importe, gasto.Fecha.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable ingresosEgresosPorDia(int mes, int anio)
        {
            try
            {
                return gd.ingresosEgresosPorDia(mes, anio);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
