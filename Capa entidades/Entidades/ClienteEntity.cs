using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidades.Entidades
{
    public class ClienteEntity : BusisnessClass
    {
        private string _Nombre;
        private string _Direccion;
        private string _Localidad;
        private string _CodPostal;
        private string _Telefono;
        private string _Cuit;
        private CategoriaCliente _Categoria;
        private string _Provincia;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Localidad { get => _Localidad; set => _Localidad = value; }
        public string CodPostal { get => _CodPostal; set => _CodPostal = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Cuit { get => _Cuit; set => _Cuit = value; }
        public string Provincia { get => _Provincia; set => _Provincia = value; }
        public CategoriaCliente Categoria { get => _Categoria; set => _Categoria = value; }

        public enum CategoriaCliente
        {
            Monotributo = 'M',
            ResponsableInscripto = 'R',
            Exento = 'E',
            ConsumidorFinal = 'C'
        }

        public void toStringMio()
        {
            Console.WriteLine("ID: " + this.ID + ", Nombre: " + this.Nombre + ", Direccion: " + this.Direccion + ", Localidad: " + this.Localidad +
                ", Cod. postal: " + this.CodPostal + ", Telefono: " + this.Telefono + ", Cuit: " + this.Cuit + ", Provincia: " + this.Provincia +
                ", Categoria: " + this.Categoria);
        }
    }
}
