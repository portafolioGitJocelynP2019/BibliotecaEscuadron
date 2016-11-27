using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class Mantenimiento
    {
        public int idMantenimiento;
        public int idAeronave;
        public DateTime fechaMantenimiento;
        public String tipoMantenimiento;
        public DateTime fechaFabricante;
        public String matricula;
        public DateTime fechaDGAC;
        public DateTime fechaVencimiento;
        public String rutMecanico;
        public int idComponente;
        public String nombreComponente;
        public int cantHoras;
        public int idPadreComponente;
        public int idTipoComponente;

        [JsonProperty("id_mantenimientoaero")]
        public int IdMantenimiento
        {
            get
            {
                return idMantenimiento;
            }
            set
            {
                idMantenimiento = value;
            }
        }

        [JsonProperty("id_aeronave")]
        public int IdAeronave
        {
            get
            {
                return idAeronave;
            }
            set
            {
                idAeronave = value;
            }
        }

        [JsonProperty("fecha")]
        public DateTime FechaMantenimiento
        {
            get
            {
                return fechaMantenimiento;
            }
            set
            {
                fechaMantenimiento = value;
            }
        }

        [JsonProperty("tipo_mantenimiento")]
        public String TipoMantenimiento
        {
            get
            {
                return tipoMantenimiento;
            }
            set
            {
                tipoMantenimiento = value;
            }
        }

        [JsonProperty("fecha_fabricante")]
        public DateTime FechaFabricante
        {
            get
            {
                return fechaFabricante;
            }
            set
            {
                fechaFabricante = value;
            }
        }

        //[JsonProperty("matricula")]
        public String Matricula
        {
            get
            {
                return matricula;
            }
            set
            {
                matricula = value;
            }
        }

        [JsonProperty("fecha_dgac")]
        public DateTime FechaDGAC
        {
            get
            {
                return fechaDGAC;
            }
            set
            {
                fechaDGAC = value;
            }
        }

        [JsonProperty("fecha_de_vencimiento")]
        public DateTime FechaVencimiento
        {
            get
            {
                return fechaVencimiento;
            }
            set
            {
                fechaVencimiento = value;
            }
        }

        [JsonProperty("rut")]
        public String RutMecanico
        {
            get
            {
                return rutMecanico;
            }
            set
            {
                rutMecanico = value;
            }
        }

        [JsonProperty("id_componente")]
        public int IdComponente
        {
            get
            {
                return idComponente;
            }
            set
            {
                idComponente = value;
            }
        }

        [JsonProperty("nombre")]
        public String NombreComponente
        {
            get
            {
                return nombreComponente;
            }
            set
            {
                nombreComponente = value;
            }
        }

        [JsonProperty("cant_horas")]
        public int Canthoras
        {
            get
            {
                return cantHoras;
            }
            set
            {
                cantHoras = value;
            }
        }

        [JsonProperty("ID_PADRE_COMPONENTE")]
        public int Idpadrecomponente
        {
            get
            {
                return idPadreComponente;
            }
            set
            {
                idPadreComponente = value;
            }
        }

        [JsonProperty("ID_TIPO_COMPONENTE")]
        public int Idtipocomponente
        {
            get
            {
                return idTipoComponente;
            }
            set
            {
                idTipoComponente = value;
            }
        }
    }
}
