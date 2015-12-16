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
    public partial class VerDetallesOferta : Form
    {

        private ESesion sesion;
        private int idOferta;

        public VerDetallesOferta()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        public void SetDatos(int idOferta)
        {
            try
            {
                this.idOferta = idOferta;

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

                DataRow oferta = new OfertasNeg().CargarOferta(idOferta);

                txtbNombre.Text = oferta["Oferta"].ToString();
                cmbEstado.Text = oferta["Estado"].ToString();
                cmbSede.Text = oferta["Sede"].ToString();

                DateTime fechaMatricula = Convert.ToDateTime(oferta["FechaInicio"].ToString());
                txtbInicioMatricula.Text = fechaMatricula.ToString("dd-MM-yyyy");

                cmbHora.Text = fechaMatricula.Hour.ToString();
                cmbMinutos.Text = fechaMatricula.Minute.ToString();

                txtbFechaReg.Text = oferta["FechaRegistro"].ToString();
                txtbUltMod.Text = oferta["UltimaModificacion"].ToString();

                txtbObservacion.Text = oferta["Observacion"].ToString();
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT002", ex);
            }
        }

        private void txtbInicioMatricula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Entrada inválida";
            toolTip1.Show("Sólo se admiten números (0-9) en este campo.", txtbInicioMatricula,
                           txtbInicioMatricula.Location.X, 0, 1300);
        }

        /// <summary>
        /// Cerrar la ventana al finalizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        /// <summary>
        /// Habilitar los campos para un usuario con los suficientes
        /// privilegios para modificarlos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.ModificarOferta)
            {
                btnGuardar.Enabled = true;
                txtbNombre.Enabled = true;
                cmbSede.Enabled = true;
                txtbInicioMatricula.Enabled = true;
                cmbHora.Enabled = true;
                cmbMinutos.Enabled = true;
                txtbObservacion.Enabled = true;
            }
        }

        /// <summary>
        /// Guardar cambios sobre una oferta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EOferta mod = new EOferta();

                mod.LoginUsuario = sesion.Login;

                mod.IdOferta = idOferta;
                mod.Nombre = txtbNombre.Text;
                mod.IdEstado = Convert.ToInt16(cmbEstado.SelectedValue);
                mod.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                mod.MatriculaIniciaEl = Convert.ToDateTime(txtbInicioMatricula.Text + " " +
                                                             cmbHora.Text + ":" +
                                                             cmbMinutos.Text + ":00");
                mod.UltimaModificacion = DateTime.Now;
                mod.Observacion = txtbObservacion.Text;

                if (mod.DatosValidos())
                {
                    if (new OfertasNeg().ModificarOferta(mod)) {
                        MessageBox.Show(this, "La oferta '" + mod.Nombre + "' se modificó " +
                                              "exitosamente. ", "Éxito");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Revise que los datos en los campos sean correctos.",
                                          "Error");
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT004", ex);
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
