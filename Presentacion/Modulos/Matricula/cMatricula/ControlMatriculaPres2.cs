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
using System.Collections;
using System.Media;
using Presentacion.Properties;

namespace Presentacion.Modulos.Matricula.cMatricula
{
    public partial class ControlMatriculaPres2 : UserControl
    {
        private ESesion sesion;
        private string codCurso;
        private string nomCurso;
        private int idTipoMat;
        private int numParticipantes;
        private bool aceptaListaEspera;

        // Para la cuenta regresiva
        private Timer timer1;
        private int temporizador = 300;

        public ControlMatriculaPres2(EMatriculaPres detalles)
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            this.codCurso = detalles.Codigo;
            this.nomCurso = detalles.NombreCurso;
            this.idTipoMat = detalles.IdTipoMatricula;
            this.numParticipantes = detalles.Cupos;
            this.aceptaListaEspera = detalles.AceptaEspera;

            // Inicia la cuenta regresiva
            IniciarTemporizador(); 
        }

        /// <summary>
        /// Comienza el conteo regresivo desde 300 segundos (5 min)
        /// </summary>
        private void IniciarTemporizador()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; // 1 segundo
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temporizador--;
            if (temporizador == 0)
            {
                timer1.Stop();
                AbortarSesionMat();
            }
            TimeSpan t = TimeSpan.FromSeconds(temporizador);
            lblTiempo.Text = t.ToString(@"m\:ss");
        }

        public void BloquearBotones()
        {
            MainForm par = (MainForm)this.ParentForm;
            par.LockButtons();
        }

        /// <summary>
        /// Load para el paso 2 de la matricula presencial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ControlMatriculaPres2_Load(object sender, EventArgs e)
        {
            txtbSede.Text = sesion.Sede;

            for (int i = 0; i < numParticipantes; i++)
            {
                GridCupos.Rows.Add();
                GridCupos.Rows[i].Cells["ListaEspera"].Value = "No";
                GridCupos.Rows[i].Cells["Cursos"].Value = nomCurso;
            }

            GridCupos.Columns["ListaEspera"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            GridCupos.DefaultCellStyle.NullValue = "";

            try
            {
                SoundPlayer snd = new SoundPlayer(Resources.voz_5cont);
                snd.Play();
            }
            catch { }
        }

        /// <summary>
        /// Abortar la sesión completamente si se acaba el tiempo o bien,
        /// si el matriculador decide salir del proceso.
        /// </summary>
        private void AbortarSesionMat()
        {
            try {
                // Crear entidad de matrícula
                EMatriculaPres abort = new EMatriculaPres();
                abort.Codigo = codCurso;
                abort.Cupos = numParticipantes;

                // 'Devolver' los cupos tomados
                new MatriculaNeg().LiberarCuposMatricula(abort);

                MainForm par = (MainForm)this.ParentForm;
                par.UnlockButtons();
                MainForm.panel.Controls.Clear();
                MainForm.panel.Controls.Add(new ControlMatriculaPres1());
            }
            catch { }
        }

        /// <summary>
        /// Acción si el usuario presiona sobre el botón de Salir del
        /// proceso de matrícula en curso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalirMat_Click(object sender, EventArgs e)
        {
            try {

                DialogResult dialogResult = MessageBox.Show("¿Está seguro de salir " + 
                  "de la pantalla de matrícula? Esto liberará todos los cupos reservados.", 
                  "Confirmar salida", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    AbortarSesionMat();
                }

            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("MAT011", ex);
            }
        }

        private void GridCupos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    switch (e.ColumnIndex)
                    {
                        case 0:
                            var EditarPart = new EditarParticipante();
                            DataGridViewRow fila = GridCupos.Rows[e.RowIndex];

                            List<string> info = new List<string>();
                            info.Add((fila.Cells["TipoIdentificacion"].Value ?? "").ToString());
                            info.Add((fila.Cells["Identificacion"].Value ?? "").ToString());
                            info.Add((fila.Cells["Nombre"].Value ?? "").ToString());
                            info.Add((fila.Cells["Apellidos"].Value ?? "").ToString());
                            info.Add((fila.Cells["Telefono"].Value ?? "").ToString());
                            info.Add((fila.Cells["Correo"].Value ?? "").ToString());
                            info.Add((fila.Cells["Observaciones"].Value ?? "").ToString());
                            info.Add((fila.Cells["TipoApoyo"].Value ?? "").ToString());
                            EditarPart.SetData(info);

                            EditarPart.ShowDialog();
                            info = EditarPart.GetData();
                            fila.Cells["TipoIdentificacion"].Value = info[0];
                            fila.Cells["Identificacion"].Value = info[1];
                            fila.Cells["Nombre"].Value = info[2];
                            fila.Cells["Apellidos"].Value = info[3];
                            fila.Cells["Telefono"].Value = info[4];
                            fila.Cells["Correo"].Value = info[5];
                            fila.Cells["Observaciones"].Value = info[6];
                            fila.Cells["TipoApoyo"].Value = info[7];

                            EditarPart.Close();
                            break;

                        case 1:
                            DialogResult dialogResult = MessageBox.Show("¿Está seguro de eliminar " +
                              "la información del participante? Esto liberará el cupo reservado " + 
                              "para el curso respectivo.", "Eliminar participante", MessageBoxButtons.YesNo);

                            if (dialogResult == DialogResult.Yes)
                            {
                                GridCupos.Rows.RemoveAt(e.RowIndex);
                                numParticipantes -= 1;

                                // Crear entidad de matrícula
                                EMatriculaPres abort = new EMatriculaPres();
                                abort.Codigo = codCurso;
                                abort.Cupos = 1;

                                // 'Devolver' el cupo
                                new MatriculaNeg().LiberarCuposMatricula(abort);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("MAT011", ex);
            }
        }

        /// <summary>
        /// Limpiar todos los cupos reservados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de limpiar " +
                  "la información actual de matrícula? Esto liberará todos los cupos " +
                  "reservados.", "Limpiar matrícula", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    GridCupos.Rows.Clear();

                    // Crear entidad de matrícula
                    EMatriculaPres abort = new EMatriculaPres();
                    abort.Codigo = codCurso;
                    abort.Cupos = numParticipantes;

                    // 'Devolver' los cupos
                    new MatriculaNeg().LiberarCuposMatricula(abort);

                    numParticipantes = 0;
                }
            }
            catch { }
        }

        /// <summary>
        /// Reservar un cupo adicional
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReservarAd_Click(object sender, EventArgs e)
        {
            try
            {
                if (new MatriculaNeg().ReservarCupoAdicional(codCurso))
                {
                    GridCupos.Rows.Add();
                    GridCupos.Rows[GridCupos.Rows.Count - 1].Cells["ListaEspera"].Value = "No";
                    GridCupos.Rows[GridCupos.Rows.Count - 1].Cells["Cursos"].Value = nomCurso;
                    numParticipantes += 1;
                }
                else
                {
                    if (aceptaListaEspera)
                    {
                        DialogResult dialogResult = MessageBox.Show("Ya no hay cupos disponibles, " +
                         "¿Desea agregarlo de todas formas pero en lista de espera?",
                         "Lista de espera", MessageBoxButtons.YesNo);

                        if (dialogResult == DialogResult.Yes)
                        {
                            GridCupos.Rows.Add();
                            GridCupos.Rows[GridCupos.Rows.Count - 1].Cells["ListaEspera"].Value = "Sí";
                            GridCupos.Rows[GridCupos.Rows.Count - 1].Cells["Cursos"].Value = nomCurso;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay más cupos disponibles y el curso no acepta " +
                                         "lista de espera.", "Imposible continuar");
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("MAT011", ex);
            }
        }

        /// <summary>
        /// Verificar que todas las filas hayan sido editadas
        /// y no dejadas en blanco.
        /// </summary>
        /// <returns></returns>
        public bool FilasValidas()
        {
            foreach (DataGridViewRow fila in GridCupos.Rows)
            {
                if (fila.Cells["TipoIdentificacion"].Value == null &&
                    fila.Cells["Identificacion"].Value == null &&
                    fila.Cells["Nombre"].Value == null &&
                    fila.Cells["Apellidos"].Value == null )

                    return false;
            }
            return true;
        }

        /// <summary>
        /// Matricular todos los cupos editados, uno a uno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                if (FilasValidas()) // Ninguna fila contiene nulos o vacíos SI es requerida
                {
                    string login = sesion.Login;
                    DateTime fechaMat = DateTime.Now;

                    for (int i = 0; i < GridCupos.Rows.Count; i++)
                    {
                        EParticipante nuevo = new EParticipante();
                        DataGridViewRow fila = GridCupos.Rows[i];

                        nuevo.Usuario = login;

                        switch (fila.Cells["ListaEspera"].Value.ToString())
                        {
                            case "No":
                                nuevo.Estado = "Matriculado";
                                nuevo.ListaEspera = false;
                                break;
                            default:
                                nuevo.Estado = "En espera";
                                nuevo.ListaEspera = true;
                                break;
                        }
                        nuevo.Codigo = codCurso;
                        nuevo.IdTipoMatricula = idTipoMat;
                        nuevo.FechaMatricula = fechaMat;
                        nuevo.Orden = i + 1;

                        var val = Convert.ToInt16(fila.Cells["TipoIdentificacion"].Value);

                        nuevo.NombreCurso = fila.Cells["Cursos"].Value.ToString();
                        nuevo.IdTipoId = Convert.ToInt16(fila.Cells["TipoIdentificacion"].Value);
                        nuevo.Identificacion = fila.Cells["Identificacion"].Value.ToString();
                        nuevo.Nombre = fila.Cells["Nombre"].Value.ToString();
                        nuevo.Apellidos = fila.Cells["Apellidos"].Value.ToString();
                        nuevo.Correo = fila.Cells["Correo"].Value.ToString();
                        nuevo.Telefono = fila.Cells["Telefono"].Value.ToString();
                        nuevo.Observaciones = fila.Cells["Observaciones"].Value.ToString();
                        nuevo.TipoApoyo = fila.Cells["TipoApoyo"].Value.ToString();

                        new MatriculaNeg().MatricularParticipante(nuevo);
                    }

                    MessageBox.Show("Matrícula realizada exitosamente.",
                                    "Éxito");

                    MainForm par = (MainForm)this.ParentForm;
                    par.UnlockButtons();
                    MainForm.panel.Controls.Clear();
                    MainForm.panel.Controls.Add(new ControlMatriculaPres1());

                }
                else
                {
                    MessageBox.Show("Una o más filas contienen valores vacíos o inválidos.",
                                    "Imposible continuar");
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("MAT011", ex);
            }
        }


    }
}
