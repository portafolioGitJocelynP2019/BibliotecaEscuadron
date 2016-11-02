using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BibliotecaEscuadron
{
    public class ConsumeWebApi
    {
        public Boolean canLogin(String usuario, String password) { 
            var client = new RestClient("https://database-clportafoliotrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuario/login/{user}/{pwd}", Method.GET);
            request.AddUrlSegment("user", usuario); // adds to GET or URL querystring based on Method
            request.AddUrlSegment("pwd", password); 
            var response = client.Execute<RespuestaLogin>(request);
            return response.Data.Cantidad > 0;
        }

        public Boolean nuevoVuelo(int nro_vuelo, String condicion, int total_tv, String origen, String destino, String fecha, int id_mision)
        {
            var client = new RestClient("https://database-clportafoliotrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflight/vuelos/", Method.POST);
            request.AddParameter("nro_vuelo", nro_vuelo);
            request.AddParameter("condicion", condicion);
            request.AddParameter("total_tv", total_tv);
            request.AddParameter("origen", origen);
            request.AddParameter("destino", destino);
            request.AddParameter("fecha", fecha);
            request.AddParameter("id_mision", id_mision);
            var response = client.Execute<Vuelo>(request);
            return true;
        }
    }
}
