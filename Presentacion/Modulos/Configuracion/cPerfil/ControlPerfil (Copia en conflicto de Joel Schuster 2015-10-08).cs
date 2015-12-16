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
using Presentacion.Forms;

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

        private void CargarTablaPerfiles(string Nombre, string Descripcion)
        {
            // Reiniciar contenidos del DataGridView
            GridPerfil.DataSource = null;
            GridPerfil.Rows.Clear();
            GridPerfil.Refresh();

            IEnumerable<EPerfil> infoPerfiles = new PerfilNeg().ConsultarPerfiles(Nombre, Descripcion);
            GridPerfil.DataSource = infoPerfiles.ToList();

            for (int i = 0; i < GridPerfil.Columns.Count; i++)
            {
                switch (i)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    default:
                        GridPerfil.Columns[i].Visible = false;
                        break;
                }
            }

            // Configurar nombres de columnas
            GridPerfil.Columns[1].HeaderText = "Nombre";
            GridPerfil.Columns[2].HeaderText = "Descripción";
            GridPerfil.Columns[3].HeaderText = "Cantidad de usuarios";

            // Configurar alineación de columnas especiales
            GridPerfil.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Mostrar subrayado si el usuario dispone del permiso Ver Detalles
            if (sesion.permisos.VerDetallesPerfil)
                GridPerfil.Columns[1].DefaultCellStyle.Font = new Font(Font, FontStyle.Underline);
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
            var regPerfil = new RegistrarPerfil();
            regPerfil.ShowDialog();
        }

        private void GridPerfil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                string nombrePerfil = GridPerfil.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

            }
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (GridPerfil.SelectedRows.Count != 0)
            {
                DataGridViewRow row = GridPerfil.SelectedRows[0];
                string nombrePerfil = row.Cells["Nombre"].Value.ToString();
            }
        }

    }
}
