using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron
{
    public class correoJson
    {
        [JsonProperty("email")]
        public Correo Correo { get; set; }
    }

    public class Correo
    {

        public String correoPiloto;

        [JsonProperty("email")]
        public String CorreoPiloto
        {
            get
            {
                return correoPiloto;
            }
            set
            {
                correoPiloto = value;
            }
        }
    }
}
