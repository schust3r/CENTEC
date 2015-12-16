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
    public partial class UsuarioVerDetalles : Form
    {

        // Atributos de sesión desde MainForm
        private ESesion sesion;
        private List<string> userData;

        public UsuarioVerDetalles()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Cargar toda la información de un usuario
        /// </summary>
        /// <param name="lu"></param>
        public void CargarInformacionUsuario(List<string> lu)
        {
            try {
                this.userData = lu;

                cmbSede.DataSource = new UsuarioNeg().CargarListaSedes();
                cmbSede.DisplayMember = "Sede";
                cmbSede.ValueMember = "ID";

                cmbPerfil.DataSource = new PerfilNeg().CargarListaPerfiles();
                cmbPerfil.DisplayMember = "Perfil";
                cmbPerfil.ValueMember = "ID";

                cmbSede.SelectedIndex = cmbSede.FindString(userData[0].ToString());
                txtbLogin.Text = userData[1].ToString();
                cmbPerfil.SelectedIndex = cmbPerfil.FindString(userData[2].ToString());
                txtbNombre.Text = userData[3].ToString();
                SetCheckedRadioButton(userData[4].ToString());
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("Ver detalles de usuario", ex);
            }
        }

        /// <summary>
        /// Manejar los botones radiobutton según el campo Activo
        /// </summary>
        /// <param name="val"></param>
        private void SetCheckedRadioButton(string val)
        {
            if (val == "True") RdSi.Checked = true;
            else RdNo.Checked = true;
        }

        /// <summary>
        /// Habilitar edición al usuario si tiene los permisos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.ModificarUsuario)
            {
                cmbSede.Enabled = true;
                cmbPerfil.Enabled = true;
                txtbNombre.Enabled = true;
                RdSi.Enabled = true;
                RdNo.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        /// <summary>
        /// Guardar modificación de usuario si la cuenta dispone de permisos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EUsuario mod = new EUsuario();

                mod.LoginUsuario = sesion.Login;
                mod.Login = txtbLogin.Text;
                mod.IdPerfil = Convert.ToInt16(cmbPerfil.SelectedValue);
                mod.NombrePerfil = cmbPerfil.SelectedText;
                mod.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                mod.Nombre = txtbNombre.Text;
                mod.Activo = RdSi.Checked;

                if (mod.DatosValidosModificacion())
                {
                    new UsuarioNeg().ModificarUsuario(mod);
                    MessageBox.Show("El usuario '" + mod.Login + "' se modificó " +
                                    "exitosamente.", "Éxito");

                    // Actualizar si el usuario cambió sus detalles
                    MainForm.EstablecerSesion(); 

                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo completar la operación.", "Error");
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON009", ex);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
