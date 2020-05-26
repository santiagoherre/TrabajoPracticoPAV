using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Personas

{
    class Persona
    {
        private string nombre;
        private string apellido;
        private string correoElectronico;
        private DateTime fechaNacimiento;
        private int documento;
        private int idDocumento;
        private int idSexo;
        private string institucionAcademica;
        private int añoEscolar;
        private string direccion;
        private string telefono;
        // private int id_TipoRol;
        private int idGrupo;
        //private int idArea;
        //private int idCargoEnArea;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Documento { get => documento; set => documento = value; }
        public int IdDocumento { get => idDocumento; set => idDocumento = value; }
        public int IdSexo { get => idSexo; set => idSexo = value; }

        public string InstitucionAcademica { get => institucionAcademica; set => institucionAcademica = value; }
        public int AñoEscolar { get => añoEscolar; set => añoEscolar = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        //public int Id_TipoRol { get => id_TipoRol; set => id_TipoRol = value; }
        public int IdGrupo { get => idGrupo; set => idGrupo = value; }
        //public int IdArea { get => idArea; set => idArea = value; }
        // public int IdCargoEnArea { get => idCargoEnArea; set => idCargoEnArea = value; }

        public Persona(string nombre, string apellido, string correoElectronico, DateTime fechaNacimiento, int documento, int idDocumento, int idSexo, string institucionAcademica, int añoEscolar, string direccion, string telefono, int idGrupo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.fechaNacimiento = fechaNacimiento;
            this.documento = documento;
            this.idDocumento = idDocumento;
            this.idSexo = idSexo;

            this.institucionAcademica = institucionAcademica;
            this.añoEscolar = añoEscolar;
            this.direccion = direccion;
            this.telefono = telefono;
            // this.id_TipoRol = id_TipoRol;
            this.idGrupo = idGrupo;
            //this.idArea = idArea;
            //this.idCargoEnArea = idCargoEnArea;
        }

        public Persona()
        {
        }
    }


}
