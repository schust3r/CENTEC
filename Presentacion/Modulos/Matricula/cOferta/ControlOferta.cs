using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios.modMatricula;
using Entidades.eMatricula;
using Presentacion.Inicio;
using Presentacion.Modulos.Matricula.cMatricula;

namespace Presentacion.Modulos.Matricula.cOferta
{
    public partial class ControlOferta : UserControl
    {

        private ESesion sesion;

        public ControlOferta()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }


        /// <summary>
        /// Cargar datos actualizados de ofertas
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Descripcion"></param>
        private void CargarTablaOfertas(EOferta consulta)
        {
            try
            {
                // Reiniciar contenidos del DataGridView
                GridOferta.DataSource = null;
                GridOferta.Rows.Clear();
                GridOferta.Refresh();

                // Llenar valores de entidad consulta
                if (!cmbEstado.Text.Equals("Cualquiera"))
                    consulta.IdEstado = Convert.ToInt16(cmbEstado.SelectedValue);

                if (!cmbSede.Text.Equals("Cualquiera"))
                    consulta.IdSede = Convert.ToInt16(cmbSede.SelectedValue);

                consulta.Nombre = txtbNombre.Text;

                DataView info = new OfertasNeg().ConsultarOfertas(consulta);

                GridOferta.DataSource = info;

                // Configurar alineación de columnas especiales
                GridOferta.Columns["ID"].Visible = false;
                GridOferta.Columns["Sede"].DefaultCellStyle.Font = new Font(Font, FontStyle.Bold);
                GridOferta.Columns["Matrícula inicia el"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

                // Mostrar subrayado si el usuario dispone del permiso Ver Detalles
                if (sesion.permisos.VerDetallesOferta)
                    GridOferta.Columns["Nombre"].DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT001", ex);
            }
        }

        /// <summary>
        /// Load para precargar comboboxes, entre otros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlOferta_Load(object sender, EventArgs e)
        {
            try
            {
                DataView estados = new OfertasNeg().CargarListaEstados();
                DataRowView filaAdEst = estados.AddNew();
                filaAdEst["Estado"] = "Cualquiera";
                cmbEstado.DataSource = estados;
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "ID";
                cmbEstado.Text = "Cualquiera";

                DataView sedes = new OfertasNeg().CargarListaSedes();
                DataRowView filaAdTip = sedes.AddNew();
                filaAdTip["Sede"] = "Cualquiera";
                cmbSede.DataSource = sedes;
                cmbSede.DisplayMember = "Sede";
                cmbSede.ValueMember = "ID";
                cmbSede.Text = "Cualquiera";

                CargarTablaOfertas(new EOferta());
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT001", ex);
            }
        }

        /// <summary>
        /// Retorna el color adecuado para cada celda
        /// </summary>
        /// <param name="cont"></param>
        /// <returns></returns>
        public void AsignarColorEstado()
        {
            // Colorear celdas de estado según su texto
            foreach (DataGridViewRow row in GridOferta.Rows)
            {
                string estado = row.Cells[0].Value.ToString();
                Color statColor;
                switch (estado)
                {
                    case "Planificado":
                        statColor = Color.Orange; break;
                    case "En matrícula":
                        statColor = Color.Green; break;
                    case "Matrícula cerrada":
                        statColor = Color.Red; break;
                    case "Matrícula en pausa":
                        statColor = Color.Gray; break;
                    default:
                        statColor = Color.White; break;
                }
                row.Cells[0].Style.BackColor = statColor;
            }
        }

        /// <summary>
        /// Realizar búsqueda al presionar Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaOfertas(new EOferta());
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
                    fontBrush = Brushes.Black;
                    brush = Brushes.White;
                    break;
            }
            Rectangle rect = e.Bounds;
            text = cmbEstado.GetItemText(cmbEstado.Items[e.Index]);

            // Draw the background 
            e.DrawBackground();

            // Draw the text    
            // Get the item text    
            e.Graphics.FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);
            e.Graphics.DrawString(cmbEstado.GetItemText(cmbEstado.Items[e.Index]), 
                      ((Control)sender).Font, fontBrush, e.Bounds.X, e.Bounds.Y);

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Para registrar una nueva oferta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevaOferta_Click(object sender, EventArgs e)
        {
            var RegOferta = new RegistrarOferta();
            RegOferta.ShowDialog();
            CargarTablaOfertas(new EOferta());
        }

        private void GridOferta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AsignarColorEstado();
        }

        /// <summary>
        /// Eliminar una oferta si se encuentra una fila seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarOferta_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridOferta.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = GridOferta.SelectedRows[0];
                    string nombreOferta = row.Cells["Nombre"].Value.ToString();
                    int idOferta = int.Parse(row.Cells["ID"].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar la oferta seleccionada?",
                                                                 "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        EOferta elim = new EOferta();
                        elim.Nombre = nombreOferta;
                        elim.IdOferta = idOferta;

                        if (new OfertasNeg().EliminarOferta(elim))
                        {
                            MessageBox.Show("Se ha eliminado la información de la oferta '" +
                                             nombreOferta + "'.", "Éxito");
                            CargarTablaOfertas(new EOferta());
                        }
                        else
                        {
                            MessageBox.Show("No se ha podido eliminar la oferta '" + nombreOferta + 
                                            "' porque tiene cursos asignados.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT005", ex);
            }
        }

        /// <summary>
        /// Responder a doble clic sobre estado o nombre subrayado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridOferta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                try
                {
                    switch (e.ColumnIndex)
                    {

                        case 2:
                            if (sesion.permisos.VerDetallesOferta)
                            {
                                var VerDetalles = new VerDetallesOferta();
                                int idOferta = Convert.ToInt16(GridOferta.Rows[e.RowIndex].Cells["ID"].Value.ToString());
                                VerDetalles.SetDatos(idOferta);
                                VerDetalles.ShowDialog();
                                CargarTablaOfertas(new EOferta());
                            }
                            break;

                        case 0:
                            if (sesion.permisos.CambiarEstadoOferta)
                            {
                                string idOfertaStr = GridOferta.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                                var CambioEstado = new CambiarEstado("oferta", idOfertaStr,
                                                     GridOferta.Rows[e.RowIndex].Cells["Estado"].Value.ToString(),
                                                     GridOferta.Rows[e.RowIndex].Cells["Nombre"].Value.ToString());
                                CambioEstado.ShowDialog();
                                CargarTablaOfertas(new EOferta());
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MainForm.NotificarExcepcion("CU MAT002", ex);
                }
            }
        }


    }
}
