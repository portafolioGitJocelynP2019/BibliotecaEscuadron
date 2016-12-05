using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class PlanVuelo
    {
        public int id_mision { get; set; }
        public string nombre { get; set; }
        public string etd { get; set; }
        public string qrf { get; set; }
        public string tipo_vuelo { get; set; }
        public string velocidad__crucero { get; set; }
        public string reglas_vuelo { get; set; }
        public string aerodromo_salida { get; set; }
        public string aerodromo_destino { get; set; }

        public PlanVuelo(int id_mision, string nombre, string etd, string qrf, string tipo_vuelo, string velocidad__crucero, string reglas_vuelo, string aerodromo_salida, string aerodromo_destino)
        {
            this.id_mision = id_mision;
            this.nombre = nombre;
            this.etd = etd;
            this.qrf = qrf;
            this.tipo_vuelo = tipo_vuelo;
            this.velocidad__crucero = velocidad__crucero;
            this.reglas_vuelo = reglas_vuelo;
            this.aerodromo_destino = aerodromo_destino;
            this.aerodromo_salida = aerodromo_salida;
        }

        public PlanVuelo()
        { }
    }
}
