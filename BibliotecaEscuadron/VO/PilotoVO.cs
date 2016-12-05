using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaEscuadron.VO
{
    public class PilotoVO
    {
        public int id_piloto { get; set; }
        public string fecha_vencimientomae { get; set; }
        public int hora_total_vuelo { get; set; }
        public int id_usuario { get; set; }
        public string nombre { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is PilotoVO)
            {
                return ((obj as PilotoVO).id_piloto == this.id_piloto);
            }else { return false; }
        }

    }
    public class ListaPilotos
    {
        public List<PilotoVO> items { get; set; }
    }
}
