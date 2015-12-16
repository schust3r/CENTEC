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

namespace Presentacion.Modulos.Matricula.cMatricula
{
    public partial class CambiarEstado : Form
    {

        private ESesion sesion;
        private string referer;
        private string idItem;
        private string estadoAnterior;
        private string infoItem;

        public CambiarEstado(string referer, string idItem, 
                            string estadoAnterior, string info)
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            this.referer = referer;
            this.idItem = idItem;
            this.estadoAnterior = estadoAnterior;
            this.infoItem = info;
        }

        /// <summary>
        /// Cerrar la ventana de cambio de estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Precargar valores de acuerdo con el referer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CambiarEstado_Load(object sender, EventArgs e)
        {
            try {
                switch (referer)
                {
                    case "oferta":
                        GridHistorial.DataSource = new OfertasNeg().CargarHistorialOferta(int.Parse(idItem));
                        cmbNuevoEst.DataSource = new OfertasNeg().CargarListaEstados();
                        cmbNuevoEst.DisplayMember = "Estado";
                        cmbNuevoEst.ValueMember = "ID";
                        break;

                    case "curso":
                        GridHistorial.DataSource = new CursosNeg().CargarHistorialCurso(idItem);
                        cmbNuevoEst.DataSource = new CursosNeg().CargarListaEstados();
                        cmbNuevoEst.DisplayMember = "Estado";
                        cmbNuevoEst.ValueMember = "ID";
                        break;

                    case "participante":
                        GridHistorial.DataSource = new ParticipantesNeg().CargarHistorialParticipante(int.Parse(idItem));
                        cmbNuevoEst.DataSource = new ParticipantesNeg().CargarListaEstados();
                        cmbNuevoEst.DisplayMember = "Estado";
                        cmbNuevoEst.ValueMember = "ID";
                        break;
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT_EST", ex);
            }
        }

        /// <summary>
        /// Aplicar cambios realizados sobre el estado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCambiarEst_Click(object sender, EventArgs e)
        {
            try
            {
                switch (referer)
                {
                    /** Para la OFERTA **/
                    case "oferta":
                        EOferta histOferta = new EOferta();
                        histOferta.Nombre = infoItem;
                        histOferta.IdOferta = Convert.ToInt16(idItem);
                        histOferta.IdEstado = Convert.ToInt16(cmbNuevoEst.SelectedValue);
                        histOferta.LoginUsuario = sesion.Login;
                        histOferta.Observacion = txtbObservaciones.Text;
                        histOferta.FechaRegistro = DateTime.Now;

                        if (txtbObservaciones.Text.Replace(" ", "").Equals(""))
                        {
                            MessageBox.Show("Por favor indique una observación.", "Error");
                            break;
                        }

                        if (new OfertasNeg().CambiarEstadoOferta(histOferta, estadoAnterior, cmbNuevoEst.Text))
                        {
                            MessageBox.Show("El estado de la oferta se cambió exitosamente.", "Éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se puede realizar el cambio de estado.", "Error");
                        }
                        break;

                    /** Para un CURSO **/
                    case "curso":
                        ECurso histCurso = new ECurso();
                        histCurso.Nombre = infoItem;
                        histCurso.Codigo = idItem;
                        histCurso.IdEstado = Convert.ToInt16(cmbNuevoEst.SelectedValue);
                        histCurso.LoginUsuario = sesion.Login;
                        histCurso.Observaciones = txtbObservaciones.Text;
                        histCurso.FechaRegistro = DateTime.Now;

                        if (txtbObservaciones.Text.Replace(" ", "").Equals(""))
                        {
                            MessageBox.Show("Por favor indique una observación.", "Error");
                            break;
                        }

                        if (new CursosNeg().CambiarEstadoCurso(histCurso, estadoAnterior, cmbNuevoEst.Text))
                        {
                            MessageBox.Show("El estado del curso se cambió exitosamente.", "Éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se puede realizar el cambio de estado.", "Error");
                        }
                        break;

                    /** Para el PARTICIPANTE **/
                    case "participante":
                        EParticipante histPart = new EParticipante();
                        histPart.Identificacion = infoItem;
                        histPart.IdParticipante = Convert.ToInt16(idItem);
                        histPart.IdEstado = Convert.ToInt16(cmbNuevoEst.SelectedValue);
                        histPart.LoginUsuario = sesion.Login;
                        histPart.Observaciones = txtbObservaciones.Text;
                        histPart.FechaMatricula = DateTime.Now;

                        if (txtbObservaciones.Text.Replace(" ", "").Equals(""))
                        {
                            MessageBox.Show("Por favor indique una observación.", "Error");
                            break;
                        }

                        if (new ParticipantesNeg().CambiarEstadoParticipante(histPart, 
                                                      estadoAnterior, cmbNuevoEst.Text))
                        {
                            MessageBox.Show("El estado del participante se cambió exitosamente.", "Éxito");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se puede realizar el cambio de estado.", "Error");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU MAT_EST", ex);
            }
        }

    }
}
