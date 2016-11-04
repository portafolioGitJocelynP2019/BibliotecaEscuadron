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
        public Boolean canLogin(String usuario, String password)
        { 
            var client = new RestClient("https://database-clportafoliotrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuario/login/{user}/{pwd}", Method.GET);
            request.AddUrlSegment("user", usuario); // adds to GET or URL querystring based on Method
            request.AddUrlSegment("pwd", password); 
            var response = client.Execute<RespuestaLogin>(request);
            return response.Data.Cantidad > 0;
        }


        public Boolean createUser(AdministradorUsuario registroUsuario)
        {

            var client = new RestClient("https://database-clportafoliotrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios/", Method.POST);
            request.AddJsonBody(registroUsuario);
            var response = client.Execute<RespuestaInsert>(request);
            if (response.ErrorException != null)
            {
                Console.WriteLine("error :", response.ErrorException.Message);
           
                return false;
            }
            return response.Data.ID!=null;
           
        }
    }
}
