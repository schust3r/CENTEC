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
using LogicaNegocios.modConfiguracion;
using Entidades;

namespace Presentacion.Modulos.Configuracion.cUsuario
{
    public partial class ControlUsuario : UserControl
    {
        // Sesión adquirida desde MainForm
        private ESesion sesion;

        public ControlUsuario()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;

            // Precargar tabla con todos los registros disponibles en la BD
            CargarTablaUsuarios("","","");
        }

        private void CargarTablaUsuarios(string Login, string Nombre, string Perfil)
        {
            try {
                // Guardar dataTable como DataSource del grid
                GridUsuario.DataSource = null;
                GridUsuario.Rows.Clear();
                GridUsuario.Refresh();

                EUsuario consulta = new EUsuario();

                consulta.Login = txtbLogin.Text;
                consulta.Nombre = txtbNombre.Text;
                consulta.NombrePerfil = txtbPerfil.Text;

                DataView infoUsuarios = new UsuarioNeg().ConsultarUsuarios(consulta);
                GridUsuario.DataSource = infoUsuarios;

                // Configurar alineación o apariencia de columnas especiales
                GridUsuario.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Mostrar subrayado si el usuario dispone del permiso Ver Detalles
                if (sesion.permisos.VerDetallesUsuario)
                    GridUsuario.Columns[1].DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON006", ex);
            }
        }

        /// <summary>
        /// Realizar búsqueda al presionar Enter sobre cualquier campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbPerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaUsuarios(txtbLogin.Text, txtbNombre.Text, txtbPerfil.Text);
            }
        }

        /// <summary>
        /// Registrar un nuevo usuario si el login dispone del permiso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.RegistrarUsuario)
            {
                var RegUsuario = new RegistrarUsuario();
                RegUsuario.ShowDialog();
                CargarTablaUsuarios("", "", "");
            }
        }

        /// <summary>
        /// Mostrar detalles de usuario al hacer doble clic sobre una celda válida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sesion.permisos.VerDetallesUsuario)
            {
                if (e.ColumnIndex == 1 && e.RowIndex != -1)
                {
                    try {
                        string nombreLogin = GridUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        UsuarioVerDetalles VerDetalle = new UsuarioVerDetalles();
                        VerDetalle.CargarInformacionUsuario(new UsuarioNeg().CargarUsuario(nombreLogin));
                        VerDetalle.ShowDialog();
                        CargarTablaUsuarios("", "", "");
                    }
                    catch (Exception ex)
                    {
                        MainForm.NotificarExcepcion("CU CON007", ex);
                    }
                }
            }
        }

        /// <summary>
        /// Eliminar el Login seleccionado en la tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try {
                if (GridUsuario.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = GridUsuario.SelectedRows[0];
                    string nomUsuario = row.Cells["Login"].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el usuario seleccionado?",
                                               "Confirmación", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!sesion.NombrePerfil.Equals(nomUsuario))
                        {
                            if (new UsuarioNeg().EliminarUsuario(nomUsuario))
                            {
                                MessageBox.Show("El usuario '" + nomUsuario + "' se eliminó " +
                                                "exitosamente.", "Éxito");
                                CargarTablaUsuarios("", "", "");
                            }
                            else
                            {
                                MessageBox.Show("No se ha podido eliminar el usuario '" + nomUsuario + "'.",
                                                "Imposible continuar");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No puede eliminar su propio usuario.", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON010", ex);
            }
        }

    }
}
