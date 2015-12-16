using LogicaNegocios.Login;
using LogicaNegocios.modConfiguracion;
using Presentacion.Inicio;
using Presentacion.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.cLogin
{
    /// <summary>
    /// WinForm específica para iniciar sesión. Primera ventana de la aplicación
    /// en la que el usuario realiza la acción de validar su cuenta e ingresar al
    /// sistema de matrícula CENTEC con su login y contraseña.
    /// </summary>
    public partial class Login : Form
    {

        public Login()
        {
            opacarForm(); // Llamar animación de "Fade In" u Opacado.
            InitializeComponent();
            this.DoubleBuffered = true; // Habilitar búffer doble
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
                createParams.ExStyle |= 0x02000000; // WS_EX_TRANSPARENT
                return createParams;
            }
        }

        /// <summary>
        /// Método para animación de opacado al inicio de la aplicación. El Form
        /// afectado y sus componentes pasan de una opacidad mínima a su opacidad
        /// total (transición de this.Opacity de 0.0d a 1.0d en una serie de pasos)
        /// </summary>
        private void opacarForm()
        {
            int duracion = 200; // en milisegundos
            int pasos = 30;
            Timer timer = new Timer();
            timer.Interval = duracion / pasos;

            int pasoActual = 0;
            timer.Tick += (arg1, arg2) =>
            {
                // Calcular una fracción para configurar la opacidad gradualmente
                Opacity = ((double) pasoActual) / pasos;
                pasoActual++;

                if (pasoActual >= pasos)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        /// <summary>
        /// Método para iniciar sesión que puede ser llamado desde varios eventos. El sistema
        /// toma el texto de los campos Login y Contraseña y accede hasta la capa de datos para
        /// verificar si algún usuario coincide con la información indicada.
        /// </summary>
        private async void IniciarSesion()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                MostrarAnimacion();
                await Task.Delay(1200);
                if (!txtbLogin.Text.Equals("") && !txtbPass.Text.Equals(""))
                {
                    if (new LoginNeg().IntentarIngreso(txtbLogin.Text, txtbPass.Text))
                    {
                        // Cargar datos de usuario a partir de informacion de login
                        ESesion sesion = new ESesion();
                        sesion.Login = txtbLogin.Text.ToLower();

                        // Crear y mostrar ventana modal "main" como única instancia del MainForm
                        var main = new MainForm(sesion);

                        try {
                            SoundPlayer snd = new SoundPlayer(Resources.voz_bienv);
                            snd.Play();
                        }
                        catch { }

                        main.ShowDialog();

                        // Restaurar controles y reiniciar texto de los Entrys
                        RestaurarControles();
                    }
                    else
                    {
                        MessageBox.Show(this, "Se presentó un problema al validar su usuario. Por favor " + 
                                              "contacte al administrador del sistema.", "Error al ingresar");
                        RestaurarControles();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Ha dejado algún espacio sin completar. " +
                                          "Por favor complete los campos.", "Campos inválidos");
                    RestaurarControles();
                }
            }
            catch
            {
                // Informar de excepción aquí
                MessageBox.Show(this, "Se ha presentado un error no controlado. Por favor contacte a su administrador.",
                                      "Error grave");
                RestaurarControles();
            }
        }

        /// <summary>
        /// Esconde el logo del Form y muestra una animación durante 1 segundo
        /// mientras se verifican los datos del usuario.
        /// </summary>
        private void MostrarAnimacion()
        {
            pnlLogo.Visible = false;
            loadPanel.Enabled = true;
            loadPanel.Visible = true;
        }

        /// <summary>
        /// Esconde las imágenes de animación y vuelve a mostrar los controles
        /// y el logo en el Form. Enfoca el campo de usuario para escribir el login.
        /// </summary>
        private void RestaurarControles()
        {
            txtbLogin.Text = "";
            txtbPass.Text = "";
            loadPanel.Visible = false;
            loadPanel.Enabled = false;
            pnlLogo.Visible = true;
            pnlLogin.Visible = true;
            this.txtbLogin.Focus();
        }

        /// <summary>
        /// Evento de ingreso a sesión mediante clic sobre botón 'Ingresar'
        /// </summary>
        /// <param name="sender">Control btnIngresar ('Ingresar', único botón en interfaz)</param>
        /// <param name="e">Argumentos de Evento de clic o Intro sobre botón registrado</param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        /// <summary>
        /// Evento de ingreso a sesión mediante Enter sobre campo Contraseña
        /// </summary>
        /// <param name="sender">Campo de texto txtbPass (espacio para contraseña)</param>
        /// <param name="e">Argumentos de Evento de tecla registrado</param>
        private void txtbPass_KeyDown(object sender, KeyEventArgs e)
        {
            // Si el código de la tecla evento es el mismo que la tecla 'Enter'
            if (e.KeyCode == Keys.Enter)
            {
                IniciarSesion(); // Intentar ingreso a sesión
            }
        }

        /// <summary>
        /// Evento de salida de aplicación mediante clic en el botón Cerrar.
        /// </summary>
        /// <param name="sender">Control btnCerrar (x en esquina superior derecha)</param>
        /// <param name="e">Argumentos de Evento de click/Intro registrado</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}