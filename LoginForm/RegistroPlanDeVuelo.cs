using BibliotecaEscuadron;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
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
                Boolean registrarPlanVuelo = consume.crearPlan(txtNombre.Text, txtEtd.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtQrf.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtTipoAeronave.Text, txtVelocidadCrucero.Text,txtReglasDeVuelo.Text, txtSalida.Text, txtDestino.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            ComponenteResponseListPlanVuelo coincidencias = consume.buscarPlan(Int32.Parse(txtIdSearch.Text));

            if (coincidencias.items.Count == 1)
            {
                PlanVuelo encontrado = coincidencias.items[0];

                txtNombre.Text = encontrado.nombre.ToString();
                txtEtd.Text = encontrado.etd.ToString();
                txtQrf.Text = encontrado.qrf.ToString();
                txtTipoAeronave.Text = encontrado.tipo_vuelo.ToString();
                txtVelocidadCrucero.Text = encontrado.velocidad__crucero.ToString();
                txtReglasDeVuelo.Text = encontrado.reglas_vuelo.ToString();
                txtSalida.Text = encontrado.aerodromo_salida.ToString();
                txtDestino.Text = encontrado.aerodromo_destino.ToString();
            }
            else if (coincidencias.items.Count == 0)
            {
                MessageBox.Show("No hay planes de vuelos registrados con ese id", "Plan de vuelo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdSearch.Text);
            ConsumeWebApi consume = new ConsumeWebApi();
            bool result = consume.eliminarPlan(id);

            if (result)
            {
                MessageBox.Show("Plan de vuelo eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algo salió mal. Intente nuevamente.", "Problemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
