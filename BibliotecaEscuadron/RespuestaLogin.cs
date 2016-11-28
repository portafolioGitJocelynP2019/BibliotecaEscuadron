using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class RespuestaLogin
    {
        private int cantidad;
        private int tipoPerfil;
        private int idUsuario;
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
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

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }
    }

    public class RespuestaInsert
    {
        private String iD;

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
    }

    public class RespuestaMantenimiento
    {
        private int idmantenimiento;

        public int idMantenimiento
        {
            get{return idmantenimiento;}
            set{idmantenimiento = value;}
        }
    }
}
