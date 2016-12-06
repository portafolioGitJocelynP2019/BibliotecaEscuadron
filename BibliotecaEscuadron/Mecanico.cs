using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class Mecanico
    {
        public int ID_MECANICO { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DESCRIPCION { get; set; }
        public int ID_TIPO { get; set; }
        public int ESPECIALISTA_ID_MEC_COMPO { get; set; }
        public int MANTENCION_ID_MECAN_MANT { get; set; }
    }
       
}
