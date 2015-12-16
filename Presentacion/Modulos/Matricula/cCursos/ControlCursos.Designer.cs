namespace Presentacion.Modulos.Matricula.cCursos
{
    partial class ControlCursos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlCursos));
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lvlTipoDeEvento = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridCursos = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbOferta = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnNuevoCurso = new System.Windows.Forms.Button();
            this.btnEliminarCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(-52, 261);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(240, 25);
            this.lblDescripcion.TabIndex = 79;
            this.lblDescripcion.Text = "Tipo";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvlTipoDeEvento
            // 
            this.lvlTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTipoDeEvento.Location = new System.Drawing.Point(-52, 219);
            this.lvlTipoDeEvento.Name = "lvlTipoDeEvento";
            this.lvlTipoDeEvento.Size = new System.Drawing.Size(240, 25);
            this.lvlTipoDeEvento.TabIndex = 76;
            this.lvlTipoDeEvento.Text = "Oferta";
            this.lvlTipoDeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(198, 137);
            this.txtbNombre.MaxLength = 32;
            this.txtbNombre.MinimumSize = new System.Drawing.Size(185, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(185, 25);
            this.txtbNombre.TabIndex = 0;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // lblAccion
            // 
            this.lblAccion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(-52, 178);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(240, 25);
            this.lblAccion.TabIndex = 73;
            this.lblAccion.Text = "Estado";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(195, 300);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 72;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridCursos
            // 
            this.GridCursos.AllowUserToAddRows = false;
            this.GridCursos.BackgroundColor = System.Drawing.Color.White;
            this.GridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCursos.GridColor = System.Drawing.Color.White;
            this.GridCursos.Location = new System.Drawing.Point(398, 138);
            this.GridCursos.Name = "GridCursos";
            this.GridCursos.ReadOnly = true;
            this.GridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCursos.Size = new System.Drawing.Size(515, 219);
            this.GridCursos.TabIndex = 71;
            this.GridCursos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCursos_CellDoubleClick);
            this.GridCursos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridCursos_DataBindingComplete);
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(393, 98);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 70;
            this.lblResultados.Text = "Resultados";
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(-52, 137);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(240, 25);
            this.lblLogin.TabIndex = 69;
            this.lblLogin.Text = "Nombre";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(48, 98);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 67;
            this.lblCriteriosBusqueda.Text = "Criterios de búsqueda";
            // 
            // btnInfoVentana
            // 
            this.btnInfoVentana.BackColor = System.Drawing.Color.White;
            this.btnInfoVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInfoVentana.Enabled = false;
            this.btnInfoVentana.FlatAppearance.BorderSize = 0;
            this.btnInfoVentana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoVentana.Font = new System.Drawing.Font("Lucida Sans", 16.25F);
            this.btnInfoVentana.ForeColor = System.Drawing.Color.Black;
            this.btnInfoVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoVentana.Image")));
            this.btnInfoVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentana.Location = new System.Drawing.Point(13, 18);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(290, 60);
            this.btnInfoVentana.TabIndex = 66;
            this.btnInfoVentana.Text = " > Negocio > Cursos";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(198, 261);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(185, 25);
            this.cmbTipo.TabIndex = 3;
            this.cmbTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // cmbOferta
            // 
            this.cmbOferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOferta.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbOferta.FormattingEnabled = true;
            this.cmbOferta.Location = new System.Drawing.Point(198, 219);
            this.cmbOferta.Name = "cmbOferta";
            this.cmbOferta.Size = new System.Drawing.Size(185, 25);
            this.cmbOferta.TabIndex = 2;
            this.cmbOferta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbEstado.ForeColor = System.Drawing.Color.White;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(198, 178);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(185, 26);
            this.cmbEstado.TabIndex = 1;
            this.cmbEstado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbEstado_DrawItem);
            this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbNombre_KeyDown);
            // 
            // btnNuevoCurso
            // 
            this.btnNuevoCurso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevoCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevoCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoCurso.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnNuevoCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoCurso.Location = new System.Drawing.Point(565, 363);
            this.btnNuevoCurso.Name = "btnNuevoCurso";
            this.btnNuevoCurso.Size = new System.Drawing.Size(171, 36);
            this.btnNuevoCurso.TabIndex = 84;
            this.btnNuevoCurso.Text = "Nuevo curso";
            this.btnNuevoCurso.UseVisualStyleBackColor = false;
            this.btnNuevoCurso.Click += new System.EventHandler(this.btnNuevoPerfil_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCurso.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnEliminarCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarCurso.Location = new System.Drawing.Point(742, 363);
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(171, 36);
            this.btnEliminarCurso.TabIndex = 83;
            this.btnEliminarCurso.Text = "Eliminar curso";
            this.btnEliminarCurso.UseVisualStyleBackColor = false;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // ControlCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNuevoCurso);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbOferta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lvlTipoDeEvento);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridCursos);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlCursos";
            this.Size = new System.Drawing.Size(928, 435);
            this.Load += new System.EventHandler(this.ControlCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lvlTipoDeEvento;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridCursos;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbOferta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnNuevoCurso;
        private System.Windows.Forms.Button btnEliminarCurso;
    }
}
