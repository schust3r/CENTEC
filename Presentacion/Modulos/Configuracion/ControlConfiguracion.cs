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
using Presentacion.Modulos.Configuracion.cBitacora;
using Presentacion.Modulos.Configuracion.cUsuario;
using Presentacion.Modulos.Configuracion.cPerfil;

namespace Presentacion.Modulos.Configuracion
{
    public partial class ControlConfiguracion: UserControl
    {
        /// <summary>
        /// Ventana padre del control, permite acceder a sus atributos como
        /// permisos de usuario y el panel principal.
        /// </summary>

        public ControlConfiguracion()
        {
            InitializeComponent();
            EvaluarPermisos();
        }

        /// <summary>
        /// Deshabilitar botones si el usuario no tiene los permisos requeridos
        /// </summary>
        private void EvaluarPermisos()
        {
            if (!MainForm.sesion.TieneAccesoABitacora())
                btnBitacora.Enabled = false;

            if (!MainForm.sesion.TieneAccesoAPerfil())
                btnPerfil.Enabled = false;

            if (!MainForm.sesion.TieneAccesoAUsuario())
                btnUsuario.Enabled = false;
        }
 
        /**
         * Controles del módulo configuración
         */ 

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlCurso());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlPerfil());
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlUsuario());
        }

        /// <summary>
        /// Asignar color azul al texto cuando el mouse entra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUsuario_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Regresar a color navy cuando el mouse sale del control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Navy;
        }
    }
}
