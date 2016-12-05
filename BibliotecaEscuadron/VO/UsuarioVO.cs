using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron.VO
{
    public class UsuarioVO
    {
        public int id_usuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string fecha_nac { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string rut { get; set; }
        public int instructor { get; set; }
        public int tipoperfil { get; set; }
    }
    public class UsuariosResponse
    {
        public List<UsuarioVO> items { get; set; }
    }
}
