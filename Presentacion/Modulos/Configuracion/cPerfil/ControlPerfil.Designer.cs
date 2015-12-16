namespace Presentacion.Modulos.Configuracion.cPerfil
{
    partial class ControlPerfil
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
            this.btnNuevoPerfil = new System.Windows.Forms.Button();
            this.btnEliminarPerfil = new System.Windows.Forms.Button();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridPerfil = new System.Windows.Forms.DataGridView();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoPerfil
            // 
            this.btnNuevoPerfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevoPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevoPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPerfil.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnNuevoPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoPerfil.Location = new System.Drawing.Point(567, 326);
            this.btnNuevoPerfil.Name = "btnNuevoPerfil";
            this.btnNuevoPerfil.Size = new System.Drawing.Size(171, 36);
            this.btnNuevoPerfil.TabIndex = 48;
            this.btnNuevoPerfil.Text = "Nuevo perfil";
            this.btnNuevoPerfil.UseVisualStyleBackColor = false;
            this.btnNuevoPerfil.Click += new System.EventHandler(this.btnNuevoPerfil_Click);
            // 
            // btnEliminarPerfil
            // 
            this.btnEliminarPerfil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPerfil.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnEliminarPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarPerfil.Location = new System.Drawing.Point(744, 326);
            this.btnEliminarPerfil.Name = "btnEliminarPerfil";
            this.btnEliminarPerfil.Size = new System.Drawing.Size(171, 36);
            this.btnEliminarPerfil.TabIndex = 47;
            this.btnEliminarPerfil.Text = "Eliminar perfil";
            this.btnEliminarPerfil.UseVisualStyleBackColor = false;
            this.btnEliminarPerfil.Click += new System.EventHandler(this.btnEliminarPerfil_Click);
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(200, 300);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 46;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridPerfil
            // 
            this.GridPerfil.AllowUserToAddRows = false;
            this.GridPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPerfil.BackgroundColor = System.Drawing.Color.White;
            this.GridPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPerfil.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridPerfil.GridColor = System.Drawing.Color.White;
            this.GridPerfil.Location = new System.Drawing.Point(400, 127);
            this.GridPerfil.MultiSelect = false;
            this.GridPerfil.Name = "GridPerfil";
            this.GridPerfil.ReadOnly = true;
            this.GridPerfil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPerfil.Size = new System.Drawing.Size(515, 193);
            this.GridPerfil.TabIndex = 45;
            this.GridPerfil.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPerfil_CellDoubleClick);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.txtbDescripcion.HideSelection = false;
            this.txtbDescripcion.Location = new System.Drawing.Point(205, 169);
            this.txtbDescripcion.MinimumSize = new System.Drawing.Size(185, 128);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ShortcutsEnabled = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(185, 128);
            this.txtbDescripcion.TabIndex = 44;
            this.txtbDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbDescripcion_KeyDown);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(205, 130);
            this.txtbNombre.MaxLength = 150;
            this.txtbNombre.MinimumSize = new System.Drawing.Size(185, 33);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(185, 25);
            this.txtbNombre.TabIndex = 43;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbDescripcion_KeyDown);
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(395, 87);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 42;
            this.lblResultados.Text = "Resultados";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(-45, 172);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(240, 25);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(-45, 130);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(240, 25);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(50, 87);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 39;
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
            this.btnInfoVentana.Image = global::Presentacion.Properties.Resources.perfil;
            this.btnInfoVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentana.Location = new System.Drawing.Point(8, 3);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(332, 60);
            this.btnInfoVentana.TabIndex = 38;
            this.btnInfoVentana.Text = "   > Configuración > Perfil";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // ControlPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNuevoPerfil);
            this.Controls.Add(this.btnEliminarPerfil);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridPerfil);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlPerfil";
            this.Size = new System.Drawing.Size(928, 435);
            ((System.ComponentModel.ISupportInitialize)(this.GridPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoPerfil;
        private System.Windows.Forms.Button btnEliminarPerfil;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridPerfil;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
    }
}
