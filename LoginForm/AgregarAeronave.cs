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
    public partial class AgregarAeronave : Form
    {
        public AgregarAeronave()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            Boolean registrarAeronave = consume.nuevoAeronave(Int32.Parse(txtTipo.Text), Int32.Parse(txtCantidadHoras.Text), txtFechaInspeccion.Text, Int32.Parse(txtAnoFabricacion.Text), txtFechaDgac.Text, txtTipoModelo.Text, Int32.Parse(txtCapacidad.Text),Int32.Parse(txtHrAutonomia.Text),txtMarca.Text, txtEstado.Text, txtFechaDeVencimiento.Text, txtMatricula.Text);
            if (registrarAeronave)
            {
                MessageBox.Show("Nueva aeronave creada.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarAeronave_Load(object sender, EventArgs e)
        {

        }
    }
}
