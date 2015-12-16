using Entidades.eMatricula;
using LogicaNegocios.modMatricula;
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

namespace Presentacion.Modulos.Matricula.cCursos
{
    public partial class CursoVerDetalles: Form
    {

        private ESesion sesion;

        public CursoVerDetalles()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Cargar los datos de un curso con su código
        /// </summary>
        /// <param name="codCurso"></param>
        public void SetDatos(string codCurso)
        {
            try
            {
                DataRow info = new CursosNeg().CargarCurso(codCurso);
                CargarComboboxes();

                txtbCodigo.Text = codCurso;
                txtbEstado.Text = info["EstadoCurso"].ToString();

                cmbTipo.Text = info["NombreTipo"].ToString();
                cmbSede.Text = info["NombreSede"].ToString();
                cmbOferta.Text = info["NombreOferta"].ToString();

                txtbNombre.Text = info["NombreCurso"].ToString();
                txtbFacilitador.Text = info["Facilitador"].ToString();
                txtbPobMeta.Text = info["PoblacionMeta"].ToString();
                txtbHorario.Text = info["Horario"].ToString();
                txtbFechaReg.Text = info["FechaRegistro"].ToString();
                nudGrupo.Value = Convert.ToInt16(info["NumeroGrupo"]);
                txtbRequisitoDe.Text = info["CursoRequisitoDe"].ToString();
                txtbObservaciones.Text = info["Observaciones"].ToString();

                rbMatPresSi.Checked = Convert.ToBoolean(info["MatriculaPresencial"]);
                rbMatTelSi.Checked = Convert.ToBoolean(info["MatriculaTelefonica"]);

                var test = Convert.ToBoolean(info["MatriculaEnLinea"]);

                rbMatLinSi.Checked = Convert.ToBoolean(info["MatriculaEnLinea"]);
                rbEsperaSi.Checked = Convert.ToBoolean(info["ListaEspera"]);

                nudCantidadPres.Value = Convert.ToInt16(info["CantidadPresencialTelefonica"]);
                nudEnLinea.Value = Convert.ToInt16(info["CantidadEnLinea"]);

                // Deshabilitar Up-Downs
                nudCantidadPres.Enabled = false;
                nudEnLinea.Enabled = false;
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT007", ex);
            }
        }

        /// <summary>
        /// Carga de componentes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargarComboboxes()
        {
            try
            {
                cmbSede.DataSource = new CursosNeg().CargarListaSedes();
                cmbSede.DisplayMember = "Sede";
                cmbSede.ValueMember = "ID";

                cmbOferta.DataSource = new CursosNeg().CargarListaOfertas();
                cmbOferta.DisplayMember = "Oferta";
                cmbOferta.ValueMember = "ID";

                cmbTipo.DataSource = new CursosNeg().CargarListaTipos();
                cmbTipo.DisplayMember = "Tipo";
                cmbTipo.ValueMember = "ID";

                txtbUltMod.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT007", ex);
            }
        }

        /// <summary>
        /// Habilitar el botón de guardar y los cambios si el usuario tiene los
        /// privilegios para hacerlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.ModificarCurso)
            {
                cmbOferta.Enabled = true;
                cmbTipo.Enabled = true;
                txtbNombre.Enabled = true;
                cmbSede.Enabled = true;
                txtbFacilitador.Enabled = true;
                txtbPobMeta.Enabled = true;
                txtbHorario.Enabled = true;
                txtbRequisitoDe.Enabled = true;
                txtbObservaciones.Enabled = true;
                rbMatLinNo.Enabled = true;
                rbMatLinSi.Enabled = true;
                rbMatPresSi.Enabled = true;
                rbMatPresNo.Enabled = true;
                rbMatTelNo.Enabled = true;
                rbMatTelSi.Enabled = true;
                rbEsperaSi.Enabled = true;
                rbEsperaNo.Enabled = true;
                nudCantidadPres.Enabled = true;
                nudEnLinea.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        //  *** Listeners para cambios sobre RadioButtons  *** //
        private void rbMatPresSi_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadPres.Enabled = true;
        }

