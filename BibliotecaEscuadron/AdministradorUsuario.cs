using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class AdministradorUsuario
    {
        private String username; 
        private String password;
        private String nombre;
        private String apellido;
        private String email;
        private DateTime fecha_nacimiento;
        private String rut;
        private int licencia_piloto;
        private int tipoPerfil;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            {
                rut = value;
            }
        }

        public int Licencia_piloto
        {
            get
            {
                return licencia_piloto;
            }

            set
            {
                licencia_piloto = value;
            }
        }

        public int TipoPerfil
        {
            get
            {
                return tipoPerfil;
            }

            set
            {
                tipoPerfil = value;
            }
        }

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
