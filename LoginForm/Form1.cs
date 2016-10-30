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
                MessageBox.Show("Segurese de ingresar el usuario");
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Segurese de ingresar la contraseña");
                txtPassword.Focus();
            }
            else
            {
                ConsumeWebApi consume = new ConsumeWebApi();
                Boolean canLogin = consume.canLogin(txtUsername.Text, txtPassword.Text);
                if (canLogin) { 
                    MessageBox.Show("Bienvenido Sr(a): "+ txtUsername.Text);
                    this.Hide();
                }else
                {
                    MessageBox.Show("Ocurrio un error");
                    this.Hide();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Actualiza cada segundo la hora.
            lblHora.Text= DateTime.Now.ToLongTimeString();
        }
    }
}