        private void rbMatTelSi_CheckedChanged(object sender, EventArgs e)
        {
            nudCantidadPres.Enabled = true;
        }

        private void rbMatTelNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMatPresSi.Checked)
            {
                nudCantidadPres.Enabled = false;
            }
        }

        private void rbMatPresNo_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMatTelSi.Checked)
            {
                nudCantidadPres.Enabled = false;
            }
        }

        private void rbMatLinNo_CheckedChanged(object sender, EventArgs e)
        {
            nudEnLinea.Enabled = false;
        }

        private void rbMatLinSi_CheckedChanged(object sender, EventArgs e)
        {
            nudEnLinea.Enabled = true;
        }
        // *** Fin de listeners para RadioButtons *** //

        /// <summary>
        /// Cerrar la ventana de modificacion de curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Guardar cambios en el curso
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ECurso mod = new ECurso();

                mod.Codigo = txtbCodigo.Text;
                mod.IdOferta = Convert.ToInt16(cmbOferta.SelectedValue);
                mod.NombreOferta = cmbOferta.Text;
                mod.IdTipo = Convert.ToInt16(cmbTipo.SelectedValue);
                mod.NombreTipo = cmbTipo.Text;
                mod.Nombre = txtbNombre.Text;
                mod.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                mod.NombreSede = cmbSede.Text;
                mod.Facilitador = txtbFacilitador.Text;
                mod.Horario = txtbHorario.Text;
                mod.PoblacionMeta = txtbPobMeta.Text;
                mod.UltimaModificacion = DateTime.Parse(txtbUltMod.Text);
                mod.CursoRequisitoDe = txtbRequisitoDe.Text;
                mod.Observaciones = txtbObservaciones.Text;
                mod.MatriculaPresencial = rbMatPresSi.Checked;
                mod.MatriculaTelefonica = rbMatTelSi.Checked;
                mod.MatriculaEnLinea = rbMatLinSi.Checked;
                mod.CantidadPresTel = Convert.ToInt16(nudCantidadPres.Value);
                mod.CantidadEnLinea = Convert.ToInt16(nudEnLinea.Value);
                mod.ListaDeEspera = rbEsperaSi.Checked;
                mod.LoginUsuario = sesion.Login;

                if (mod.DatosValidos())
                {
                    if (new CursosNeg().ModificarCurso(mod))
                    {
                        MessageBox.Show("El curso '" + mod.Nombre + "' se modificó exitosamente.",
                                        "Éxito");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Revise que los datos en los campos sean correctos.",
                                          "Error");
                }

            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT009", ex);
            }
        }


        // Listeners para cambios en Controles

        private void nudCantidadPres_ValueChanged(object sender, EventArgs e)
        {
            txtbTotal.Text = (nudCantidadPres.Value + nudEnLinea.Value).ToString();
        }

        private void txtbCodigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbCodigo.Text))
            {
                errorCodigo.SetError(txtbCodigo, "El código no puede quedar en blanco.");
            }
            else
            {
                errorCodigo.Clear();
            }
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                errorNombre.SetError(txtbNombre, "El nombre no puede quedar vacío.");
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void txtbFacilitador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbFacilitador.Text))
            {
                errorFacilitador.SetError(txtbFacilitador, "El facilitador debe ser un nombre válido.");
            }
            else
            {
                errorFacilitador.Clear();
            }
        }

        private void txtbPobMeta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbPobMeta.Text))
            {
                errorPobMeta.SetError(txtbPobMeta, "El facilitador debe ser un nombre válido.");
            }
            else
            {
                errorPobMeta.Clear();
            }
        }

        private void txtbHorario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbHorario.Text))
            {
                errorHorario.SetError(txtbHorario, "El facilitador debe ser un nombre válido.");
            }
            else
            {
                errorHorario.Clear();
            }
        }


    }
}
