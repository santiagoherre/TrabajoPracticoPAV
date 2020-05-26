using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Vehiculo
{
    public class Vehiculo
    {
        private string patente;
        private int kilometraje;
        private string fechaDeCompra;

        public Vehiculo()
        {
        }

        public Vehiculo(string patente, int kilometraje, string fechaDeCompra)
        {

            this.patente = patente;
            this.kilometraje = kilometraje;
            this.fechaDeCompra = fechaDeCompra;
        }

        public string Patente { get => patente; set => patente = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public string FechaDeCompra { get => fechaDeCompra; set => fechaDeCompra = value; }
    }
}
