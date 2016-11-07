using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Globalization;

namespace BibliotecaEscuadron
{
    public class ConsumeWebApi
    {
        public Boolean canLogin(String usuario, String password)
        { 
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuario/login/{user}/{pwd}", Method.GET);
            request.AddUrlSegment("user", usuario); // adds to GET or URL querystring based on Method
            request.AddUrlSegment("pwd", password); 
            var response = client.Execute<RespuestaLogin>(request);
            return response.Data.Cantidad > 0;
        }
        public Boolean nuevoVuelo(int nro_vuelo, String condicion, int total_tv, String origen, String destino, String fecha, int id_mision)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/vuelos/", Method.POST);
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
        public Boolean createUser(AdministradorUsuario registroUsuario)
        {

            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios/", Method.POST);
            request.AddParameter("apellido", registroUsuario.Apellido);
            request.AddParameter("email", registroUsuario.Email);
            request.AddParameter("fecha_Nacimiento", registroUsuario.Fecha_nacimiento.ToString("dd-MMM-yy", CultureInfo.CreateSpecificCulture("en-US")));
            request.AddParameter("licencia_piloto", registroUsuario.Licencia_piloto);
            request.AddParameter("nombre", registroUsuario.Nombre);
            request.AddParameter("password", registroUsuario.Password);
            request.AddParameter("rut", registroUsuario.Rut);
            request.AddParameter("tipoPerfil", registroUsuario.TipoPerfil);
            request.AddParameter("username", registroUsuario.Username);
            var response = client.Execute<RespuestaInsert>(request);
            if (response.ErrorException != null)
            {
                Console.WriteLine("error :", response.ErrorException.Message);

                return false;
            }
            return response.Data.ID != null;

        }

        public Boolean crearPlan(string nombre, string etd, string qrf, string tipo_aeronave, string velocidad__crucero, string reglas_vuelo)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/plan_vuelo/", Method.POST);
            request.AddParameter("nombre", nombre);
            request.AddParameter("etd", etd);
            request.AddParameter("qrf", qrf);
            request.AddParameter("tipo_aeronave", tipo_aeronave);
            request.AddParameter("velocidad__crucero", velocidad__crucero);
            request.AddParameter("reglas_vuelo", reglas_vuelo);
            var response = client.Execute<PlanVuelo>(request);
            if (response.ErrorException != null)
            {
                Console.WriteLine("error :", response.ErrorException.Message);

                return false;
            }
            return response.Data.id_mision != null;
        }
    }
}
