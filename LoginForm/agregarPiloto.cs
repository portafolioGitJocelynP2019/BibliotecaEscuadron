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
                MessageBox.Show(dtFechNac.Value.ToString("dd-MMMM-yyyy", CultureInfo.CreateSpecificCulture("en-US")));
                MessageBox.Show("Nueva aeronave creada.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
