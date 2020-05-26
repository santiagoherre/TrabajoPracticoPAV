using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juventus.Usuarios
{
    public class Usuario
    {
        private int id;
        private string NombreUsu;
        private string Pass;

        public Usuario() {}

        public Usuario(string nombreUsuario, string password)
        {
            NombreUsu = nombreUsuario;
            Pass = password;
        }

        public Usuario(int id, string nombreUsu, string pass)
        {
            this.id = id;
            NombreUsu = nombreUsu;
            Pass = pass;
        }

        public string NombreDeUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }

        public string Password
        {
            get => Pass;
            set => Pass = value;
        }
        public int Id { get => id; set => id = value; }
    }
}