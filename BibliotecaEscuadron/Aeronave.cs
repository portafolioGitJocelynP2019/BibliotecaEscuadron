using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    class Aeronave
    {
        public int id_aeronave { get; set; }
        public int tipo { get; set; }
        public int cantidad_horas { get; set; }
        public string fecha_inspeccion { get; set; }
        public int ano_fabricacion { get; set; }
        public string fecha_dgac { get; set; }
        public string tipo_modelo { get; set; }
        public int capacidad { get; set; }
        public int hr_autonomia { get; set; }
        public string marca { get; set; }
        public string estado { get; set; }
        public string fecha_de_vencimiento { get; set; }
        public string matricula { get; set; }
    }
}
