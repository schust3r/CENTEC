using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocios.modConfiguracion;
using Presentacion.Inicio;

namespace Presentacion.Modulos.Configuracion.cBitacora
{
    public partial class ControlCurso : UserControl
    {
        public ControlCurso()
        {
            InitializeComponent();
            fechaFin.Value = DateTime.Now.AddDays(1);
            CargarTablaBitacora(new EBitacora());
        }

        /// <summary>
        /// Cargar DataViewGrid con resultados de consulta con los parámetros
        /// especificados en la Entidad "busqueda"
        /// </summary>
        /// <param name="busqueda">Entidad EBitacora</param>
        private void CargarTablaBitacora(EBitacora busqueda)
        {
            busqueda.FechaInicio = fechaInicio.Value.Date;
            busqueda.FechaFin = fechaFin.Value.Date;
            busqueda.LoginUsuario = txtbLogin.Text;
            busqueda.Accion = txtbAccion.Text;
            busqueda.TipoEvento = txtbTipoDeEvento.Text;
            busqueda.Descripcion = txtbDescripcion.Text;

            if (busqueda.FechaInicioFinValida())
            {
                try {
                    // Limpiar datos y refrescar el DataViewGrid
                    GridBitacora.DataSource = null;
                    GridBitacora.Rows.Clear();
                    GridBitacora.Refresh();

                    DataView infoPerfiles = new ReporteNeg().ConsultarBitacora(busqueda);
                    GridBitacora.DataSource = infoPerfiles;
                }
                catch (Exception ex)
                {
                    // Capturar e informar de excepción inesperada
                    MainForm.NotificarExcepcion("Cargar tabla de bitácora", ex);
                }
            }
            else
            {
                MessageBox.Show(this, "Las fechas que ha ingresado no están en el orden correcto o son mayores que hoy.",
                                      "Error de espacio-tiempo");
            }
        }

        /// <summary>
        /// Realizar búsqueda al presionar Enter sobre cualquier campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fechaFin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarTablaBitacora(new EBitacora());
            }
        }

    }
}
