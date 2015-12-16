namespace Presentacion.Modulos.Configuracion.cPerfil
{
    partial class PerfilVerDetalles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("Registrar perfil");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Eliminar perfil");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Modificar perfil");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Ver detalles");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Perfiles", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64,
            treeNode65,
            treeNode66});
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Registrar usuario");
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Eliminar usuario");
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Modificar usuario");
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Ver detalles");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Usuarios", new System.Windows.Forms.TreeNode[] {
            treeNode68,
            treeNode69,
            treeNode70,
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Ver detalles");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Bitácora", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Configuración", new System.Windows.Forms.TreeNode[] {
            treeNode67,
            treeNode72,
            treeNode74});
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("Registrar oferta");
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Eliminar oferta");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Modificar oferta");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Ver detalle de oferta");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Cambiar estado de oferta");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Ofertas", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80});
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Registrar curso");
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Eliminar curso");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Modificar curso");
            System.Windows.Forms.TreeNode treeNode85 = new System.Windows.Forms.TreeNode("Ver detalle de curso");
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("Cambiar estado de curso");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("Cursos", new System.Windows.Forms.TreeNode[] {
            treeNode82,
            treeNode83,
            treeNode84,
            treeNode85,
            treeNode86});
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("Matrícula presencial");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("Matrícula", new System.Windows.Forms.TreeNode[] {
            treeNode88});
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("Cambiar estado de participante");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("Imprimir comprobante");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("Participantes", new System.Windows.Forms.TreeNode[] {
            treeNode90,
            treeNode91});
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("Matrícula", new System.Windows.Forms.TreeNode[] {
            treeNode81,
            treeNode87,
            treeNode89,
            treeNode92});
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDetallesPerfil = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnModificar = new Presentacion.RoundedButton();
            this.btnGuardar = new Presentacion.RoundedButton();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(7, 115);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(134, 25);
            this.lblDescripcion.TabIndex = 27;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 25);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetallesPerfil
            // 
            this.lblDetallesPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesPerfil.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesPerfil.Location = new System.Drawing.Point(145, 22);
            this.lblDetallesPerfil.Name = "lblDetallesPerfil";
            this.lblDetallesPerfil.Size = new System.Drawing.Size(197, 25);
            this.lblDetallesPerfil.TabIndex = 25;
            this.lblDetallesPerfil.Text = "Detalles de perfil";
            this.lblDetallesPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Enabled = false;
            this.txtbDescripcion.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbDescripcion.HideSelection = false;
            this.txtbDescripcion.Location = new System.Drawing.Point(159, 112);
            this.txtbDescripcion.MinimumSize = new System.Drawing.Size(239, 70);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ShortcutsEnabled = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(283, 70);
            this.txtbDescripcion.TabIndex = 29;
            this.txtbDescripcion.TextChanged += new System.EventHandler(this.txtbDescripcion_TextChanged);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Enabled = false;
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(159, 70);
            this.txtbNombre.MinimumSize = new System.Drawing.Size(239, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(283, 25);
            this.txtbNombre.TabIndex = 28;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // lblPermisos
            // 
            this.lblPermisos.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.Location = new System.Drawing.Point(7, 192);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(134, 25);
            this.lblPermisos.TabIndex = 30;
            this.lblPermisos.Text = "Permisos";
            this.lblPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tvPermisos
            // 
            this.tvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvPermisos.CheckBoxes = true;
            this.tvPermisos.Enabled = false;
            this.tvPermisos.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.tvPermisos.HotTracking = true;
            this.tvPermisos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tvPermisos.Location = new System.Drawing.Point(159, 192);
            this.tvPermisos.Name = "tvPermisos";
            treeNode63.BackColor = System.Drawing.Color.White;
            treeNode63.ForeColor = System.Drawing.Color.Black;
            treeNode63.Name = "NdAgregarPerfil";
            treeNode63.Text = "Registrar perfil";
            treeNode64.BackColor = System.Drawing.Color.White;
            treeNode64.ForeColor = System.Drawing.Color.Black;
            treeNode64.Name = "NdEliminarPerfil";
            treeNode64.Text = "Eliminar perfil";
            treeNode65.BackColor = System.Drawing.Color.White;
            treeNode65.ForeColor = System.Drawing.Color.Black;
            treeNode65.Name = "NdModificarPerfil";
            treeNode65.Text = "Modificar perfil";
            treeNode66.BackColor = System.Drawing.Color.White;
            treeNode66.ForeColor = System.Drawing.Color.Black;
            treeNode66.Name = "NdVerDetallesPerfil";
            treeNode66.Text = "Ver detalles";
            treeNode67.BackColor = System.Drawing.Color.White;
            treeNode67.ForeColor = System.Drawing.Color.Black;
            treeNode67.Name = "NdPerfil";
            treeNode67.Text = "Perfiles";
            treeNode68.BackColor = System.Drawing.Color.White;
            treeNode68.ForeColor = System.Drawing.Color.Black;
            treeNode68.Name = "NdAgregarUsuario";
            treeNode68.Text = "Registrar usuario";
            treeNode69.BackColor = System.Drawing.Color.White;
            treeNode69.ForeColor = System.Drawing.Color.Black;
            treeNode69.Name = "NdEliminarUsuario";
            treeNode69.Text = "Eliminar usuario";
            treeNode70.BackColor = System.Drawing.Color.White;
            treeNode70.ForeColor = System.Drawing.Color.Black;
            treeNode70.Name = "NdModificarUsuario";
            treeNode70.Text = "Modificar usuario";
            treeNode71.BackColor = System.Drawing.Color.White;
            treeNode71.ForeColor = System.Drawing.Color.Black;
            treeNode71.Name = "NdVerDetallesUsuario";
            treeNode71.Text = "Ver detalles";
            treeNode72.BackColor = System.Drawing.Color.White;
            treeNode72.ForeColor = System.Drawing.Color.Black;
            treeNode72.Name = "NdUsuario";
            treeNode72.Text = "Usuarios";
            treeNode73.BackColor = System.Drawing.Color.White;
            treeNode73.ForeColor = System.Drawing.Color.Black;
            treeNode73.Name = "NdVerDetallesBitacora";
            treeNode73.Text = "Ver detalles";
            treeNode74.BackColor = System.Drawing.Color.White;
            treeNode74.ForeColor = System.Drawing.Color.Black;
            treeNode74.Name = "NdBitacora";
            treeNode74.Text = "Bitácora";
            treeNode75.BackColor = System.Drawing.Color.White;
            treeNode75.ForeColor = System.Drawing.Color.Black;
            treeNode75.Name = "NdConfiguracion";
            treeNode75.Text = "Configuración";
            treeNode76.Name = "NdRegistrarOferta";
            treeNode76.Text = "Registrar oferta";
            treeNode77.Name = "NdEliminarOferta";
            treeNode77.Text = "Eliminar oferta";
            treeNode78.Name = "NdModificarOferta";
            treeNode78.Text = "Modificar oferta";
            treeNode79.Name = "NdVerDetallesOferta";
            treeNode79.Text = "Ver detalle de oferta";
            treeNode80.Name = "NdCambiarEstOferta";
            treeNode80.Text = "Cambiar estado de oferta";
            treeNode81.Name = "NdOfertas";
            treeNode81.Text = "Ofertas";
            treeNode82.Name = "NdRegistrarCurso";
            treeNode82.Text = "Registrar curso";
            treeNode83.Name = "NdEliminarCurso";
            treeNode83.Text = "Eliminar curso";
            treeNode84.Name = "NdModificarCurso";
            treeNode84.Text = "Modificar curso";
            treeNode85.Name = "NdVerDetallesCurso";
            treeNode85.Text = "Ver detalle de curso";
            treeNode86.Name = "NdCambiarEstCurso";
            treeNode86.Text = "Cambiar estado de curso";
            treeNode87.Name = "NdCursos";
            treeNode87.Text = "Cursos";
            treeNode88.Name = "NdMatriculaPres";
            treeNode88.Text = "Matrícula presencial";
            treeNode89.Name = "NdMatricula";
            treeNode89.Text = "Matrícula";
            treeNode90.Name = "NdCambiarEstPart";
            treeNode90.Text = "Cambiar estado de participante";
            treeNode91.Name = "NdImpComprobante";
            treeNode91.Text = "Imprimir comprobante";
            treeNode92.Name = "NdParticipantes";
            treeNode92.Text = "Participantes";
            treeNode93.BackColor = System.Drawing.Color.White;
            treeNode93.ForeColor = System.Drawing.Color.Black;
            treeNode93.Name = "NdMatricula";
            treeNode93.Text = "Matrícula";
            this.tvPermisos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode75,
            treeNode93});
            this.tvPermisos.ShowLines = false;
            this.tvPermisos.Size = new System.Drawing.Size(283, 257);
            this.tvPermisos.TabIndex = 50;
            this.tvPermisos.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvPermisos_AfterCheck);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(94, 460);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.GradientBottom = System.Drawing.Color.RoyalBlue;
            this.btnModificar.GradientTop = System.Drawing.Color.SkyBlue;
            this.btnModificar.Location = new System.Drawing.Point(194, 460);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 33);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.GradientBottom = System.Drawing.Color.Navy;
            this.btnGuardar.GradientTop = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Location = new System.Drawing.Point(294, 460);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDescr
            // 
            this.errorDescr.ContainerControl = this;
            // 
            // PerfilVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(466, 505);
            this.Controls.Add(this.tvPermisos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDetallesPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilVerDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerfilVerDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDetallesPerfil;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblPermisos;
        private RoundedButton btnCancelar;
        private RoundedButton btnModificar;
        private RoundedButton btnGuardar;
        private System.Windows.Forms.TreeView tvPermisos;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorDescr;
    }
}