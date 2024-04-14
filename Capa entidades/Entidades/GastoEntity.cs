using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidades.Entidades
{
    public class GastoEntity : BusisnessClass
    {

        private string _Descripcion;
        private float _Importe;
        private DateTime fecha;

        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public float Importe { get => _Importe; set => _Importe = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
