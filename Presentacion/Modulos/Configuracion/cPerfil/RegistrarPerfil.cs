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

namespace Presentacion.Modulos.Configuracion.cPerfil
{
    public partial class RegistrarPerfil : Form
    {

        // Atributo de sesion del winform
        private ESesion sesion;

        // Para perfil
        private TreeNode NdAgregarPerfil;  
        private TreeNode NdEliminarPerfil;
        private TreeNode NdModificarPerfil;
        private TreeNode NdVerDetallesPerfil;

        // Para usuario
        private TreeNode NdAgregarUsuario;
        private TreeNode NdEliminarUsuario;
        private TreeNode NdModificarUsuario;
        private TreeNode NdVerDetallesUsuario;

        // Para bitacora
        private TreeNode NdVerDetallesBitacora;

        // Para ofertas
        private TreeNode NdRegistrarOferta;
        private TreeNode NdEliminarOferta;
        private TreeNode NdModificarOferta;
        private TreeNode NdVerDetallesOferta;
        private TreeNode NdCambiarEstOferta;

        // Para curso
        private TreeNode NdRegistrarCurso;
        private TreeNode NdEliminarCurso;
        private TreeNode NdModificarCurso;
        private TreeNode NdVerDetallesCurso;
        private TreeNode NdCambiarEstCurso;

        // Para matricula
        private TreeNode NdMatriculaPres;

        // Para participantes
        private TreeNode NdCambiarEstPart;
        private TreeNode NdImpComprobante; 

        public RegistrarPerfil()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            ReferenciarNodos();
        }

        /// <summary>
        /// Simplificar nombre de los nodos para hacer referencias
        /// a sus valores bool
        /// </summary>
        private void ReferenciarNodos()
        {
            /**
             * Módulo Configuración
             */
            // Referenciar perfil
            NdAgregarPerfil = tvPermisos.Nodes.Find("NdAgregarPerfil", true)[0];
            NdEliminarPerfil = tvPermisos.Nodes.Find("NdEliminarPerfil", true)[0];
            NdModificarPerfil = tvPermisos.Nodes.Find("NdModificarPerfil", true)[0];
            NdVerDetallesPerfil = tvPermisos.Nodes.Find("NdVerDetallesPerfil", true)[0];

            // Referenciar usuario
            NdAgregarUsuario = tvPermisos.Nodes.Find("NdAgregarUsuario", true)[0];
            NdEliminarUsuario = tvPermisos.Nodes.Find("NdEliminarUsuario", true)[0];
            NdModificarUsuario = tvPermisos.Nodes.Find("NdModificarUsuario", true)[0];
            NdVerDetallesUsuario = tvPermisos.Nodes.Find("NdVerDetallesUsuario", true)[0];

            // Referenciar bitácora
            NdVerDetallesBitacora = tvPermisos.Nodes.Find("NdVerDetallesBitacora", true)[0];

            /**
             * Módulo Matrícula
             */
            // Referenciar ofertas
            NdRegistrarOferta = tvPermisos.Nodes.Find("NdRegistrarOferta", true)[0];
            NdEliminarOferta = tvPermisos.Nodes.Find("NdEliminarOferta", true)[0];
            NdModificarOferta = tvPermisos.Nodes.Find("NdModificarOferta", true)[0];
            NdVerDetallesOferta = tvPermisos.Nodes.Find("NdVerDetallesOferta", true)[0];
            NdCambiarEstOferta = tvPermisos.Nodes.Find("NdCambiarEstOferta", true)[0];

            // Referenciar cursos
            NdRegistrarCurso = tvPermisos.Nodes.Find("NdRegistrarCurso", true)[0];
            NdEliminarCurso = tvPermisos.Nodes.Find("NdEliminarCurso", true)[0];
            NdModificarCurso = tvPermisos.Nodes.Find("NdModificarCurso", true)[0];
            NdVerDetallesCurso = tvPermisos.Nodes.Find("NdVerDetallesCurso", true)[0];
            NdCambiarEstCurso = tvPermisos.Nodes.Find("NdCambiarEstCurso", true)[0];

            // Referenciar matricula
            NdMatriculaPres = tvPermisos.Nodes.Find("NdMatriculaPres", true)[0];

            // Referenciar participantes
            NdCambiarEstPart = tvPermisos.Nodes.Find("NdCambiarEstPart", true)[0];
            NdImpComprobante = tvPermisos.Nodes.Find("NdImpComprobante", true)[0];
        }

