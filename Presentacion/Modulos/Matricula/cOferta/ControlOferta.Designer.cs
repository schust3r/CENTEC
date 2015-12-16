namespace Presentacion.Modulos.Matricula.cOferta
{
    partial class ControlOferta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlOferta));
            this.btnNuevaOferta = new System.Windows.Forms.Button();
            this.btnEliminarOferta = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.lvlTipoDeEvento = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridOferta = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridOferta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaOferta
            // 
            this.btnNuevaOferta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevaOferta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaOferta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevaOferta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevaOferta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevaOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaOferta.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnNuevaOferta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevaOferta.Location = new System.Drawing.Point(565, 363);
            this.btnNuevaOferta.Name = "btnNuevaOferta";
            this.btnNuevaOferta.Size = new System.Drawing.Size(171, 36);
            this.btnNuevaOferta.TabIndex = 99;
            this.btnNuevaOferta.Text = "Nueva oferta";
            this.btnNuevaOferta.UseVisualStyleBackColor = false;
            this.btnNuevaOferta.Click += new System.EventHandler(this.btnNuevaOferta_Click);
            // 
            // btnEliminarOferta
            // 
            this.btnEliminarOferta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarOferta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarOferta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarOferta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarOferta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminarOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarOferta.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnEliminarOferta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarOferta.Location = new System.Drawing.Point(742, 363);
            this.btnEliminarOferta.Name = "btnEliminarOferta";
            this.btnEliminarOferta.Size = new System.Drawing.Size(171, 36);
            this.btnEliminarOferta.TabIndex = 98;
            this.btnEliminarOferta.Text = "Eliminar oferta";
            this.btnEliminarOferta.UseVisualStyleBackColor = false;
            this.btnEliminarOferta.Click += new System.EventHandler(this.btnEliminarOferta_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.White;
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbEstado.ForeColor = System.Drawing.Color.Black;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(197, 138);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(185, 26);
            this.cmbEstado.TabIndex = 0;
            this.cmbEstado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbEstado_DrawItem);
            this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstado_KeyDown);
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(197, 179);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(185, 25);
            this.cmbSede.TabIndex = 1;
            this.cmbSede.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstado_KeyDown);
            // 
            // lvlTipoDeEvento
            // 
            this.lvlTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTipoDeEvento.Location = new System.Drawing.Point(-53, 179);
            this.lvlTipoDeEvento.Name = "lvlTipoDeEvento";
            this.lvlTipoDeEvento.Size = new System.Drawing.Size(240, 25);
            this.lvlTipoDeEvento.TabIndex = 93;
            this.lvlTipoDeEvento.Text = "Sede";
            this.lvlTipoDeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(197, 219);
            this.txtbNombre.MaxLength = 32;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(185, 25);
            this.txtbNombre.TabIndex = 2;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstado_KeyDown);
            // 
            // lblAccion
            // 
            this.lblAccion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(-53, 138);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(240, 25);
            this.lblAccion.TabIndex = 91;
            this.lblAccion.Text = "Estado";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(194, 261);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 90;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridOferta
            // 
            this.GridOferta.AllowUserToAddRows = false;
            this.GridOferta.BackgroundColor = System.Drawing.Color.White;
            this.GridOferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOferta.GridColor = System.Drawing.Color.White;
            this.GridOferta.Location = new System.Drawing.Point(398, 138);
            this.GridOferta.Name = "GridOferta";
            this.GridOferta.ReadOnly = true;
            this.GridOferta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridOferta.Size = new System.Drawing.Size(515, 219);
            this.GridOferta.TabIndex = 89;
            this.GridOferta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridOferta_CellDoubleClick);
            this.GridOferta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridOferta_DataBindingComplete);
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(393, 98);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 88;
            this.lblResultados.Text = "Resultados";
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(-53, 219);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(240, 25);
            this.lblLogin.TabIndex = 87;
            this.lblLogin.Text = "Nombre";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(48, 98);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 86;
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
            this.btnInfoVentana.TabIndex = 85;
            this.btnInfoVentana.Text = " > Negocio > Oferta";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // ControlOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNuevaOferta);
            this.Controls.Add(this.btnEliminarOferta);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.lvlTipoDeEvento);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridOferta);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlOferta";
            this.Size = new System.Drawing.Size(928, 435);
            this.Load += new System.EventHandler(this.ControlOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridOferta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaOferta;
        private System.Windows.Forms.Button btnEliminarOferta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label lvlTipoDeEvento;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridOferta;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
    }
}
