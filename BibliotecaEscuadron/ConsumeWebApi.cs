using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Globalization;
using BibliotecaEscuadron.VO;

namespace BibliotecaEscuadron
{
    public class ConsumeWebApi
    {

        public Boolean ConsultarMantenimiento(int idmantenimiento)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/mantenimiento/{idmantenimiento}", Method.GET);
            request.AddParameter("idmantenimiento", idmantenimiento);
            var response = client.Execute<RespuestaMantenimiento>(request);
            return true;
        }
        //verificacion de Login     
        public Boolean canLogin(String usuario, String password)
        {
            //Verifica el user y pass para iniciar sesion.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuario/login/{user}/{pwd}", Method.GET);
            request.AddUrlSegment("user", usuario); // adds to GET or URL querystring based on Method
            request.AddUrlSegment("pwd", password);
            try
            {
                var response = client.Execute<RespuestaLogin>(request);

                return response.Data.Cantidad > 0;
            }
            catch (NullReferenceException e)
            {

                throw new Exception("Error al ingresar user y password, Intente nuevamente",e);
            } 
           
           
        }

        //*************Administracion de usuario***************************//        
                
            
        public ListPerfil getPerfilesUsuario()
        {
            //Carga el combo para mostrar el perfil de usuario,  en administracion usuario..
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/perfilusuario", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute<ListPerfil>(request);
            return (ListPerfil) response.Data;
        }
        public Boolean existeUser(String user)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/existeUsuario/{user}", Method.GET);
            request.AddUrlSegment("user", user);
            var response = client.Execute<RespuestaLogin>(request);
            return response.Data.Cantidad > 0;
        }
        public UsuariosResponse getUsuarios()
        {
            // en administracion usuario.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute<UsuariosResponse>(request);
            return (UsuariosResponse)response.Data;
        }

        public UsuarioVO getUsuario(String id)
        {
            //busca por id usuario.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios/{id}", Method.GET);
            request.AddUrlSegment("id", id); // adds to GET or URL querystring based on Method
            var response = client.Execute<UsuarioVO>(request);
            return response.Data;
        }
        public List<PilotoVO> getPilotos()
        {
            //Carga el combo para mostrar el pilotos, en administracion usuario.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/piloto", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute<ListaPilotos>(request);
            ListaPilotos lista = (ListaPilotos)response.Data;
            List<PilotoVO> listPilotos = lista.items;
            foreach (var item in listPilotos)
            {
                UsuarioVO usuario = getUsuario(item.id_usuario.ToString());
                item.nombre = String.Concat(String.Concat(usuario.nombre," "),usuario.apellido);
            }
            return listPilotos;
        }
        public List<PilotoVO> getPilotosCombo()
        {
            //Carga el combo para mostrar el pilotos, en administracion usuario.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/pilotosCombo", Method.GET);
            request.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            var response = client.Execute<ListaPilotos>(request);
            ListaPilotos lista = (ListaPilotos)response.Data;
            return lista.items;
        }
        public Boolean updateUser(AdministradorUsuario registroUsuario, int id)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios/{id}", Method.PUT);
            request.AddHeader("Content-type", "application/json");
            request.AddUrlSegment("id",Convert.ToString( id));
            request.AddJsonBody(new { nombre=registroUsuario.Nombre,apellido=registroUsuario.Apellido,email=registroUsuario.Email,
                                      fecha_Nacimiento= registroUsuario.Fecha_nacimiento.ToString("dd-MMM-yy", CultureInfo.CreateSpecificCulture("en-US")),
                                      licencia_piloto=registroUsuario.Licencia_piloto,password=registroUsuario.Password,rut=registroUsuario.Rut,
                                      tipoPerfil=registroUsuario.TipoPerfil,username=registroUsuario.Username
            });
            var response = client.Execute<RespuestaInsert>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;

        }
        public int createUser(AdministradorUsuario registroUsuario)
        {
            //creacion de usuario.
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

                return 0;
            }
            return int.Parse(response.Data.ID);

        }

        public Boolean deleteUser(int id)
        {
            //Elimina usuarios.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/usuarios/{id}", Method.DELETE);
            request.AddUrlSegment("id",Convert.ToString( id)); // adds to GET or URL querystring based on Method
            var response = client.Execute<RespuestaLogin>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                return true;
            else
                return false;

        }
        public PilotoVO getPilotoxIdUsuario(int idUsuario)
        {
            //busca piloto por idUsuario.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/piloto/{idUsuario}", Method.GET);
            request.AddUrlSegment("idUsuario",Convert.ToString(idUsuario)); // adds to GET or URL querystring based on Method
            var response = client.Execute<PilotoVO>(request);
            return response.Data;
        }
        //-------------------------***********FIN ADMINISTRACION USUARIO********************------------------------------------------------//

        public Boolean deletePiloto(int id)
        {
            //Elimina usuarios.
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/pilots/{id_piloto}", Method.DELETE);
            request.AddUrlSegment("id_piloto", Convert.ToString(id)); // adds to GET or URL querystring based on Method
            var response = client.Execute<RespuestaLogin>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                return true;
            else
                return false;

        }
        public Boolean nuevoAeronave(int tipo, int cantidad_horas, String fecha_inspeccion, int ano_fabricacion, String fecha_dgac, String tipo_modelo, int capacidad, int hr_autonomia, String marca, String estado, String fecha_de_vencimiento, String matricula)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/aeronave/", Method.POST);
            request.AddParameter("tipo", tipo);
            request.AddParameter("cantidad_horas", cantidad_horas);
            request.AddParameter("fecha_inspeccion", fecha_inspeccion);
            request.AddParameter("ano_fabricacion", ano_fabricacion);
            request.AddParameter("fecha_dgac", fecha_dgac);
            request.AddParameter("tipo_modelo", tipo_modelo);
            request.AddParameter("capacidad", capacidad);
            request.AddParameter("hr_autonomia", hr_autonomia);
            request.AddParameter("marca", marca);
            request.AddParameter("estado", estado);
            request.AddParameter("fecha_de_vencimiento", fecha_de_vencimiento);
            request.AddParameter("matricula", matricula);
            var response = client.Execute<Aeronave>(request);
            return true;
        }

        public Boolean nuevoPiloto(String fecha_vencimientomae, int hora_total_vuelo, int id_usuario)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/piloto/", Method.POST);
            request.AddParameter("fecha_vencimientomae", fecha_vencimientomae);
            request.AddParameter("hora_total_vuelo", hora_total_vuelo);
            request.AddParameter("id_usuario", id_usuario);
            var response = client.Execute<Piloto>(request);
            return true;
        }

        public Boolean nuevoVuelo(int nro_vuelo, String condicion, int total_tv, String fecha, int id_mision, int aeronave)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/vuelos/", Method.POST);
            request.AddParameter("nro_vuelo", nro_vuelo);
            request.AddParameter("condicion", condicion);
            request.AddParameter("total_tv", total_tv);
            request.AddParameter("fecha", fecha);
            request.AddParameter("id_mision", id_mision);
            request.AddParameter("aeronave", aeronave);
            var response = client.Execute<Vuelo>(request);
            return true;
        }

        public Boolean crearPlan(string nombre, string etd, string qrf, string tipo_vuelo, string velocidad__crucero, string reglas_vuelo)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/plan_vuelo/", Method.POST);
            request.AddParameter("nombre", nombre);
            request.AddParameter("etd", etd);
            request.AddParameter("qrf", qrf);
            request.AddParameter("tipo_vuelo", tipo_vuelo);
            request.AddParameter("velocidad__crucero", velocidad__crucero);
            request.AddParameter("reglas_vuelo", reglas_vuelo);
            var response = client.Execute<PlanVuelo>(request);
            return true;
        }

        

        public Boolean nuevoComponente(string nombre_componente, int cantidad_horasC, int id_padreComp, int cantidad_horasFab, int cantidad_diasFab, int id_tipoComponente, int id_especialista, int id_estructura)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/componente/", Method.POST);

            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(new
            {
                nombre = nombre_componente,
                cant_horas = cantidad_horasC,
                id_padre_componente = id_padreComp,
                cantidad_horas_fabricante = cantidad_horasFab,
                cantidad_dias_fabricante = cantidad_diasFab,
                id_tipo_componente = id_tipoComponente,
                especialista_id_mec_compo = id_especialista,
                estructura_id = id_estructura
            });

            var response = client.Execute<Componente>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;
        }

        public Boolean editarComponente(string nombre_componente, int cantidad_horasC, int id_padreComp, int cantidad_horasFab, int cantidad_diasFab, int id_tipoComponente, int id_especialista, int id_estructura, int idComponente)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/componente/" + idComponente, Method.PUT);

            Componente componente = new Componente();
            componente.nombre = nombre_componente;
            componente.cant_horas = cantidad_horasC;
            componente.id_padre_componente = id_padreComp;
            componente.cantidad_horas_fabricante = cantidad_horasFab;
            componente.cantidad_dias_fabricante = cantidad_diasFab;
            componente.especialista_id_mec_compo = id_especialista;
            componente.id_tipo_componente = id_tipoComponente;
            componente.estructura_id = id_estructura;
            request.AddHeader("Content-type", "application/json");

            request.AddJsonBody(new
            {
                nombre = nombre_componente,
                cant_horas = cantidad_horasC,
                id_padre_componente = id_padreComp,
                cantidad_horas_fabricante = cantidad_horasFab,
                cantidad_dias_fabricante = cantidad_diasFab,
                id_tipo_componente = id_tipoComponente,
                especialista_id_mec_compo = id_especialista,
                estructura_id = id_estructura
            });

            var response = client.Execute<Componente>(request);
            return true;
        }

        /// <summary>
        /// Identificador del componente a eliminar
        /// </summary>
        /// <param name="idComponente"></param>       
        public Boolean eliminarComponente(int idComponente)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            var request = new RestRequest("/apex/hawkflying/eliminarComponente", Method.PUT);

            request.AddJsonBody(new { id = idComponente });

            var response = client.Execute<Componente>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return true;
            else
                return false;

        }

        public ComponenteResponseList buscarComponente(string nombre_componente)
        {
            var client = new RestClient("https://database-clportafoliootrial.db.us2.oraclecloudapps.com");
            string service = "/apex/hawkflying/buscarComponente/" + nombre_componente;
            var request = new RestRequest(service, Method.GET);

            var response = client.Execute<ComponenteResponseList>(request);
            return (ComponenteResponseList)response.Data;
        }

    }
}
