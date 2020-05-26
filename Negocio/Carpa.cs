using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus
{
    class Carpa
    {
        private int id;
        private int idTipoCarpa;
        private int cantCaños;
        private int cantDormitorios;

        public int Id { get => id; set => id = value; }
        public int IdTipoCarpa { get => idTipoCarpa; set => idTipoCarpa = value; }
        public int CantCaños { get => cantCaños; set => cantCaños = value; }
        public int CantDormitorios { get => cantDormitorios; set => cantDormitorios = value; }

        public Carpa(int idTipoCarpa, int cantCaños, int cantDormitorios)
        {
            this.idTipoCarpa = idTipoCarpa;
            this.cantCaños = cantCaños;
            this.cantDormitorios = cantDormitorios;
        }

        public Carpa()
        {
        }
    }
}
