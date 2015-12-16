using Entidades;
using LogicaNegocios.modConfiguracion;
using Presentacion.Inicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Modulos.Configuracion.cUsuario
{
    public partial class RegistrarUsuario : Form
    {
        // Atributo de sesion desde MainForm
        private ESesion sesion;

        public RegistrarUsuario()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            PrecargarComboboxes();
        }

        private void PrecargarComboboxes()
        {
            try {
                cmbSede.DataSource = new UsuarioNeg().CargarListaSedes();
                cmbSede.DisplayMember = "Sede";
                cmbSede.ValueMember = "ID";

                cmbPerfil.DataSource = new PerfilNeg().CargarListaPerfiles();
                cmbPerfil.DisplayMember = "Perfil";
                cmbPerfil.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON008", ex);
            }
        }

        /// <summary>
        /// Cerrar la ventana de registro de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Registrar un usuario si el login dispone de permisos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try {
                if (sesion.permisos.RegistrarUsuario)
                {
                    EUsuario nuevo = new EUsuario();

                    nuevo.LoginUsuario = sesion.Login;
                    nuevo.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                    nuevo.Login = txtbLogin.Text;
                    nuevo.Contrasena = txtbContrasena.Text;
                    nuevo.IdPerfil = Convert.ToInt16(cmbPerfil.SelectedValue);
                    nuevo.NombrePerfil = cmbPerfil.SelectedText;
                    nuevo.Nombre = txtbNombre.Text;
                    nuevo.Activo = RdSi.Checked;

                    if (nuevo.DatosValidos())
                    {
                        new UsuarioNeg().RegistrarUsuario(nuevo);
                        MessageBox.Show("El usuario '" + nuevo.Login +
                                        "' se registró exitosamente.", "Éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar el registro.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON008", ex);
            }
        }


        private void txtbLogin_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbLogin.Text))
            {
                errorLogin.SetError(txtbLogin, "Login no puede ser vacío");
            }
            else
            {
                errorLogin.Clear();
            }
        }

        private void txtbContrasena_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbContrasena.Text))
            {
                errorPass.SetError(txtbContrasena, "Contraseña no puede quedar en blanco");
            }
            if (txtbContrasena.Text.Length < 5)
            {
                errorPass.SetError(txtbContrasena, "La contraseña debe tener al menos 5 caracteres.");
            }
            else
            {
                errorPass.Clear();
            }
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                errorNombre.SetError(txtbNombre, "Nombre de usuario no puede ser vacío");
            }
            else
            {
                errorNombre.Clear();
            }
        }

    }
}
