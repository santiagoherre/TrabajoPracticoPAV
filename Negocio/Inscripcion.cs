using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Negocio
{
    class Inscripcion
    {
        private int dni;
        private int idTipoDocumento;
        private DateTime fecha;
        private int idTipoActividad;

        public int Dni { get => dni; set => dni = value; }
        public int IdTipoDocumento { get => idTipoDocumento; set => idTipoDocumento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdTipoActividad { get => idTipoActividad; set => idTipoActividad = value; }

        public Inscripcion(int dni, int idTipoDocumento, DateTime feha, int idTipoActividad)
        {
            this.dni = dni;
            this.idTipoDocumento = idTipoDocumento;
            this.fecha = feha;
            this.idTipoActividad = idTipoActividad;
        }

        public Inscripcion()
        {
        }

    }
}
