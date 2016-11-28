using System;
using Newtonsoft.Json;

namespace BibliotecaEscuadron
{
    public class PlanMantenimiento
    {
        public String matriculaAeronave;
        public int cantidadHoras;
        public int horasAeronave;
        public int diasAeronave;
        public String fechaUltimoVuelo;

        [JsonProperty("matricula")]
        public String MatriculaAeronave
        {
            get
            {
                return matriculaAeronave;
            }
            set
            {
                matriculaAeronave = value;
            }
        }

        [JsonProperty("cantidad_horas")]
        public int CantidadHoras
        {
            get
            {
                return cantidadHoras;
            }
            set
            {
                cantidadHoras = value;
            }
        }

        [JsonProperty("horas")]
        public int HorasAeronave
        {
            get
            {
                return horasAeronave;
            }
            set
            {
                horasAeronave = value;
            }
        }

        [JsonProperty("dias")]
        public int DiasAeronave
        {
            get
            {
                return diasAeronave;
            }
            set
            {
                diasAeronave = value;
            }
        }

        [JsonProperty("ultimovuelo")]
        public String FechaUltimoVuelo
        {
            get
            {
                return fechaUltimoVuelo;
            }
            set
            {
                fechaUltimoVuelo = value;
            }
        }
    }
}
