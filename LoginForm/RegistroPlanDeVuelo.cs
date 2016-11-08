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
    public partial class RegistroPlanDeVuelo : Form
    {
        public RegistroPlanDeVuelo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el nombre-", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtEtd.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el ETD.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEtd.Focus();
            }
            else if (txtTipoAeronave.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el tipo de aeronave.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoAeronave.Focus();
            }
            else if (txtVelocidadCrucero.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar la velocidad crucero.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVelocidadCrucero.Focus();
            }
            else if (txtReglasDeVuelo.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar las reglas de vuelo.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReglasDeVuelo.Focus();
            }
            else
            {
                ConsumeWebApi consume = new ConsumeWebApi();
                Boolean registrarPlanVuelo = consume.crearPlan(txtNombre.Text, txtEtd.Text, txtQrf.Text, txtTipoAeronave.Text, txtVelocidadCrucero.Text,txtReglasDeVuelo.Text);
                if (registrarPlanVuelo)
                {
                    MessageBox.Show("Nuevo plan de vuelo creado.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
