using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    
    public class Componente {

        public int id_componente { get; set; }
        public string nombre { get; set; }
        public int cant_horas { get; set; }
        public int id_padre_componente { get; set; }
        public int cantidad_horas_fabricante { get; set; }
        public int cantidad_dias_fabricante { get; set; }
        public int id_tipo_componente { get; set; }
        public int especialista_id_mec_compo { get; set; }
        public int estructura_id { get; set; }

    }
}
