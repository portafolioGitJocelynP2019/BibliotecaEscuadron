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
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace LoginForm
{
    public partial class ConsultarMantenimiento : Form
    {
        //Parte de la validación de que sea solo numeros
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ConsultarMantenimiento()
        {
            InitializeComponent();
        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Valida que se ingrese texto en el textbox
            if (txtIdentificador.Text == "")
            {
                MessageBox.Show("No se ha ingresado un identificador de mantenimiento.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentificador.Focus();
            }
            else
            {
                //Valida solo valores numericos en el textbox 
                if (!IsNumeric(txtIdentificador.Text))
                {
                    MessageBox.Show("Solo ingresar valores numéricos", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdentificador.Focus();
                }
                else
                {
                    try
                    {
                        //Trae los datos desde la URL de Cloud y se le concatena el id al final de la url.
                        string uri = @"https://database-clportafoliootrial.db.us2.oraclecloudapps.com/apex/hawkflying/mantenimiento/" + txtIdentificador.Text;
                        // Descargar los valores de la URL
                        var json = new WebClient().DownloadString(uri);
                        //Deserializa los valores del json en la clase Mantenimiento
                        Mantenimiento mantenimiento = JsonConvert.DeserializeObject<Mantenimiento>(json);
                        //se le entregan los valores desde la clase mantenimiento a los textbox para mostrar
                        txtIdMantencion.Text = mantenimiento.IdMantenimiento.ToString();
                        txtIdAeronave.Text = mantenimiento.idAeronave.ToString();
                        txtFechaMant.Text = mantenimiento.fechaMantenimiento.ToShortDateString();
                        txtTipoMant.Text = mantenimiento.tipoMantenimiento;
                        txtFechaFabr.Text = mantenimiento.fechaFabricante.ToShortDateString();
                        txtMatricula.Text = mantenimiento.matricula;
                        txtDGAC.Text = mantenimiento.fechaDGAC.ToShortDateString();
                        txtFechaVencimiento.Text = mantenimiento.fechaVencimiento.ToShortDateString();
                        txtRut.Text = mantenimiento.rutMecanico;
                        txtIdComponente.Text = mantenimiento.idComponente.ToString();
                        txtNombreComponente.Text = mantenimiento.nombreComponente;
                        txtCantHorasComp.Text = mantenimiento.cantHoras.ToString();
                        txtIdPadreComp.Text = mantenimiento.Idpadrecomponente.ToString();
                        txtIdTipoComp.Text = mantenimiento.idTipoComponente.ToString();
                    }
                    catch (Exception ex)
                    {
                        //Si no encuentra un id de mantenimiento, cae en el catch, limpia los textbox y muestra una advertencia indicando que no existe el id
                        txtIdMantencion.Text = "";
                        txtIdAeronave.Text = "";
                        txtFechaMant.Text = "";
                        txtTipoMant.Text = "";
                        txtFechaFabr.Text = "";
                        txtMatricula.Text = "";
                        txtDGAC.Text = "";
                        txtFechaVencimiento.Text = "";
                        txtRut.Text = "";
                        txtIdComponente.Text = "";
                        txtNombreComponente.Text = "";
                        txtCantHorasComp.Text = "";
                        txtIdPadreComp.Text = "";
                        txtIdTipoComp.Text = "";
                        //Mensaje de error
                        MessageBox.Show("Mantenimiento No Encontrado", "404", MessageBoxButtons.OK, MessageBoxIcon.Warning);     
                    }
                }
            }
        }
    }
}
