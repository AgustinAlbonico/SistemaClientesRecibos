using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidades.Entidades
{
    public class ReciboEntity : BusisnessClass
    {

        private string _Descripcion;
        private ClienteEntity _Cliente;
        private DateTime _FechaHoraEmision;
        private int _Mes;
        private int _Anio;
        private int _NroRecibo;
        private float _Importe;

        
        public ClienteEntity Cliente { get => _Cliente; set => _Cliente = value; }
        public DateTime FechaHoraEmision { get => _FechaHoraEmision; set => _FechaHoraEmision = value; }
        public int Mes { get => _Mes; set => _Mes = value; }
        public int Anio { get => _Anio; set => _Anio = value; }
        public int NroRecibo { get => _NroRecibo; set => _NroRecibo = value; }
        public float Importe { get => _Importe; set => _Importe = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }

        public ReciboEntity()
        {
            Cliente = new ClienteEntity();
        }
    }
}
