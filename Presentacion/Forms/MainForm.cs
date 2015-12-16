using Presentacion.Modulos.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Modulos;
using Presentacion.cLogin;
using Entidades;
using LogicaNegocios.modConfiguracion;
using Presentacion.Modulos.Matricula;
using Presentacion.Properties;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace Presentacion.Inicio
{
    /// <summary>
    /// WinForm general que contiene los botones de Inicio, Ayuda, Salir, y los 
    /// controles para los módulos Matrícula y Configuración. Contiene un panel único
    /// que cambia su contenido según la navegación del usuario.
    /// </summary>
    public partial class MainForm : Form
    {

        public static ESesion sesion;
        public static Panel   panel;

        public MainForm(ESesion s)
        {
            // Inicializar interfaz de aplicación
            InitializeComponent();
            this.DoubleBuffered = true;

            // Indicar sesión y panel principal estáticos del Form
            sesion = s;
            panel = this.MainPanel;
            this.MainPanel.Controls.Add(new ControlInicio());
            btnInicio.Enabled = false;
        }

        /// <summary>
        /// Activar buffering doble desde el nivel de Forms. Todos los controles
        /// hijos también activan el buffering doble. Reduce considerablemente el
        /// flicker o parpadeo entre transiciones. Se altera el flag WS_EX_TRANSPARENT
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= 0x02000000; // WS_EX_COMPOSITED  
                return createParams;
            }
        }

        /// <summary>
        /// Actualizar datos de la sesión actual por si el usuario ha cambiado
        /// detalles de su propia cuenta
        /// </summary>
        public static void EstablecerSesion()
        {
            try
            {
                ESesion nSesion = new ESesion();
                List<string> datosUser = new UsuarioNeg().CargarUsuario(sesion.Login);
                DataRow permConfUser = new PerfilNeg().CargarPerfil(int.Parse(datosUser[6]));
                nSesion.DefinirSesion(datosUser, permConfUser);
                sesion = nSesion;
            }
            catch (Exception ex)
            {
                NotificarExcepcion("Actualizar sesión", ex);
            }
        }

        /// <summary>
        /// Abrir la documentación de inicio en una sección específica, según
        /// la acción actual del usuario.
        /// </summary>
        public void MostrarAyuda()
        {
            try
            {
                string ubicacion = Path.Combine(Path.GetTempPath(), "apoyo.chm");
                File.WriteAllBytes(ubicacion, Resources.ayuda);  
                Process.Start(ubicacion); // Correr el archivo
            }
            catch { }
        }

        // BLoquear botones para matrícula
        public void LockButtons()
        {
            btnInicio.Enabled = false;
            btnSalir.Enabled = false;
            btnConfiguracion.Enabled = false;
            btnMatricula.Enabled = false;
        }

        // Desbloquear botones tras matrícula
        public void UnlockButtons()
        {
            btnInicio.Enabled = true;
            btnSalir.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnMatricula.Enabled = true;
        }

        /// <summary>
        /// Recibir excepciones si las hay de otras partes del programa
        /// y registrarlas en la bitácora de forma segura
        /// </summary>
        /// <param name="ex"></param>
        public static void NotificarExcepcion(string accion, Exception ex)
        {
            try
            {
                EBitacora error = new EBitacora();

                error.LoginUsuario = sesion.Login;
                error.Accion = accion;
                error.TipoEvento = "Excepción";
                error.Descripcion = "Se ha presentado un error grave. Detalles del error: " +
                                    "StackTrace: " + ex.StackTrace + " / " +
                                    "Mensaje: " + ex.Message;
                error.Entidad = "No disponible";

                new ReporteNeg().RegistrarBitacora(error);

                try
                {
                    SoundPlayer snd = new SoundPlayer(Resources.voz_crash);
                    snd.Play();
                }
                catch { }

                // Mostrar MessageBox y notificar visiblemente al usuario
                MessageBox.Show("Se ha presentado un error inesperado. " +
                                "Por favor, contacte a su administrador.",
                                "Error grave");
            }
            catch // Aquí se revienta
            {
                // Mostrar MessageBox y notificar visiblemente al usuario
                MessageBox.Show("El programa ha sufrido un error irrecuperable. " + 
                                "Por favor, contacte a su administrador.",
                                "Excepción fatal");
            } 
        }

        /**
         * Botones superiores: 'INICIO', 'VER AYUDA' y 'CANCELAR'
         */ 

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(new ControlInicio());
            btnInicio.Enabled = false;
        }

        private void btnVerAyuda_Click(object sender, EventArgs e)
        {
            MostrarAyuda();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer snd = new SoundPlayer(Resources.voz_salir);
                snd.Play();
            }
            catch { }
            this.Close();
        }

        /**
         * Botones de módulos: 'CONFIGURACIÓN' y 'MATRÍCULA'
         */

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(new ControlConfiguracion());
            btnConfiguracion.Enabled = false;
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(new ControlMatricula());
            btnMatricula.Enabled = false;
        }

        /// <summary>
        /// Deshabilita el botón Inicio si ya se encuentra en la pantalla principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            btnInicio.Enabled = true;
            btnConfiguracion.Enabled = true;
            btnMatricula.Enabled = true;
        }


        /// <summary>
        /// Asignar color azul a texto cuando entra el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseEnter(object sender, EventArgs e)
        {
            btnMatricula.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Regresar color negro del texto cuando sale el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricula_MouseLeave(object sender, EventArgs e)
        {
            btnMatricula.ForeColor = Color.Black;
        }

        /// <summary>
        /// Asignar color azul a texto cuando entra el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            btnConfiguracion.ForeColor = Color.Blue;
        }

        /// <summary>
        /// Regresar color negro del texto cuando sale el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            btnConfiguracion.ForeColor = Color.Black;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
