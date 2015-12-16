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
    public partial class RegistrarCurso : Form
    {
        public RegistrarCurso()
        {
            InitializeComponent();
        }

        private void RegistrarCurso_Load(object sender, EventArgs e)
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

                txtbFechaReg.Text = DateTime.Now.ToString();
                txtbUltMod.Text = DateTime.Now.ToString();

                txtbTotal.Text = "0";
                nudGrupo.Value = new CursosNeg().ObtenerCantidadCursos() + 1;
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT008", ex);
            }
        }

        /// <summary>
        /// Cerrar el Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        /// <summary>
        /// Guardar nuevo curso en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ECurso nuevo = new ECurso();
                nuevo.Codigo = txtbCodigo.Text;
                nuevo.IdOferta = Convert.ToInt16(cmbOferta.SelectedValue);
                nuevo.NombreOferta = cmbOferta.Text;
                nuevo.IdEstado = 1;
                nuevo.NombreEstado = txtbEstado.Text;
                nuevo.IdTipo = Convert.ToInt16(cmbTipo.SelectedValue);
                nuevo.NombreTipo = cmbTipo.Text;
                nuevo.Nombre = txtbNombre.Text;
                nuevo.IdSede = Convert.ToInt16(cmbSede.SelectedValue);
                nuevo.NombreSede = cmbSede.Text;
                nuevo.Facilitador = txtbFacilitador.Text;
                nuevo.Horario = txtbHorario.Text;
                nuevo.PoblacionMeta = txtbPobMeta.Text;
                nuevo.FechaRegistro = DateTime.Parse(txtbFechaReg.Text);
                nuevo.UltimaModificacion = DateTime.Parse(txtbUltMod.Text);
                nuevo.NumeroGrupo = Convert.ToInt16(nudGrupo.Value);
                nuevo.CursoRequisitoDe = txtbRequisitoDe.Text;
                nuevo.Observaciones = txtbObservaciones.Text;
                nuevo.MatriculaPresencial = rbMatPresSi.Checked;
                nuevo.MatriculaTelefonica = rbMatTelSi.Checked;
                nuevo.MatriculaEnLinea = rbMatLinSi.Checked;
                nuevo.CantidadPresTel = Convert.ToInt16(nudCantidadPres.Value);
                nuevo.CantidadEnLinea = Convert.ToInt16(nudEnLinea.Value);
                nuevo.ListaDeEspera = rbEsperaSi.Checked;
                nuevo.Total = Convert.ToInt16(txtbTotal.Text);

                nuevo.LoginUsuario = MainForm.sesion.Login;

                if (nuevo.DatosValidos())
                {
                    if (new CursosNeg().RegistrarCurso(nuevo))
                    {
                        MessageBox.Show("El curso '" + nuevo.Nombre + "' se registró exitosamente", 
                                        "Éxito");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("El grupo '" + nuevo.Codigo + " - " + nuevo.NumeroGrupo + "' " +
                            "ya se encuentra registrado para la oferta '" + nuevo.NombreOferta + "' de " +
                            "la sede '" + nuevo.NombreSede + "'", "Ya existe");
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
                MainForm.NotificarExcepcion("CU MAT008", ex);
            }
        }

        /// <summary>
        /// Asignar valor a Total cuando haya algún cambio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (string.IsNullOrWhiteSpace(txtbFacilitador.Text) )
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
