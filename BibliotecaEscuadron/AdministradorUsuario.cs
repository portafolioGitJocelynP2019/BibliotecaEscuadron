using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class AdministradorUsuario
    {
        private String username { get; set; }
        private String password { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String email { get; set; }
        private DateTime fecha_nacimiento { get; set; }
        private String rut { get; set; }
        private int licencia_piloto { get; set; }
        private int tipoPerfil { get; set; }

        public AdministradorUsuario(string username, string password, string nombre, string apellido, string email, DateTime fecha_nacimiento, string rut, int licencia_piloto, int tipoPerfil)
        {
            this.username = username;
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.fecha_nacimiento = fecha_nacimiento;
            this.rut = rut;
            this.licencia_piloto = licencia_piloto;
            this.tipoPerfil = tipoPerfil;
        }

        public AdministradorUsuario()
        { }

    }

}
