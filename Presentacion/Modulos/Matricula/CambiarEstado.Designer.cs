namespace Presentacion.Modulos.Matricula.cMatricula
{
    partial class CambiarEstado
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
            this.txtbObservaciones = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNuevoEst = new System.Windows.Forms.ComboBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblDetallesUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridHistorial = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnCambiarEst = new Presentacion.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbObservaciones
            // 
            this.txtbObservaciones.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbObservaciones.HideSelection = false;
            this.txtbObservaciones.Location = new System.Drawing.Point(269, 102);
            this.txtbObservaciones.MaxLength = 400;
            this.txtbObservaciones.Multiline = true;
            this.txtbObservaciones.Name = "txtbObservaciones";
            this.txtbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbObservaciones.ShortcutsEnabled = false;
            this.txtbObservaciones.Size = new System.Drawing.Size(258, 77);
            this.txtbObservaciones.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label3.Location = new System.Drawing.Point(85, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 87;
            this.label3.Text = "Observaciones";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbNuevoEst
            // 
            this.cmbNuevoEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNuevoEst.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbNuevoEst.FormattingEnabled = true;
            this.cmbNuevoEst.Location = new System.Drawing.Point(269, 61);
            this.cmbNuevoEst.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbNuevoEst.Name = "cmbNuevoEst";
            this.cmbNuevoEst.Size = new System.Drawing.Size(258, 25);
            this.cmbNuevoEst.TabIndex = 86;
            // 
            // lblSede
            // 
            this.lblSede.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lblSede.Location = new System.Drawing.Point(29, 61);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(234, 25);
            this.lblSede.TabIndex = 83;
            this.lblSede.Text = "Seleccione un nuevo estado";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetallesUsuario
            // 
            this.lblDetallesUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesUsuario.Location = new System.Drawing.Point(172, 18);
            this.lblDetallesUsuario.Name = "lblDetallesUsuario";
            this.lblDetallesUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblDetallesUsuario.TabIndex = 82;
            this.lblDetallesUsuario.Text = "Estado actual";
            this.lblDetallesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label1.Location = new System.Drawing.Point(28, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "Historial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridHistorial
            // 
            this.GridHistorial.AllowUserToAddRows = false;
            this.GridHistorial.AllowUserToDeleteRows = false;
            this.GridHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridHistorial.BackgroundColor = System.Drawing.Color.White;
            this.GridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistorial.Location = new System.Drawing.Point(32, 195);
            this.GridHistorial.Name = "GridHistorial";
            this.GridHistorial.ReadOnly = true;
            this.GridHistorial.Size = new System.Drawing.Size(495, 266);
            this.GridHistorial.TabIndex = 90;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(173, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiarEst
            // 
            this.btnCambiarEst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarEst.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCambiarEst.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEst.GradientBottom = System.Drawing.Color.Navy;
            this.btnCambiarEst.GradientTop = System.Drawing.Color.DodgerBlue;
            this.btnCambiarEst.Location = new System.Drawing.Point(279, 480);
            this.btnCambiarEst.Name = "btnCambiarEst";
            this.btnCambiarEst.Size = new System.Drawing.Size(139, 33);
            this.btnCambiarEst.TabIndex = 84;
            this.btnCambiarEst.Text = "CAMBIAR ESTADO";
            this.btnCambiarEst.UseVisualStyleBackColor = true;
            this.btnCambiarEst.Click += new System.EventHandler(this.btnCambiarEst_Click);
            // 
            // CambiarEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 525);
            this.Controls.Add(this.GridHistorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbObservaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbNuevoEst);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiarEst);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblDetallesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarEstado";
            this.Load += new System.EventHandler(this.CambiarEstado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbObservaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbNuevoEst;
        private RoundedButton btnCancelar;
        private RoundedButton btnCambiarEst;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblDetallesUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridHistorial;
    }
}