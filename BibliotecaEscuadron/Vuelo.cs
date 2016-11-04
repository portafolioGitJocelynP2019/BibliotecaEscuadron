using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    class Vuelo
    {
        public int id_vuelo { get; set; }
        public int nro_vuelo { get; set; }
        public string condicion { get; set; }
        public int total_tv { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public string fecha { get; set; }
        public int id_mision { get; set; }
    }
}
