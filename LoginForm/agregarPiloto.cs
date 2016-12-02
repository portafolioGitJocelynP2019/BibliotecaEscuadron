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
    public partial class agregarPiloto : Form
    {
        public agregarPiloto()
        {
            InitializeComponent();
        }

        private void dtFechNac_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            Boolean registrarPiloto = consume.nuevoPiloto(dtFechNac.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), 0,  Int32.Parse(txtUsuario.Text));
            if (registrarPiloto)
            {
                MessageBox.Show("Nueva aeronave creada.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            bool resultado = consume.editarPiloto(dtFechNac.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")), Int32.Parse(txtUsuario.Text), 1);
            if (resultado)
            {
                MessageBox.Show("Piloto editado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            ComponenteResponseListPiloto coincidencias = consume.buscarPiloto(Int32.Parse(txtIdPiloto.Text));

            if (coincidencias.items.Count == 1)
            {
                Piloto encontrado = coincidencias.items[0];
                txtIdPiloto.Text = encontrado.id_piloto.ToString();
                dtFechNac.Text = encontrado.fecha_vencimientomae.ToString();
                txtUsuario.Text = encontrado.id_usuario.ToString();
            }
            else if (coincidencias.items.Count == 0)
            {
                MessageBox.Show("No hay pilotos registrados con ese id", "Piloto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdPiloto.Text);
            ConsumeWebApi consume = new ConsumeWebApi();
            bool result = consume.eliminarPiloto(id);

            if (result)
            {
                MessageBox.Show("Componente eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Algo salió mal. Intente nuevamente.", "Problemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
