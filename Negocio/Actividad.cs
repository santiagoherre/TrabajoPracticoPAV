using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Actividades
{
    class Actividad
    {
        private int id;
        private string descripcion;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int idTipoActividad;
        private int idArea;
        private string patente;
        private int idGrupo;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int IdTipoActividad { get => idTipoActividad; set => idTipoActividad = value; }
        public int IdArea { get => idArea; set => idArea = value; }
        public string Patente { get => patente; set => patente = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }

        public Actividad(int id, string descripcion, DateTime fechaInicio, DateTime fechaFin, int idTipoActividad, int idArea, string patente, int idGrupo)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.idTipoActividad = idTipoActividad;
            this.idArea = idArea;
            this.patente = patente;
            this.idGrupo = idGrupo;
        }
    }
}
