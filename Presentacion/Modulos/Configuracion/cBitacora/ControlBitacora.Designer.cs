namespace Presentacion.Modulos.Configuracion.cBitacora
{
    partial class ControlCurso
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
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtbTipoDeEvento = new System.Windows.Forms.TextBox();
            this.txtbDescripcion = new System.Windows.Forms.TextBox();
            this.lvlTipoDeEvento = new System.Windows.Forms.Label();
            this.txtbAccion = new System.Windows.Forms.TextBox();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridBitacora = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPeriodoDeFecha = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fechaInicio.CustomFormat = "dd/mm/yyyy";
            this.fechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(205, 125);
            this.fechaInicio.MinimumSize = new System.Drawing.Size(83, 30);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(86, 30);
            this.fechaInicio.TabIndex = 65;
            this.fechaInicio.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.fechaInicio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(292, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = ":";
            // 
            // fechaFin
            // 
            this.fechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fechaFin.CustomFormat = "dd/mm/yyyy hh:tt:ss";
            this.fechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(308, 125);
            this.fechaFin.MinimumSize = new System.Drawing.Size(83, 30);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(83, 30);
            this.fechaFin.TabIndex = 63;
            this.fechaFin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(-45, 294);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(240, 25);
            this.lblDescripcion.TabIndex = 62;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbTipoDeEvento
            // 
            this.txtbTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbTipoDeEvento.Location = new System.Drawing.Point(205, 252);
            this.txtbTipoDeEvento.MaxLength = 100;
            this.txtbTipoDeEvento.MinimumSize = new System.Drawing.Size(185, 32);
            this.txtbTipoDeEvento.Name = "txtbTipoDeEvento";
            this.txtbTipoDeEvento.Size = new System.Drawing.Size(185, 25);
            this.txtbTipoDeEvento.TabIndex = 61;
            this.txtbTipoDeEvento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // txtbDescripcion
            // 
            this.txtbDescripcion.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbDescripcion.HideSelection = false;
            this.txtbDescripcion.Location = new System.Drawing.Point(205, 291);
            this.txtbDescripcion.MaxLength = 500;
            this.txtbDescripcion.MinimumSize = new System.Drawing.Size(185, 70);
            this.txtbDescripcion.Multiline = true;
            this.txtbDescripcion.Name = "txtbDescripcion";
            this.txtbDescripcion.ShortcutsEnabled = false;
            this.txtbDescripcion.Size = new System.Drawing.Size(185, 70);
            this.txtbDescripcion.TabIndex = 60;
            this.txtbDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // lvlTipoDeEvento
            // 
            this.lvlTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlTipoDeEvento.Location = new System.Drawing.Point(-45, 252);
            this.lvlTipoDeEvento.Name = "lvlTipoDeEvento";
            this.lvlTipoDeEvento.Size = new System.Drawing.Size(240, 25);
            this.lvlTipoDeEvento.TabIndex = 59;
            this.lvlTipoDeEvento.Text = "Tipo de evento";
            this.lvlTipoDeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbAccion
            // 
            this.txtbAccion.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbAccion.Location = new System.Drawing.Point(205, 211);
            this.txtbAccion.MaxLength = 30;
            this.txtbAccion.MinimumSize = new System.Drawing.Size(185, 32);
            this.txtbAccion.Name = "txtbAccion";
            this.txtbAccion.Size = new System.Drawing.Size(185, 25);
            this.txtbAccion.TabIndex = 58;
            this.txtbAccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // txtbLogin
            // 
            this.txtbLogin.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbLogin.Location = new System.Drawing.Point(205, 170);
            this.txtbLogin.MaxLength = 32;
            this.txtbLogin.MinimumSize = new System.Drawing.Size(185, 32);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(185, 25);
            this.txtbLogin.TabIndex = 57;
            this.txtbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFin_KeyDown);
            // 
            // lblAccion
            // 
            this.lblAccion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(-45, 211);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(240, 25);
            this.lblAccion.TabIndex = 56;
            this.lblAccion.Text = "Acción";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(202, 364);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 55;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridBitacora
            // 
            this.GridBitacora.AllowUserToAddRows = false;
            this.GridBitacora.BackgroundColor = System.Drawing.Color.White;
            this.GridBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBitacora.GridColor = System.Drawing.Color.White;
            this.GridBitacora.Location = new System.Drawing.Point(401, 125);
            this.GridBitacora.Name = "GridBitacora";
            this.GridBitacora.ReadOnly = true;
            this.GridBitacora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridBitacora.Size = new System.Drawing.Size(515, 236);
            this.GridBitacora.TabIndex = 54;
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(396, 85);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 53;
            this.lblResultados.Text = "Resultados";
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(-45, 170);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(240, 25);
            this.lblLogin.TabIndex = 52;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPeriodoDeFecha
            // 
            this.lblPeriodoDeFecha.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoDeFecha.Location = new System.Drawing.Point(-44, 128);
            this.lblPeriodoDeFecha.Name = "lblPeriodoDeFecha";
            this.lblPeriodoDeFecha.Size = new System.Drawing.Size(240, 25);
            this.lblPeriodoDeFecha.TabIndex = 51;
            this.lblPeriodoDeFecha.Text = "Periodo de fecha";
            this.lblPeriodoDeFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(51, 85);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 50;
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
            this.btnInfoVentana.Image = global::Presentacion.Properties.Resources.logs;
            this.btnInfoVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentana.Location = new System.Drawing.Point(16, 5);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(318, 60);
            this.btnInfoVentana.TabIndex = 49;
            this.btnInfoVentana.Text = " > Reportes > Bitácora";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // ControlBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtbTipoDeEvento);
            this.Controls.Add(this.txtbDescripcion);
            this.Controls.Add(this.lvlTipoDeEvento);
            this.Controls.Add(this.txtbAccion);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridBitacora);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblPeriodoDeFecha);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlBitacora";
            this.Size = new System.Drawing.Size(928, 435);
            ((System.ComponentModel.ISupportInitialize)(this.GridBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtbTipoDeEvento;
        private System.Windows.Forms.TextBox txtbDescripcion;
        private System.Windows.Forms.Label lvlTipoDeEvento;
        private System.Windows.Forms.TextBox txtbAccion;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridBitacora;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPeriodoDeFecha;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
    }
}
