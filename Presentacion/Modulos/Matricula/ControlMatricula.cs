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
using Presentacion.Modulos.Matricula.cCursos;
using Presentacion.Modulos.Matricula.cOferta;
using Presentacion.Modulos.Matricula.cMatricula;
using Presentacion.Modulos.Matricula.cParticipantes;

namespace Presentacion.Modulos.Matricula
{
    /// <summary>
    /// User Control con secciones y opciones de matrícula
    /// </summary>
    public partial class ControlMatricula : UserControl
    {

        // Cargar sesión de usuario
        private ESesion sesion;

        public ControlMatricula()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            EvaluarPermisos();
        }

        /// <summary>
        /// Deshabilitar botones si el usuario no tiene los permisos requeridos
        /// </summary>
        private void EvaluarPermisos()
        {
            if (!sesion.TieneAccesoAOferta())
            {
                btnOferta.Enabled = false;
            }
            if (!sesion.TieneAccesoACurso())
            {
                btnCursos.Enabled = false;
            }
            if (!sesion.TieneAccesoAMatricula())
            {
                btnMatPres.Enabled = false;
            }
            if (!sesion.TieneAccesoAParticipante())
            {
                btnParticipantes.Enabled = false;
            }
        }

        /// <summary>
        /// Cambiar color de botones a azul más intenso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCursos_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Retornar color de botones a su tono original más oscuro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCursos_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Navy;
        }

        // * * * * * * * * * 
        // Navegación por sección Negocio del módulo Matrícula
        // * * * * * * * * * 

        /// <summary>
        /// Ir al User Control de Cursos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCursos_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlCursos());
        }

        /// <summary>
        /// Ir al User Control de Oferta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOferta_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlOferta());
        }

        /// <summary>
        /// Ir al User Control de Matrícula Presencial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatPres_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlMatriculaPres1());
        }

        // * * * * * * * * * 
        // Navegación por sección Reporte del módulo Matrícula
        // * * * * * * * * * 

        /// <summary>
        /// Ir al User Control de Participantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            MainForm.panel.Controls.Clear();
            MainForm.panel.Controls.Add(new ControlParticipantes());
        }

    }
}
