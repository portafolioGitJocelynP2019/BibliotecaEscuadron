using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class ListarVuelos : Form
    {
        public ListarVuelos()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ListarVuelos vuelo = new ListarVuelos();
            vuelo.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            EliminarVuelos vuelo = new EliminarVuelos();
            vuelo.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            EditarVuelos vuelo = new EditarVuelos();
            vuelo.Show();
        }
    }
}
