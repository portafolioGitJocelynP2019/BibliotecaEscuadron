using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron.VO
{
    public class PerfilVO
    {
        public int id_perfil { get; set; }
        public string perfil { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is PerfilVO)
            {
                return ((obj as PerfilVO).id_perfil == this.id_perfil);
            }
            else { return false; }
        }
    }
    public class ListPerfil
    {
        public List<PerfilVO> items { get; set; }
    }
}
