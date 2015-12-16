namespace Presentacion.Modulos.Configuracion.cPerfil
{
    partial class RegistrarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPerfil));
            this.tvPermisos = new System.Windows.Forms.TreeView();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNuevoRegistro = new System.Windows.Forms.Label();
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnRegistrar = new Presentacion.RoundedButton();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDescr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescr)).BeginInit();
            this.SuspendLayout();
            // 
            // tvPermisos
            // 
            this.tvPermisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvPermisos.CheckBoxes = true;
            resources.ApplyResources(this.tvPermisos, "tvPermisos");
            this.tvPermisos.HotTracking = true;
            this.tvPermisos.Name = "tvPermisos";
            this.tvPermisos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            ((System.Windows.Forms.TreeNode)(resources.GetObject("tvPermisos.Nodes"))),
            ((System.Windows.Forms.TreeNode)(resources.GetObject("tvPermisos.Nodes1")))});
            this.tvPermisos.ShowLines = false;
            this.tvPermisos.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.TvPermisos_AfterCheck);
            // 
            // lblPermisos
            // 
            resources.ApplyResources(this.lblPermisos, "lblPermisos");
            this.lblPermisos.Name = "lblPermisos";
            // 
            // txtbDescripcion
            // 
            this.errorDescr.SetError(this.txtbDescripcion, resources.GetString("txtbDescripcion.Error"));
            resources.ApplyResources(this.txtbDescripcion, "txtbDescripcion");
            this.txtbDescripcion.HideSelection = false;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ShortcutsEnabled = false;
            this.txtbDescripcion.TextChanged += new System.EventHandler(this.txtbDescripcion_TextChanged);
            // 
            // txtbNombre
            // 
            this.errorNombre.SetError(this.txtbNombre, resources.GetString("txtbNombre.Error"));
            resources.ApplyResources(this.txtbNombre, "txtbNombre");
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // lblDescripcion
            // 
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // lblNuevoRegistro
            // 
            this.lblNuevoRegistro.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblNuevoRegistro, "lblNuevoRegistro");
            this.lblNuevoRegistro.Name = "lblNuevoRegistro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnRegistrar, "btnRegistrar");
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.GradientBottom = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.GradientTop = System.Drawing.Color.SkyBlue;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorDescr
            // 
            this.errorDescr.ContainerControl = this;
            // 
            // RegistrarPerfil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tvPermisos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNuevoRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPerfil";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDescr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvPermisos;
        private RoundedButton btnCancelar;
        private RoundedButton btnRegistrar;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNuevoRegistro;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorDescr;
    }
}