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
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
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
}
