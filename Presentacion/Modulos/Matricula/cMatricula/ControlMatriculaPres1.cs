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
using LogicaNegocios.modMatricula;
using Entidades.eMatricula;
using System.Media;
using Presentacion.Properties;

namespace Presentacion.Modulos.Matricula.cMatricula
{
    public partial class ControlMatriculaPres1 : UserControl
    {

        private ESesion sesion;

        public ControlMatriculaPres1()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
        }

        /// <summary>
        /// Load de primera parte de Matricula Presencial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlMatriculaPres1_Load(object sender, EventArgs e)
        {
            try
            {
                txtbSede.Text = sesion.Sede;

                cmbTipoMat.DataSource = new MatriculaNeg().CargarListaTipos();
                cmbTipoMat.DisplayMember = "Tipo";
                cmbTipoMat.ValueMember = "ID";
                cmbTipoMat.Text = "Presencial";

                CargarTablaCursos();
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT011", ex);
            }
        }

        private void CargarTablaCursos()
        {
            try
            {
                // Reiniciar contenidos del DataGridView
                GridCursos.DataSource = null;
                GridCursos.Rows.Clear();
                GridCursos.Refresh();

                DataView info = new MatriculaNeg().ConsultarCursos(sesion.IdSede);
                GridCursos.DataSource = info;

                GridCursos.Columns["Disponible"].Visible = false;
                GridCursos.Columns["Requisitos"].Visible = false;
                GridCursos.Columns["Observaciones"].Visible = false;
                GridCursos.Columns["Cod"].Visible = false;
                GridCursos.Columns["Presencial"].Visible = false;
                GridCursos.Columns["Telefonica"].Visible = false;
                GridCursos.Columns["ListaEspera"].Visible = false;
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT006", ex);
            }
        }

        /// <summary>
        /// Mostrar información del curso al pasar el mouse sobre el mismo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridCursos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtbReq.Text = GridCursos.Rows[e.RowIndex].Cells["Requisitos"].Value.ToString();
                txtbObservaciones.Text = GridCursos.Rows[e.RowIndex].Cells["Observaciones"].Value.ToString();
                txtbCupos.Text = GridCursos.Rows[e.RowIndex].Cells["Disponible"].Value.ToString();
            }
        }

        /// <summary>
        /// Evitar que el usuario seleccione más cupos de lo posible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudAReservar_ValueChanged(object sender, EventArgs e)
        {
            int cuposMax = Convert.ToInt16(txtbCupos.Text);
            if (nudAReservar.Value > cuposMax)
            {
                if (cuposMax == 0)
                {
                    nudAReservar.Value = 1;
                }
                else
                {
                    nudAReservar.Value = cuposMax;
                }
            }
        }

        /// <summary>
        /// Reservar la cantidad de cupos si es posible, para 
        /// el curso seleccionado por el Encargado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservar_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridCursos.SelectedRows.Count != 0)
                {
                    DataGridViewRow row = GridCursos.SelectedRows[0];
                    string codCurso = row.Cells["Cod"].Value.ToString();
                    string nomCurso = row.Cells["Nombre"].Value.ToString();
                    int cupos = Convert.ToInt16(nudAReservar.Value);
                    bool aceptaPresencial = Convert.ToBoolean(row.Cells["Presencial"].Value.ToString());
                    bool aceptaTelefonica = Convert.ToBoolean(row.Cells["Telefonica"].Value.ToString());
                    bool aceptaEspera = Convert.ToBoolean(row.Cells["ListaEspera"].Value.ToString());

                    EMatriculaPres reserva = new EMatriculaPres();
                    reserva.Codigo = codCurso;
                    reserva.Cupos = cupos;

                    // Verificar si el curso acepta el tipo de matrícula elegido
                    if (cmbTipoMat.Text == "Presencial" && aceptaPresencial ||
                        cmbTipoMat.Text == "Telefónica" && aceptaTelefonica)
                    {
                        // Comprobar si la matrícula fue aceptada por el servidor
                        if (new MatriculaNeg().ReservarCupos(reserva) &&
                            Convert.ToInt16(txtbCupos.Text) >= cupos)
                        {
                            MainForm.panel.Controls.Clear();
                            EMatriculaPres infoMatricula = new EMatriculaPres();

                            infoMatricula.Codigo = codCurso;
                            infoMatricula.NombreCurso = nomCurso;
                            infoMatricula.IdTipoMatricula = Convert.ToInt16(cmbTipoMat.SelectedValue);
                            infoMatricula.Cupos = cupos;
                            infoMatricula.AceptaEspera = aceptaEspera;

                            ControlMatriculaPres2 paso2 = new ControlMatriculaPres2(infoMatricula);
                            MainForm.panel.Controls.Add(paso2);
                            paso2.BloquearBotones();
                        }
                        else
                        {
                            MessageBox.Show("Acción no válida. Reintente más tarde.",
                                            "Imposible continuar");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El curso no acepta el tipo de matrícula seleccionado.",
                                        "Imposible continuar");
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("MAT011", ex);
            }
        }


    }
}
