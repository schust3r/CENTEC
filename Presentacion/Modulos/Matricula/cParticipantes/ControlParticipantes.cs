using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Inicio;
using Entidades.eMatricula;
using LogicaNegocios.modMatricula;
using Presentacion.Modulos.Matricula.cMatricula;
using DGVPrinterHelper;

namespace Presentacion.Modulos.Matricula.cParticipantes
{
    public partial class ControlParticipantes : UserControl
    {

        private ESesion sesion;
        private DataView infoDat;

        public ControlParticipantes()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Cargar datos actualizados de participantes
        /// </summary>
        /// <param name="consulta"></param>
        private void CargarTablaPart(EParticipante consulta)
        {
            try
            {
                // Reiniciar contenidos del DataGridView
                GridPart.DataSource = null;
                GridPart.Rows.Clear();
                GridPart.Refresh();

                // Llenar valores de entidad consulta
                if (!cmbOferta.Text.Equals("Cualquiera"))
                    consulta.IdOferta = Convert.ToInt16(cmbOferta.SelectedValue);

                if (!cmbTipo.Text.Equals("Cualquiera"))
                    consulta.IdTipoMatricula = Convert.ToInt16(cmbTipo.SelectedValue);

                if (!cmbEstado.Text.Equals("Cualquiera"))
                    consulta.IdEstado = Convert.ToInt16(cmbEstado.SelectedValue);

                consulta.Usuario = txtbUsuario.Text;
                consulta.Identificacion = txtbIdenti.Text;

                DataView info = new ParticipantesNeg().ConsultarParticipantes(consulta);
                infoDat = info;

                GridPart.DataSource = info;

                // Configurar alineación de columnas especiales
                GridPart.Columns["ID"].Visible = false;
                GridPart.Columns["Fecha de matrícula"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                GridPart.Columns["Orden"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT013", ex);
            }
        }

        /// <summary>
        /// Habilitar permisos sobre botones según privilegios de usuario
        /// </summary>
        private void HabilitarPermisos()
        {
            if (!sesion.permisos.ImprimirComprobante)
            {
                btnImprimir.Enabled = false;
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
            foreach (DataGridViewRow row in GridPart.Rows)
            {
                string estado = row.Cells[1].Value.ToString();
                Color statColor;
                switch (estado)
                {
                    case "Por confirmar":
                        statColor = Color.Orange; break;
                    case "Matriculado":
                        statColor = Color.Green; break;
                    case "En espera":
                        statColor = Color.Gray; break;
                    case "Desmatriculado":
                        statColor = Color.Red; break;
                    case "No confirmado":
                        statColor = Color.Red; break;
                    case "Desertado":
                        statColor = Color.Red; break;
                    default:
                        statColor = Color.White; break;
                }
                row.Cells[1].Style.BackColor = statColor;
            }
        }

        /// <summary>
        /// Load para la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlParticipantes_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarPermisos();

                DataView estados = new ParticipantesNeg().CargarListaEstados();
                DataRowView filaAdEst = estados.AddNew();
                filaAdEst["Estado"] = "Cualquiera";
                cmbEstado.DataSource = estados;
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "ID";
                cmbEstado.Text = "Cualquiera";

                DataView ofertas = new ParticipantesNeg().CargarListaOfertas();
                DataRowView filaAdOfer = ofertas.AddNew();
                filaAdOfer["Oferta"] = "Cualquiera";
                cmbOferta.DataSource = ofertas;
                cmbOferta.DisplayMember = "Oferta";
                cmbOferta.ValueMember = "ID";
                cmbOferta.Text = "Cualquiera";

                DataView tipos = new ParticipantesNeg().CargarListaTipos();
                DataRowView filaAdTip = tipos.AddNew();
                filaAdTip["Tipo"] = "Cualquiera";
                cmbTipo.DataSource = tipos;
                cmbTipo.DisplayMember = "Tipo";
                cmbTipo.ValueMember = "ID";
                cmbTipo.Text = "Cualquiera";

                CargarTablaPart(new EParticipante());
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT013", ex);
            }
        }

        /// <summary>
        /// Acciones para efectuar cuando termina la carga de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridPart_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AsignarColorEstado();
        }

        /// <summary>
        /// Color para cada estado del Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEstado_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Determine the forecolor based on whether or not the item is selected    
            Brush brush;
            Brush fontBrush = Brushes.White;
            string text = cmbEstado.GetItemText(cmbEstado.Items[e.Index]);

            switch (text)
            {
                case "Por confirmar":
                    brush = Brushes.Orange; break;
                case "Matriculado":
                    brush = Brushes.Green; break;
                case "En espera":
                    brush = Brushes.Gray; break;
                case "Desmatriculado":
                    brush = Brushes.Red; break;
                case "No confirmado":
                    brush = Brushes.Red; break;
                case "Desertado":
                    brush = Brushes.Red; break;
                default:
                    brush = Brushes.White;
                    fontBrush = Brushes.Black;
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
        /// Ejecutar búsqueda con parámetros indicados por el usuario
        /// al presionar enter sobre un textbox o combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaPart(new EParticipante());
            }
        }

        private void GridPart_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex != -1)
                {
                    if (e.ColumnIndex == 1)
                    {
                        string idPart = GridPart.Rows[e.RowIndex]
                            .Cells["ID"].Value.ToString();

                        string estadoPart = GridPart.Rows[e.RowIndex]
                            .Cells["Estado"].Value.ToString();

                        string infoItem = GridPart.Rows[e.RowIndex]
                            .Cells["Identificación"].Value.ToString();

                        CambiarEstado estPart = new CambiarEstado("participante",
                                                     idPart, estadoPart, infoItem);
                        estPart.ShowDialog();
                        CargarTablaPart(new EParticipante());
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT013", ex);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        /// <summary>
        /// Botón de evento para imprimir el comprobante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Reporte de participantes";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
                                          StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "CENTEC - Centro de Capacitación Tecnológica";
            printer.FooterSpacing = 15;
            printer.PreviewDialog = printPreviewDialog1;
            printer.PageSettings.Landscape = true;
            printer.PrintPreviewDataGridView(GridPart);
        }


    }
}
