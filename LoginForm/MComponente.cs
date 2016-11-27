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
    public partial class MComponente : Form
    {
        public MComponente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarComponente_Click(object sender, EventArgs e)
        {
            if (txtNombreComp.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el nombre del componente", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreComp.Focus();
            }
            else if (txtCantHorasComp.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar las horas", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantHorasComp.Focus();
            }
            else if (txtIdPadre.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar ID Padre", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdPadre.Focus();
            }
            else if (txtIdCantHrsFab.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar las hrs del fabricante", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdCantHrsFab.Focus();
            }
            else if (txtCantDiasFab.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar los dias", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantDiasFab.Focus();
            }
            else if (txtIdTipoComp.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el tipo de componente", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdTipoComp.Focus();
            }
            else if (txtEspecialista.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el Especialista", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEspecialista.Focus();
            }
            else if (txtEstructura.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar la estructura", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstructura.Focus();
            }
            else
            {
                ConsumeWebApi consume = new ConsumeWebApi();
                Boolean nuevoComponente = consume.nuevoComponente((txtNombreComp.Text), Int32.Parse(txtCantHorasComp.Text), Int32.Parse(txtIdPadre.Text), Int32.Parse(txtIdCantHrsFab.Text), Int32.Parse(txtCantDiasFab.Text),
                    Int32.Parse(txtIdTipoComp.Text), Int32.Parse(txtEspecialista.Text), Int32.Parse(txtEstructura.Text));
                if (nuevoComponente)
                {
                    MessageBox.Show("Nuevo Componente ingresado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarComponente_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            ComponenteResponseList coincidencias = consume.buscarComponente(txtNombreComp.Text.Trim());

            if (coincidencias.items.Count == 1)
            {
                Componente encontrado = coincidencias.items[0];
                idcomponente.Text = encontrado.id_componente.ToString();
                txtCantDiasFab.Text = encontrado.cantidad_dias_fabricante.ToString();
                txtCantHorasComp.Text = encontrado.cant_horas.ToString();
                txtEspecialista.Text = encontrado.especialista_id_mec_compo.ToString();
                txtEstructura.Text = encontrado.estructura_id.ToString();
                txtIdCantHrsFab.Text = encontrado.cantidad_horas_fabricante.ToString();
                txtIdPadre.Text = encontrado.id_padre_componente.ToString();
                txtIdTipoComp.Text = encontrado.id_tipo_componente.ToString();
            } else if (coincidencias.items.Count == 0) {
                MessageBox.Show("No hay componentes registrados con ese nombre", "Componente no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditarComponente_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            bool resultado = consume.editarComponente((txtNombreComp.Text), Int32.Parse(txtCantHorasComp.Text), Int32.Parse(txtIdPadre.Text), Int32.Parse(txtIdCantHrsFab.Text), Int32.Parse(txtCantDiasFab.Text),
                    Int32.Parse(txtIdTipoComp.Text), Int32.Parse(txtEspecialista.Text), Int32.Parse(txtEstructura.Text), Convert.ToInt32(idcomponente.Text));
            if (resultado)
            {
                MessageBox.Show("Nuevo Componente ingresado.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                }
                
            }
        }

        private void btnEliminarComponente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idcomponente.Text);
            ConsumeWebApi consume = new ConsumeWebApi();
            bool result = consume.eliminarComponente(id);

            if (result){
                MessageBox.Show("Componente eliminado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else{
                MessageBox.Show("Algo salió mal. Intente nuevamente.", "Problemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            
        }
    }
}