        /// <summary>
        /// Cerrar la ventana flotante para Registrar Perfiles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Registrar un perfil si la validación resulta exitosa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try {
                if (sesion.permisos.RegistrarPerfil)
                {
                    EPerfil nuevo = new EPerfil();

                    nuevo.Nombre = txtbNombre.Text;
                    nuevo.Descripcion = txtbDescripcion.Text;

                    nuevo.RegistrarPerfil = NdAgregarPerfil.Checked;
                    nuevo.EliminarPerfil = NdEliminarPerfil.Checked;
                    nuevo.ModificarPerfil = NdModificarPerfil.Checked;
                    nuevo.VerDetallesPerfil = NdVerDetallesPerfil.Checked;

                    nuevo.RegistrarUsuario = NdAgregarUsuario.Checked;
                    nuevo.EliminarUsuario = NdEliminarUsuario.Checked;
                    nuevo.ModificarUsuario = NdModificarUsuario.Checked;
                    nuevo.VerDetallesUsuario = NdVerDetallesUsuario.Checked;

                    nuevo.VerBitacora = NdVerDetallesBitacora.Checked;

                    nuevo.RegistrarOferta = NdRegistrarOferta.Checked;
                    nuevo.EliminarOferta = NdEliminarOferta.Checked;
                    nuevo.ModificarOferta = NdModificarOferta.Checked;
                    nuevo.VerDetallesOferta = NdVerDetallesOferta.Checked;
                    nuevo.CambiarEstadoOferta = NdCambiarEstOferta.Checked;

                    nuevo.RegistrarCurso = NdRegistrarCurso.Checked;
                    nuevo.EliminarCurso = NdEliminarCurso.Checked;
                    nuevo.ModificarCurso = NdModificarCurso.Checked;
                    nuevo.VerDetallesCurso = NdVerDetallesCurso.Checked;
                    nuevo.CambiarEstadoCurso = NdCambiarEstCurso.Checked;

                    nuevo.MatriculaPres = NdMatriculaPres.Checked;

                    nuevo.CambiarEstadoPart = NdCambiarEstPart.Checked;
                    nuevo.ImprimirComprobante = NdImpComprobante.Checked;

                    // Verificar si el nombre no se repite en la base de datos
                    bool noEstaRepetido = true;
                    DataView perfExistentes = new PerfilNeg().CargarListaPerfiles();
                    foreach (DataRowView dvr in perfExistentes)
                    {
                        if (dvr["Perfil"].Equals(nuevo.Nombre))
                        {
                            noEstaRepetido = false;
                        }
                    }

                    if (nuevo.ValidarDatos() && noEstaRepetido)
                    {
                        if (new PerfilNeg().RegistrarPerfil(nuevo))
                        {
                            MessageBox.Show("El perfil '" + nuevo.Nombre + "' se registró " +
                                            "exitosamente.", "Éxito");
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Se ha presentado un error al registrar el perfil.",
                                         "Error");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el perfil.",
                                    "Error");
                }
            }
            catch (Exception ex)
            {
                MainForm.NotificarExcepcion("CU CON003", ex);
            }
        }

        /// <summary>
        /// Evento para llamar a método para chequeo recursivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TvPermisos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckAllChildNodes(e.Node, e.Node.Checked);
        }

        /// <summary>
        /// Chequear recursivamente todos los hijos de un permiso o sección
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="nodeChecked"></param>
        private void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbNombre.Text))
            {
                errorNombre.SetError(txtbNombre, "Nombre de perfil no puede ser vacío");
            }
            else
            {
                errorNombre.Clear();
            }
        }

        private void txtbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbDescripcion.Text))
            {
                errorDescr.SetError(txtbDescripcion, "Campo descripción no puede ser vacío");
            }
            else
            {
                errorDescr.Clear();
            }
        }


    }
}
