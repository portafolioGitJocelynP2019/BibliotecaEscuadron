using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaEscuadron
{
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }*/

        private void MainPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        private void lklSalir_MouseClick(object sender, MouseEventArgs e)
        {
           if (MessageBox.Show(" Desea cerrar esta vista ahora.", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Close(); }
            
        }

    
        
        

    }
}
