using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus
{
    class Motor
    {
        private int Id;
        private string Fabricante;
        private string Modelo;
        private int IdTipoMotor;

        public Motor(int id, string fabricante, string modelo, int idTipoMotor)
        {
            Id = id;
            Fabricante = fabricante;
            Modelo = modelo;
            IdTipoMotor = idTipoMotor;
        
        }
        public int IdMotor
        {
            get => Id;
            set => Id = value;
        }
        public int FabricanteMotor
        {
            get => Fabricante;
            set => Fabricante = value;
        }
        public int ModeloMotor
        {
            get => Modelo;
            set => Modelo = value;
        }
        public int IdTipoDeMotor
        {
            get => IdTipoMotor;
            set => IdTipoMotor = value;
        }
       


    }
}
