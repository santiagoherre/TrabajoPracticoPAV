using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.ElementosElectricos
{
    public class ElementoElectrico
    {
        private int id;
        private string nombre;
        private int tipo;

        public ElementoElectrico()
        {
        }

        public ElementoElectrico(int id, string nombre, int tipo)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }
    }
}
