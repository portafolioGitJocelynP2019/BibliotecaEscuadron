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
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }
        
        private void MainPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        private void lklSalir_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            AdminUsuarioForm frm = new AdminUsuarioForm();
            frm.ShowDialog();
        }

        private void lklSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(" Desea cerrar esta vista ahora.", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Close(); }
            loginForm frm = new loginForm();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AgregarVuelo vuelo = new AgregarVuelo();
            vuelo.Show();
        }
    }
}
