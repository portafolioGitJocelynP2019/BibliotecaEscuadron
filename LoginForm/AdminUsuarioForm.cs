using BibliotecaEscuadron;
using BibliotecaEscuadron.VO;
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
    public partial class AdminUsuarioForm : Form
    {
        int idUsuario;
        public AdminUsuarioForm()
        {
            InitializeComponent();
            ConsumeWebApi consume = new ConsumeWebApi();
            //cargar combos de Perfils.
            ListPerfil listaPerfil = consume.getPerfilesUsuario();
            PerfilVO p = new PerfilVO();
            p.id_perfil = 0;
            p.perfil = "--- Seleccione Perfil ---";
            cboTipoPerfil.Items.Add(p);
            foreach (var item in listaPerfil.items)
            {
                cboTipoPerfil.Items.Add(item);
            }
            cboTipoPerfil.ValueMember = "id_perfil";
            cboTipoPerfil.DisplayMember = "perfil";
            cboTipoPerfil.SelectedIndex = 0;
           
            //cargar combos de Pilotos.
            List<PilotoVO> listPilotos = consume.getPilotosCombo();
            PilotoVO pi = new PilotoVO();
            pi.id_piloto = 0;
            pi.nombre = "--- Seleccione Instructor ---";
            cboPiloto.Items.Add(pi);
            foreach (var item in listPilotos)
            {
                cboPiloto.Items.Add(item);
            }
            cboPiloto.ValueMember = "id_piloto";
            cboPiloto.DisplayMember = "nombre";
            cboPiloto.SelectedIndex = 0;
            fecVencMae.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            PilotoVO p = consume.getPilotoxIdUsuario(idUsuario);
            if (p != null)
            {
                consume.deletePiloto(p.id_piloto);
            }
            if (!consume.deleteUser(idUsuario))
            {
                MessageBox.Show("Error al eliminar usuario  " + txtUserName.Text, "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("El usuario ha sido eliminado " + txtUserName.Text, "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            limpiar();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            PerfilVO perfil = (PerfilVO)cboTipoPerfil.SelectedItem;
            int p = perfil.id_perfil;
            PilotoVO piloto= (PilotoVO)cboPiloto.SelectedItem;
            int instructor = piloto.id_piloto;

            AdministradorUsuario adm = new AdministradorUsuario(txtUserName.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, dtFechNac.Value, txtRut.Text, instructor, p);


            if (!consume.existeUser(txtUserName.Text))
            {
                int createUser = consume.createUser(adm);
                if (createUser>0)
                {
                    if (p == 2 || p == 5 || p == 6) { 
                        consume.nuevoPiloto(fecVencMae.Value.ToString("dd-MMM-yy", CultureInfo.CreateSpecificCulture("en-US")), 0, createUser);
                    }
                    MessageBox.Show("Creado", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { MessageBox.Show("Error", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else {

               MessageBox.Show("Usuario ya existe", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
        }


        private void cboTipoPerfil_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoPerfil.SelectedIndex > 0) { 
                PerfilVO perfil = (PerfilVO)cboTipoPerfil.SelectedItem;
                int p = perfil.id_perfil;
                if (p == 2 || p == 5 || p == 6)
                {
                    fecVencMae.Enabled = true;
                }else
                {
                    fecVencMae.Enabled = false;
                }
            }
            else
            {
                fecVencMae.Enabled = false;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            PerfilVO perfil = (PerfilVO)cboTipoPerfil.SelectedItem;
            int p = perfil.id_perfil;
            PilotoVO piloto = (PilotoVO)cboPiloto.SelectedItem;
            int instructor = piloto.id_piloto;
            AdministradorUsuario adm = new AdministradorUsuario(txtUserName.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, dtFechNac.Value, txtRut.Text, instructor, p);
            Boolean createUser = consume.updateUser(adm,idUsuario);
                if (createUser)
                {
                    MessageBox.Show("Usuario Actualizado", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
                else
                { MessageBox.Show("Error Al actualizar", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsumeWebApi consume = new ConsumeWebApi();
            List<UsuarioVO> listaUsuario = consume.getUsuarios().items;
            bool existe = false;
            foreach (var item in listaUsuario)
            {
                if (txtUserName.Text.Equals(item.username))
                {
                    existe = true;
                    txtNombre.Text = item.nombre;
                    txtApellido.Text = item.apellido;
                    txtEmail.Text = item.email;
                    txtPassword.Text = item.password;
                    txtRut.Text = item.rut;
                    PilotoVO p = new PilotoVO();
                    p.id_piloto = item.instructor;
                    cboPiloto.SelectedItem= p;
                    PerfilVO per = new PerfilVO();
                    per.id_perfil= item.tipoperfil;
                    cboTipoPerfil.SelectedItem = per;
                    dtFechNac.Value = Convert.ToDateTime( item.fecha_nac);
                    lblVechaMae.Visible = false;
                    fecVencMae.Visible = false;
                    btnRegistrar.Enabled = false;
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    idUsuario = item.id_usuario;
                }
            }
            if (!existe)
            {
                MessageBox.Show("Usuario no existe", "Escuela Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void limpiar()
        {
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtUserName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtRut.Text = String.Empty;
            cboPiloto.SelectedIndex = 0;
            cboTipoPerfil.SelectedIndex = 0;
            dtFechNac.Value = DateTime.Now;
            lblVechaMae.Visible = true;
            fecVencMae.Visible = true;
            btnRegistrar.Enabled = true;
            idUsuario = 0;
            btnRegistrar.Enabled = true;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

      
    }
}
