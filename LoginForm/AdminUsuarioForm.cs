using BibliotecaEscuadron;
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
    public partial class AdminUsuarioForm : Form
    {
        public AdminUsuarioForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            AdministradorUsuario adm = new AdministradorUsuario(txtUserName.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, dtFechNac.Value, txtRut.Text, 1, 1);
            Boolean createUser = consume.createUser(adm);
            if (createUser)
            { MessageBox.Show("creado"); }
            else
            { MessageBox.Show("error"); }
        }

        private void dtFechNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
