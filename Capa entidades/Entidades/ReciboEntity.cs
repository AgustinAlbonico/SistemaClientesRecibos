using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidades.Entidades
{
    public class ReciboEntity : BusisnessClass
    {

        private string _LineaUno;
        private string _LineaDos;
        private string _LineaTres;
        private ClienteEntity _Cliente;
        private DateTime _FechaHoraEmision;
        private int _MesLineaUno;
        private int _MesLineaDos;
        private int _MesLineaTres;
        private int _AnioLineaUno;
        private int _AnioLineaDos;
        private int _AnioLineaTres;
        private int _NroRecibo;
        private float _Importe;

        
        public ClienteEntity Cliente { get => _Cliente; set => _Cliente = value; }
        public DateTime FechaHoraEmision { get => _FechaHoraEmision; set => _FechaHoraEmision = value; }
        public int NroRecibo { get => _NroRecibo; set => _NroRecibo = value; }
        public float Importe { get => _Importe; set => _Importe = value; }
        public string LineaUno { get => _LineaUno; set => _LineaUno = value; }
        public string LineaDos { get => _LineaDos; set => _LineaDos = value; }
        public string LineaTres { get => _LineaTres; set => _LineaTres = value; }
        public int MesLineaUno { get => _MesLineaUno; set => _MesLineaUno = value; }
        public int MesLineaDos { get => _MesLineaDos; set => _MesLineaDos = value; }
        public int MesLineaTres { get => _MesLineaTres; set => _MesLineaTres = value; }
        public int AnioLineaUno { get => _AnioLineaUno; set => _AnioLineaUno = value; }
        public int AnioLineaDos { get => _AnioLineaDos; set => _AnioLineaDos = value; }
        public int AnioLineaTres { get => _AnioLineaTres; set => _AnioLineaTres = value; }

        public ReciboEntity()
        {
            Cliente = new ClienteEntity();
        }
    }
}
