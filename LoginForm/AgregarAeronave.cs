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
    public partial class AgregarAeronave : Form
    {
        public AgregarAeronave()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            Boolean registrarAeronave = consume.nuevoAeronave(Int32.Parse(txtTipo.Text), Int32.Parse(txtCantidadHoras.Text), txtFechaInspeccion.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), Int32.Parse(txtAnoFabricacion.Text), txtFechaDgac.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtTipoModelo.Text, Int32.Parse(txtCapacidad.Text),Int32.Parse(txtHrAutonomia.Text),txtMarca.Text, txtEstado.Text, txtFechaDeVencimiento.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtMatricula.Text);
            if (registrarAeronave)
            {
                MessageBox.Show("Nueva aeronave creada.", "Close Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK);
            }
        }

        private void AgregarAeronave_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            ComponenteResponseListAeronave coincidencias = consume.buscarAeronave(Int32.Parse(txtIdSearch.Text));

            if (coincidencias.items.Count == 1)
            {
                Aeronave encontrado = coincidencias.items[0];
                txtTipo.Text = encontrado.tipo.ToString();
                txtMatricula.Text = encontrado.matricula.ToString();
                txtCantidadHoras.Text = encontrado.cantidad_horas.ToString();
                txtFechaInspeccion.Text = encontrado.fecha_inspeccion.ToString();
                txtAnoFabricacion.Text = encontrado.ano_fabricacion.ToString();
                txtFechaDgac.Text = encontrado.fecha_dgac.ToString();
                txtTipoModelo.Text = encontrado.tipo_modelo.ToString();
                txtCapacidad.Text = encontrado.capacidad.ToString();
                txtHrAutonomia.Text = encontrado.hr_autonomia.ToString();
                txtMarca.Text = encontrado.marca.ToString();
                txtEstado.Text = encontrado.estado.ToString();
                txtFechaDeVencimiento.Text = encontrado.fecha_de_vencimiento.ToString();
            }
            else if (coincidencias.items.Count == 0)
            {
                MessageBox.Show("No hay aeronaves registrados con ese id", "Aeronave no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdSearch.Text);
            ConsumeWebApi consume = new ConsumeWebApi();
            bool result = consume.eliminarAeronave(id);

            if (result)
            {
                MessageBox.Show("Aeronave eliminada correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algo salió mal. Intente nuevamente.", "Problemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            bool resultado = consume.editarAeronave(Int32.Parse(txtTipo.Text), Int32.Parse(txtCantidadHoras.Text), txtFechaInspeccion.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), Int32.Parse(txtAnoFabricacion.Text), txtFechaDgac.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtTipoModelo.Text, Int32.Parse(txtCapacidad.Text), Int32.Parse(txtHrAutonomia.Text), txtMarca.Text, txtEstado.Text, txtFechaDeVencimiento.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), txtMatricula.Text, Int32.Parse(txtIdSearch.Text));
            if (resultado)
            {
                MessageBox.Show("Aeronave editada.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
