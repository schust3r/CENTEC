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
using Entidades;
using LogicaNegocios.modConfiguracion;

namespace Presentacion.Modulos.Configuracion.cPerfil
{
    public partial class ControlPerfil : UserControl
    {
        // Sesión que se adquiere desde Frame principal
        private ESesion sesion;

        public ControlPerfil()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;

            // Precargar tabla con todos los registros disponibles en la BD
            CargarTablaPerfiles("", "");
        }

        /// <summary>
        /// Cargar datos actualizados de perfiles
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="Descripcion"></param>
        private void CargarTablaPerfiles(string Nombre, string Descripcion)
        {
            try {
                // Reiniciar contenidos del DataGridView
                GridPerfil.DataSource = null;
                GridPerfil.Rows.Clear();
                GridPerfil.Refresh();

                DataView infoPerfiles = new PerfilNeg().ConsultarPerfiles(Nombre, Descripcion);
                GridPerfil.DataSource = infoPerfiles;

                // Configurar alineación de columnas especiales
                GridPerfil.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                GridPerfil.Columns[3].Visible = false;

                // Mostrar subrayado si el usuario dispone del permiso Ver Detalles
                if (sesion.permisos.VerDetallesPerfil)
                    GridPerfil.Columns[0].DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON001", ex);
            }
        }

        /// <summary>
        /// Realizar búsqueda al presionar Enter sobre cualquier campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaPerfiles(txtbNombre.Text, txtbDescripcion.Text);
            }
        }

        private void btnNuevoPerfil_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.RegistrarPerfil)
            {
                var regPerfil = new RegistrarPerfil();
                regPerfil.ShowDialog();
                CargarTablaPerfiles("", "");
            }
        }

        private void GridPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sesion.permisos.VerDetallesPerfil)
            {
                if (e.ColumnIndex == 0 && e.RowIndex != -1)
                {
                    try {
                        int idPerfil = int.Parse(GridPerfil.Rows[e.RowIndex].Cells[3].Value.ToString());
                        var VerDetalle = new PerfilVerDetalles();

                        Console.WriteLine(idPerfil);

                        VerDetalle.idAnt = idPerfil;
                        VerDetalle.SetDatos(new PerfilNeg().CargarPerfil(idPerfil));
                        VerDetalle.ShowDialog();
                        CargarTablaPerfiles("", "");
                    }
                    catch (Exception ex)
                    {
                        MainForm.NotificarExcepcion("CU CON002", ex);
                    }
                }
            }
        }

        /// <summary>
        /// Eliminar el perfil seleccionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            try {
                if (GridPerfil.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = GridPerfil.SelectedRows[0];
                    string nombrePerfil = row.Cells["Nombre"].Value.ToString();
                    int idPerfil = int.Parse(row.Cells["ID"].Value.ToString());

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el perfil seleccionado?",
                                                                 "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (this.sesion.NombrePerfil != row.Cells["Nombre"].Value.ToString())
                        {
                            EPerfil del = new EPerfil();
                            del.LoginUsuario = sesion.Login;
                            del.IdPerfil = idPerfil;
                            del.Nombre = nombrePerfil;

                            if (new PerfilNeg().EliminarPerfil(del))
                            {
                                MessageBox.Show("El perfil '" + nombrePerfil + "' se eliminó " +
                                                "exitosamente.", "Éxito");
                                CargarTablaPerfiles("", "");
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido eliminar el perfil '" + nombrePerfil + "'.",
                                                "Imposible continuar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede eliminar su propio perfil.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON005", ex);
            }
        }

        /*** FIN DEL BLOQUE ***/

    }
}
