using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    class PlanVuelo
    {
        public int id_mision { get; set; }
        public string nombre { get; set; }
        public string etd { get; set; }
        public string qrf { get; set; }
        public string tipo_aeronave { get; set; }
        public string velocidad__crucero { get; set; }
        public string reglas_vuelo { get; set; }

        public PlanVuelo(int id_mision, string nombre, string etd, string qrf, string tipo_aeronave, string velocidad__crucero, string reglas_vuelo)
        {
            this.id_mision = id_mision;
            this.nombre = nombre;
            this.etd = etd;
            this.qrf = qrf;
            this.tipo_aeronave = tipo_aeronave;
            this.velocidad__crucero = velocidad__crucero;
            this.reglas_vuelo = reglas_vuelo;
        }

        public PlanVuelo()
        { }
    }
}
