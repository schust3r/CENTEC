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
using LogicaNegocios.modMatricula;
using Entidades.eMatricula;
using Presentacion.Modulos.Matricula.cMatricula;

namespace Presentacion.Modulos.Matricula.cCursos
{
    public partial class ControlCursos : UserControl
    {

        private ESesion sesion;

        public ControlCursos()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Cargar datos actualizados de ofertas
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Descripcion"></param>
        private void CargarTablaCursos(ECurso consulta)
        {
            try
            {
                // Reiniciar contenidos del DataGridView
                GridCursos.DataSource = null;
                GridCursos.Rows.Clear();
                GridCursos.Refresh();

                // Llenar valores de entidad consulta
                consulta.Nombre = txtbNombre.Text;

                if (!cmbEstado.Text.Equals("Cualquiera"))
                    consulta.IdEstado = Convert.ToInt16(cmbEstado.SelectedValue);

                if (!cmbOferta.Text.Equals("Cualquiera"))
                    consulta.IdOferta = Convert.ToInt16(cmbOferta.SelectedValue);

                if (!cmbTipo.Text.Equals("Cualquiera"))
                    consulta.IdTipo = Convert.ToInt16(cmbTipo.SelectedValue);

                DataView info = new CursosNeg().ConsultarCursos(consulta);
                GridCursos.DataSource = info;

                // Mostrar subrayado si el usuario dispone del permiso Ver Detalles
                if (sesion.permisos.VerDetallesCurso)
                    GridCursos.Columns["Nombre del curso"].DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT006", ex);
            }
        }

        /// <summary>
        /// Habilitar permisos sobre botones según privilegios de usuario
        /// </summary>
        private void HabilitarPermisos()
        {
            if (!sesion.permisos.RegistrarCurso)
            {
                btnNuevoCurso.Enabled = false;
            }
            if (!sesion.permisos.EliminarCurso)
            {
                btnEliminarCurso.Enabled = false;
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
            foreach (DataGridViewRow row in GridCursos.Rows)
            {
                string estado = row.Cells[0].Value.ToString();
                Color statColor;
                switch (estado)
                {
                    case "Planificado":
                        statColor = Color.Orange; break;
                    case "Abierto":
                        statColor = Color.Green; break;
                    case "Matrícula llena":
                        statColor = Color.Red; break;
                    case "Matrícula incompleta":
                        statColor = Color.Red; break;
                    case "Curso en pausa":
                        statColor = Color.Gray; break;
                    default:
                        statColor = Color.White; break;
                }
                row.Cells[0].Style.BackColor = statColor;
            }
        }

        /// <summary>
        /// Abrir form para cargar un nuevo curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.RegistrarCurso)
            {
                RegistrarCurso RegCurso = new RegistrarCurso();
                RegCurso.ShowDialog();
                CargarTablaCursos(new ECurso());
            }
        }

        /// <summary>
        /// Load para precargar datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlCursos_Load(object sender, EventArgs e)
        {
            try
            {
                HabilitarPermisos();

                DataView estados = new CursosNeg().CargarListaEstados();
                DataRowView filaAdEst = estados.AddNew();
                filaAdEst["Estado"] = "Cualquiera";
                cmbEstado.DataSource = estados;
                cmbEstado.DisplayMember = "Estado";
                cmbEstado.ValueMember = "ID";
                cmbEstado.Text = "Cualquiera";

                DataView ofertas = new CursosNeg().CargarListaOfertas();
                DataRowView filaAdOfer = ofertas.AddNew();
                filaAdOfer["Oferta"] = "Cualquiera";
                cmbOferta.DataSource = ofertas;
                cmbOferta.DisplayMember = "Oferta";
                cmbOferta.ValueMember = "ID";
                cmbOferta.Text = "Cualquiera";

                DataView tipos = new CursosNeg().CargarListaTipos();
                DataRowView filaAdTip = tipos.AddNew();
                filaAdTip["Tipo"] = "Cualquiera";
                cmbTipo.DataSource = tipos;
                cmbTipo.DisplayMember = "Tipo";
                cmbTipo.ValueMember = "ID";
                cmbTipo.Text = "Cualquiera";

                CargarTablaCursos(new ECurso());
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT006", ex);
            }
        }

        /// <summary>
        /// Aplicar color a estados una vez se termine la carga
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCursos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            AsignarColorEstado();
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
                case "Abierto":
                    brush = Brushes.Green;
                    break;
                case "Matrícula llena":
                    brush = Brushes.Red;
                    break;
                case "Matrícula incompleta":
                    brush = Brushes.Red;
                    break;
                case "Curso en pausa":
                    brush = Brushes.Gray;
                    break;
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
            e.Graphics.DrawString(cmbEstado.GetItemText(cmbEstado.Items[e.Index]), ((Control)sender).Font, fontBrush, e.Bounds.X, e.Bounds.Y);

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        private void txtbNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaCursos(new ECurso());
            }
        }

        /// <summary>
        /// Abrir cambio de estado o detalles de un curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCursos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                if (e.RowIndex != -1) {

                    string cod = GridCursos.Rows[e.RowIndex].Cells["Código"].Value.ToString();

                    switch (e.ColumnIndex)
                    {

                        // Click sobre el estado
                        case 0:
                            string estadoAnt = GridCursos.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                            string infoItem = GridCursos.Rows[e.RowIndex].Cells["Nombre del curso"].Value.ToString();
                            CambiarEstado estadoCurso = new CambiarEstado("curso", cod, estadoAnt, infoItem);
                            estadoCurso.ShowDialog();
                            CargarTablaCursos(new ECurso());
                            break;

                        // Click sobre el nombre
                        case 5:
                            CursoVerDetalles verDetalles = new CursoVerDetalles();
                            verDetalles.SetDatos(cod);
                            verDetalles.ShowDialog();
                            CargarTablaCursos(new ECurso());
                            break;
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Eliminar el curso de la fila seleccionada (evento del botón Eliminar)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridCursos.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = GridCursos.SelectedRows[0];
                    string codCurso = row.Cells["Código"].Value.ToString();
                    string nomCurso = row.Cells["Nombre del curso"].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el curso seleccionado?",
                                                                 "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (row.Cells["Estado"].Value.ToString().Equals("Planificado"))
                        {
                            ECurso elim = new ECurso();
                            elim.LoginUsuario = sesion.Login;
                            elim.Codigo = codCurso;
                            elim.Nombre = nomCurso;

                            if (new CursosNeg().EliminarCurso(elim))
                            {
                                MessageBox.Show("Se ha eliminado la información del curso '" +
                                                 nomCurso + "'.", "Éxito");
                                CargarTablaCursos(new ECurso());
                            }
                        }
                        else
                        {
                            MessageBox.Show("El curso “" + nomCurso + "” no se puede eliminar ya que no se "
                                             + "encuentra en el estado “Planificado”", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT010", ex);
            }
        }


    }
}
