using Entidades.eMatricula;
using LogicaNegocios.modMatricula;
using Presentacion.Inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.Matricula.cOferta
{
    public partial class RegistrarOferta : Form
    {

        private ESesion sesion;

        public RegistrarOferta()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        // Load del Form
        private void RegistrarOferta_Load(object sender, EventArgs e)
        {
            try
            {
                // Aplicar máscara sobre textBox de hora
                txtbInicioMatricula.Mask = "00/00/0000";
                txtbInicioMatricula.MaskInputRejected +=
                    new MaskInputRejectedEventHandler(txtbInicioMatricula_MaskInputRejected);

                // Combobox de estado multicolor
                cmbEstado.DataSource = new OfertasNeg().CargarListaEstados();
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "ID";

                // Combobox de sedes
                cmbSede.DataSource = new OfertasNeg().CargarListaSedes();
                cmbSede.DisplayMember = "Sede";
                cmbSede.ValueMember = "ID";

                // Combobox de horas
                BindingList<int> listaH = new BindingList<int>();
                for (int h = 0; h < 24; h++) { listaH.Add(h); }
                cmbHora.DataSource = listaH;

                // Combobox de minutos
                BindingList<int> listaM = new BindingList<int>();
                for (int m = 0; m < 60; m++) { listaM.Add(m); }
                cmbMinutos.DataSource = listaM;

                cmbEstado.Text = "Planificado";
                txtbFechaReg.Text = DateTime.Now.ToString();
                txtbUltMod.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT003", ex);
            }
        }

        private void cmbEstado_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Determine the forecolor based on whether or not the item is selected    
            Brush brush;
            Brush fontBrush = Brushes.White;
            string text = cmbEstado.GetItemText(cmbEstado.Items[e.Index]);

            switch (text)
            {
                case "Planificado":
                    brush = Brushes.Orange;
                    break;
                case "En matrícula":
                    brush = Brushes.Green;
                    break;
                case "Matrícula cerrada":
                    brush = Brushes.Red;
                    break;
                case "Matrícula en pausa":
                    brush = Brushes.Gray;
                    break;
                default:
                    brush = Brushes.Black;
                    break;
            }
            Rectangle rect = e.Bounds;
            text = cmbEstado.GetItemText(cmbEstado.Items[e.Index]);

            // Draw the background 
            e.DrawBackground();

            // Draw the text    
            // Get the item text    
            e.Graphics.FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);
            e.Graphics.DrawString(cmbEstado.GetItemText(cmbEstado.Items[e.Index]), ((Control)sender).Font, fontBrush, e.Bounds.X, e.Bounds.Y);

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        private void txtbInicioMatricula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Entrada inválida";
            toolTip1.Show("Sólo se admiten números (0-9) en este campo.", txtbInicioMatricula,
                           txtbInicioMatricula.Location.X, 0, 1300);
        }

        /// <summary>
        /// Cancelar el nuevo registro de oferta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Comprobar y guardar el nuevo registro de oferta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EOferta nueva = new EOferta();
                nueva.LoginUsuario = sesion.Login;
                nueva.Nombre = txtbNombre.Text;
                nueva.Estado = cmbEstado.Text;
                nueva.IdEstado = Convert.ToInt16(cmbEstado.SelectedValue);
                nueva.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                nueva.Sede = cmbSede.Text;
                nueva.MatriculaIniciaEl = Convert.ToDateTime(txtbInicioMatricula.Text + " " +
                                                             cmbHora.Text + ":" +
                                                             cmbMinutos.Text + ":00");
                nueva.FechaRegistro = Convert.ToDateTime(txtbFechaReg.Text);
                nueva.UltimaModificacion = Convert.ToDateTime(txtbUltMod.Text);
                nueva.Observacion = txtbObservacion.Text;

                if (nueva.DatosValidos())
                {
                    new OfertasNeg().RegistrarOferta(nueva);
                    MessageBox.Show(this, "La oferta '" + nueva.Nombre + "' se registró " +
                                          "exitosamente. ", "Éxito");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Revise que los datos en los campos sean correctos.", 
                                          "Error");
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT003", ex);
            }

        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                errorNombre.SetError(txtbNombre, "Nombre de la oferta no puede ser vacío");
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void txtbInicioMatricula_TextChanged(object sender, EventArgs e)
        {
            DateTime fecha;
            if (DateTime.TryParse(txtbInicioMatricula.Text, out fecha))
            {
                errorInicioMat.Clear();
            }
            else
            {
                errorInicioMat.SetError(txtbInicioMatricula, "La fecha debe ser válida.");
            }
        }


    }
}
