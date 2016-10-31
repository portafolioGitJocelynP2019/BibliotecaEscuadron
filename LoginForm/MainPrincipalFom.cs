using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaEscuadron;

namespace LoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         lblFecha.Text=DateTime.UtcNow.ToLongDateString();
         lblHora.Text = DateTime.Now.ToLongTimeString();
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el usuario.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("asegurese de ingresar la contraseña.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                ConsumeWebApi consume = new ConsumeWebApi();
                Boolean canLogin = consume.canLogin(txtUsername.Text, txtPassword.Text);
                if (canLogin) {
                    
                    MessageBox.Show("Bienvenido Sr(a): "+ txtUsername.Text, "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainPrincipal form = new MainPrincipal();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Error de user o Password, intente nuevamente.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualiza cada segundo la hora.
            lblHora.Text= DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Size = new Size(90,80);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" ESTA SEGURO QUE DESEA SALIR.", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Application.Exit(); }
        }
    }
}
