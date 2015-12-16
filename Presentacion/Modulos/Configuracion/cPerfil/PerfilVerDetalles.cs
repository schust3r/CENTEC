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
    public partial class PerfilVerDetalles : Form
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

        public int idAnt { get; set; }

        public PerfilVerDetalles()
        {
            InitializeComponent();
            this.sesion = MainForm.sesion;
            ReferenciarNodos();
            tvPermisos.ExpandAll();
            //NdAgregarPerfil.
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

        private void ConfigurarESesion(ESesion s)
        {
            sesion = s;

            // Permitir la modificación si el usuario cuenta con privilegios
            if (!sesion.permisos.ModificarPerfil)
                btnModificar.Enabled = false;
        }

        public void SetDatos(DataRow datos)
        {
            txtbNombre.Text      = datos[1].ToString();
            txtbDescripcion.Text = datos[2].ToString();

            NdAgregarPerfil.Checked = ToBool(datos["Registrar perfil"].ToString());
            NdEliminarPerfil.Checked = ToBool(datos["Eliminar perfil"].ToString());
            NdModificarPerfil.Checked = ToBool(datos["Modificar perfil"].ToString());
            NdVerDetallesPerfil.Checked = ToBool(datos["Ver detalle de perfil"].ToString());

            NdAgregarUsuario.Checked = ToBool(datos["Registrar usuario"].ToString());
            NdEliminarUsuario.Checked = ToBool(datos["Eliminar usuario"].ToString());
            NdModificarUsuario.Checked = ToBool(datos["Modificar usuario"].ToString());
            NdVerDetallesUsuario.Checked = ToBool(datos["Ver detalle de usuario"].ToString());

            NdVerDetallesBitacora.Checked = ToBool(datos["Ver bitácora"].ToString());

            NdRegistrarOferta.Checked = ToBool(datos["Registrar oferta"].ToString());
            NdEliminarOferta.Checked = ToBool(datos["Eliminar oferta"].ToString());
            NdModificarOferta.Checked = ToBool(datos["Modificar oferta"].ToString());
            NdVerDetallesOferta.Checked = ToBool(datos["Ver detalle de oferta"].ToString());
            NdCambiarEstOferta.Checked = ToBool(datos["Cambiar estado de oferta"].ToString());

            NdRegistrarCurso.Checked = ToBool(datos["Registrar curso"].ToString());
            NdEliminarCurso.Checked = ToBool(datos["Eliminar curso"].ToString());
            NdModificarCurso.Checked = ToBool(datos["Modificar curso"].ToString());
            NdVerDetallesCurso.Checked = ToBool(datos["Ver detalle de curso"].ToString());
            NdCambiarEstCurso.Checked = ToBool(datos["Cambiar estado de curso"].ToString());

            NdMatriculaPres.Checked = ToBool(datos["Matrícula presencial"].ToString());

            NdCambiarEstPart.Checked = ToBool(datos["Cambiar estado de participante"].ToString());
            NdImpComprobante.Checked = ToBool(datos["Imprimir comprobante"].ToString());
        }

        /// <summary>
        /// Devuelve object como valor boolean
        /// </summary>
        /// <param name="obj">objeto int o string</param>
        /// <returns>true - si el objeto castea a 1</returns>
        private bool ToBool(string obj)
        {
            return obj == "1";
        }

        /// <summary>
        /// Cerrar ventana modal si el usuario decide no continuar la operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento para llamar a método para chequeo recursivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvPermisos_AfterCheck(object sender, TreeViewEventArgs e)
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

        /// <summary>
        /// Botón para modificar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sesion.permisos.ModificarPerfil)
            {
                txtbNombre.Enabled = true;
                txtbDescripcion.Enabled = true;
                tvPermisos.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void HabilitarNodos()
        {
            NdAgregarPerfil.TreeView.Enabled = true;
        }

        /// <summary>
        /// Guardar cambios efectuados sobre un perfil existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                EPerfil mod = new EPerfil();

                mod.IdPerfil = idAnt;

                mod.Nombre = txtbNombre.Text;
                mod.Descripcion = txtbDescripcion.Text;
                mod.LoginUsuario = sesion.Login;

                mod.RegistrarPerfil = NdAgregarPerfil.Checked;
                mod.EliminarPerfil = NdEliminarPerfil.Checked;
                mod.ModificarPerfil = NdModificarPerfil.Checked;
                mod.VerDetallesPerfil = NdVerDetallesPerfil.Checked;

                mod.RegistrarUsuario = NdAgregarUsuario.Checked;
                mod.EliminarUsuario = NdEliminarUsuario.Checked;
                mod.ModificarUsuario = NdModificarUsuario.Checked;
                mod.VerDetallesUsuario = NdVerDetallesUsuario.Checked;

                mod.VerBitacora = NdVerDetallesBitacora.Checked;

                mod.RegistrarOferta = NdRegistrarOferta.Checked;
                mod.EliminarOferta = NdEliminarOferta.Checked;
                mod.ModificarOferta = NdModificarOferta.Checked;
                mod.VerDetallesOferta = NdVerDetallesOferta.Checked;
                mod.CambiarEstadoOferta = NdCambiarEstOferta.Checked;

                mod.RegistrarCurso = NdRegistrarCurso.Checked;
                mod.EliminarCurso = NdEliminarCurso.Checked;
                mod.ModificarCurso = NdModificarCurso.Checked;
                mod.VerDetallesCurso = NdVerDetallesCurso.Checked;
                mod.CambiarEstadoCurso = NdCambiarEstCurso.Checked;

                mod.MatriculaPres = NdMatriculaPres.Checked;

                mod.CambiarEstadoPart = NdCambiarEstPart.Checked;
                mod.ImprimirComprobante = NdImpComprobante.Checked;

                if (mod.ValidarDatos())
                {
                    if (new PerfilNeg().ModificarPerfil(mod))
                    {
                        idAnt = mod.IdPerfil;
                        MessageBox.Show(this, "El perfil '" + mod.Nombre +
                                       "' se modificó exitosamente.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Se ha presentado un error al modificar el perfil.",
                                         "Error");
                    }
                    
                    // Actualizar si el usuario cambió sus permisos
                    MainForm.EstablecerSesion(); 
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Capturar y notificar excepción
                MainForm.NotificarExcepcion("CU CON004", ex);
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
