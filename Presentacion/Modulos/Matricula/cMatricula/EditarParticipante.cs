using LogicaNegocios.modMatricula;
using Presentacion.Inicio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.Matricula.cMatricula
{
    public partial class EditarParticipante : Form
    {

        private ESesion sesion;
        private List<string> data;

        public EditarParticipante()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Configurar datos (extraídos desde la tabla)
        /// </summary>
        /// <param name="datos"></param>
        public void SetData(List<string> datos)
        {
            try
            {
                this.data = datos;
                cmbIdenti.Text = datos[0];
                txtbIdenti.Text = datos[1];
                txtbNombre.Text = datos[2];
                txtbApellidos.Text = datos[3];
                txtbTel.Text = datos[4];
                txtbCorreo.Text = datos[5];
                txtbObservacion.Text = datos[6];
                txtbTipoApoyo.Text = datos[7];
            }
            catch { }
        }

        /// <summary>
        /// Retornar información modificada sobre los datos
        /// </summary>
        /// <returns></returns>
        public List<string> GetData()
        {
            return data;
        }

        /// <summary>
        /// Cerrar el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Habilitar campos para edición si el usuario dispone
        /// de permisos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.MatriculaPres)
            {
                btnGuardar.Enabled = true;
                cmbIdenti.Enabled = true;
                txtbIdenti.Enabled = true;
                txtbNombre.Enabled = true;
                txtbApellidos.Enabled = true;
                txtbTel.Enabled = true;
                txtbCorreo.Enabled = true;
                txtbObservacion.Enabled = true;
                txtbTipoApoyo.Enabled = true;
            }
        }

        /// <summary>
        /// Cargar combos y valores necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditarParticipante_Load(object sender, EventArgs e)
        {
            try
            {
                cmbIdenti.DataSource = new MatriculaNeg().CargarListaTiposParticipante();
                cmbIdenti.ValueMember = "ID";
                cmbIdenti.DisplayMember = "Tipo";
                cmbIdenti.Text = "Nacional";
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT011", ex);
            }
        }

        /// <summary>
        /// Guardar información modificada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Regex numeros = new Regex(@"^[0-9]+$");
            if (!string.IsNullOrWhiteSpace(txtbIdenti.Text) &&
                !string.IsNullOrWhiteSpace(txtbNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtbApellidos.Text) &&
                numeros.IsMatch(txtbIdenti.Text))
            {
                data[0] = cmbIdenti.SelectedValue.ToString();
                data[1] = txtbIdenti.Text;
                data[2] = txtbNombre.Text;
                data[3] = txtbApellidos.Text;
                data[4] = txtbTel.Text;
                data[5] = txtbCorreo.Text;
                data[6] = txtbObservacion.Text;
                data[7] = txtbTipoApoyo.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Por favor, rellene los campos obligatorios " +
               "correctamente para continuar, o seleccione 'Cancelar'", "Error");
            }
        }


    }
}
