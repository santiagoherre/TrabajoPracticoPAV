using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus
{
    class Motor
    {
        private string Fabricante;
        private string Modelo;
        private int IdtipoMotor;

        public Motor()
        {
        }

        public Motor(string fabricante, string modelo, int idtipoMotor)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            IdtipoMotor = idtipoMotor;
        }

        public string FabricanteMotor { get => Fabricante; set => Fabricante = value; }
        public string ModeloMotor { get => Modelo; set => Modelo = value; }
        public int IdtipoDeMotor { get => IdtipoMotor; set => IdtipoMotor = value; }
    }
}
