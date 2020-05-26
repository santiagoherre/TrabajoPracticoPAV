using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.DOMINIO
{
    class ElemCocina
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int idTipoElemento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdTipoElemento { get => idTipoElemento; set => idTipoElemento = value; }
        public int Id { get => id; set => id = value; }

        public ElemCocina(string nombre, string descripcion, int idTipoElemento)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.idTipoElemento = idTipoElemento;
        }

        public ElemCocina(int id, string nombre, string descripcion, int idTipoElemento)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.idTipoElemento = idTipoElemento;
        }

        public ElemCocina()
        {
        }
    }
}
