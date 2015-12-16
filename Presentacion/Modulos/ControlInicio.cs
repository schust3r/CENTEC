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
using Presentacion.Modulos.Configuracion.cPerfil;
using Presentacion.Modulos.Configuracion.cUsuario;
using Presentacion.Modulos.Configuracion.cBitacora;
using Presentacion.Modulos.Matricula.cOferta;
using Presentacion.Modulos.Matricula.cMatricula;
using Presentacion.Modulos.Matricula.cParticipantes;

namespace Presentacion.Modulos
{
    public partial class ControlInicio : UserControl
    {

        private ESesion sesion;

        public ControlInicio()
        {
            InitializeComponent();

            // Configurar panel con detalles y hábitos del usuario
            MainForm.EstablecerSesion();
            this.sesion = MainForm.sesion;
            EstablecerAccionesMasUtilizadas();
            SetInfoUsuario();
        }

        /// <summary>
        /// Mostrar los detalles básicos de la cuenta en la pantalla de inicio
        /// </summary>
        private void SetInfoUsuario()
        {
            lblLogin.Text = sesion.Login;
            lblNombre.Text = sesion.Nombre;
            lblPerfil.Text = sesion.NombrePerfil;
        }

        /// <summary>
        /// Configurar acciones más utilizadas en lógica de negocios
        /// </summary>
        private void EstablecerAccionesMasUtilizadas()
        {
            List<string> acciones = new UsuarioNeg().AccionesMasUtilizadas(sesion.Login);
            for (int i = 0; i < acciones.Count; i++)
            {
                LinkButton(acciones[i], i);
            }
        }

        /// <summary>
        /// Configurar botones para efectuar acciones más utilizadas por el usuario
        /// </summary>
        /// <param name="accion">string con nombre de la acción</param>
        /// <param name="index">índice actual del item</param>
        private void LinkButton(string accion, int index)
        {
            Button btn = btnAccion1;
            switch (index)
            {
                case 0: btn = btnAccion1; break;
                case 1: btn = btnAccion2; break;
                case 2: btn = btnAccion3; break;
                case 3: btn = btnAccion4; break;
                case 4: btn = btnAccion5; break;
            }

            if (accion == "Registrar perfil" || accion == "Modificar perfil"
                || accion == "Eliminar perfil")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlPerfil());
                };
            }

            if (accion == "Registrar usuario" || accion == "Modificar usuario"
                || accion == "Eliminar usuario")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlUsuario());
                };
            }

            if (accion == "Consultar bitácora")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlCurso());
                };
            }

            if (accion == "Registrar oferta" || accion == "Modificar oferta"
                || accion == "Eliminar oferta" || accion == "Cambiar estado de oferta")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlOferta());
                };
            }

            if (accion == "Registrar curso" || accion == "Modificar curso"
                || accion == "Eliminar curso" || accion == "Cambiar estado de curso")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlCurso());
                };
            }

            if (accion == "Matrícula presencial")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlMatriculaPres1());
                };
            }

            if (accion == "Imprimir comprobante" || accion == "Cambiar estado de participante")
            {
                btn.Text = accion;
                btn.Click += (s, e) => {
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlParticipantes());
                };
            }
            
        }

    }
}
