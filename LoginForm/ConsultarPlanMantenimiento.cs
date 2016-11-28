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
using System.Net.Mail;

namespace LoginForm
{
    public partial class ConsultarPlanMantenimiento : Form
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
        public ConsultarPlanMantenimiento()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Valida que se ingrese texto en el textbox
            if (txtTipo.Text == "")
            {
                MessageBox.Show("No se ha ingresado un identificador de Plan.", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipo.Focus();
            }
            else
            {
                //Valida solo valores numericos en el textbox 
                if (!IsNumeric(txtTipo.Text))
                {
                    MessageBox.Show("Solo ingresar valores numéricos", "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipo.Focus();
                }
                else
                {
                    try
                    {
                        //Trae los datos desde la URL de Cloud y se le concatena el id al final de la url.
                        string uri = @"https://database-clportafoliootrial.db.us2.oraclecloudapps.com/apex/hawkflying/buscarMantenimientoPlan/" + txtTipo.Text;
                        // Descargar los valores de la URL
                        var json = new WebClient().DownloadString(uri);
                        //Deserializa los valores del json en la clase Mantenimiento
                        PlanMantenimiento planmantenimiento = JsonConvert.DeserializeObject<PlanMantenimiento>(json);
                        //se le entregan los valores desde la clase mantenimiento a los textbox para mostrar
                        //MessageBox.Show(json, "aa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatricula.Text = planmantenimiento.matriculaAeronave;
                        txtCantHoras.Text = planmantenimiento.cantidadHoras.ToString();
                        txtHoras.Text = planmantenimiento.horasAeronave.ToString();
                        txtDias.Text = planmantenimiento.diasAeronave.ToString();
                        txtUltimoVuelo.Text = planmantenimiento.fechaUltimoVuelo;


                    }
                    catch (Exception)
                    {
                        //Si no encuentra un id de mantenimiento, cae en el catch, limpia los textbox y muestra una advertencia indicando que no existe el id
                        txtMatricula.Text = "";
                        txtCantHoras.Text = "";
                        txtHoras.Text = "";
                        txtDias.Text = "";
                        txtUltimoVuelo.Text = "";
                        //Mensaje de error
                        MessageBox.Show("No se ha encontrado el mantenimiento", "404", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
