namespace Presentacion.Modulos.Matricula.cOferta
{
    partial class RegistrarOferta
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
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblDetallesUsuario = new System.Windows.Forms.Label();
            this.txtbUltMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbObservacion = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbFechaReg = new System.Windows.Forms.TextBox();
            this.cmbHora = new System.Windows.Forms.ComboBox();
            this.cmbMinutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbInicioMatricula = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInicioMat = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnGuardar = new Presentacion.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioMat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(183, 145);
            this.cmbSede.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(212, 25);
            this.cmbSede.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label2.Location = new System.Drawing.Point(-29, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 182;
            this.label2.Text = "Fecha de registro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 181;
            this.label4.Text = "Hora de inicio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Enabled = false;
            this.cmbEstado.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(183, 105);
            this.cmbEstado.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(212, 26);
            this.cmbEstado.TabIndex = 1;
            this.cmbEstado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbEstado_DrawItem);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblPerfil.Location = new System.Drawing.Point(77, 145);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(96, 25);
            this.lblPerfil.TabIndex = 180;
            this.lblPerfil.Text = "Sede";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label1.Location = new System.Drawing.Point(25, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 179;
            this.label1.Text = "Matrícula inicia el";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblLogin.Location = new System.Drawing.Point(23, 105);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(150, 25);
            this.lblLogin.TabIndex = 178;
            this.lblLogin.Text = "Estado";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSede
            // 
            this.lblSede.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblSede.Location = new System.Drawing.Point(-61, 69);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(234, 25);
            this.lblSede.TabIndex = 177;
            this.lblSede.Text = "Nombre";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetallesUsuario
            // 
            this.lblDetallesUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesUsuario.Location = new System.Drawing.Point(102, 26);
            this.lblDetallesUsuario.Name = "lblDetallesUsuario";
            this.lblDetallesUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblDetallesUsuario.TabIndex = 176;
            this.lblDetallesUsuario.Text = "Registrar oferta";
            this.lblDetallesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbUltMod
            // 
            this.txtbUltMod.Enabled = false;
            this.txtbUltMod.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbUltMod.Location = new System.Drawing.Point(183, 327);
            this.txtbUltMod.Name = "txtbUltMod";
            this.txtbUltMod.Size = new System.Drawing.Size(212, 25);
            this.txtbUltMod.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 184;
            this.label3.Text = "Última modificación";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label12.Location = new System.Drawing.Point(-29, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 27);
            this.label12.TabIndex = 186;
            this.label12.Text = "Observación";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbObservacion
            // 
            this.txtbObservacion.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbObservacion.HideSelection = false;
            this.txtbObservacion.Location = new System.Drawing.Point(183, 367);
            this.txtbObservacion.MaxLength = 400;
            this.txtbObservacion.Multiline = true;
            this.txtbObservacion.Name = "txtbObservacion";
            this.txtbObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbObservacion.ShortcutsEnabled = false;
            this.txtbObservacion.Size = new System.Drawing.Size(212, 70);
            this.txtbObservacion.TabIndex = 8;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(183, 69);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(212, 25);
            this.txtbNombre.TabIndex = 0;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // txtbFechaReg
            // 
            this.txtbFechaReg.Enabled = false;
            this.txtbFechaReg.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbFechaReg.Location = new System.Drawing.Point(183, 287);
            this.txtbFechaReg.Name = "txtbFechaReg";
            this.txtbFechaReg.Size = new System.Drawing.Size(212, 25);
            this.txtbFechaReg.TabIndex = 6;
            // 
            // cmbHora
            // 
            this.cmbHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHora.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbHora.FormattingEnabled = true;
            this.cmbHora.Location = new System.Drawing.Point(183, 247);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Size = new System.Drawing.Size(98, 25);
            this.cmbHora.TabIndex = 4;
            // 
            // cmbMinutos
            // 
            this.cmbMinutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMinutos.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbMinutos.FormattingEnabled = true;
            this.cmbMinutos.Location = new System.Drawing.Point(297, 247);
            this.cmbMinutos.Name = "cmbMinutos";
            this.cmbMinutos.Size = new System.Drawing.Size(98, 25);
            this.cmbMinutos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label5.Location = new System.Drawing.Point(179, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 25);
            this.label5.TabIndex = 192;
            this.label5.Text = "HH        :         mm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbInicioMatricula
            // 
            this.txtbInicioMatricula.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbInicioMatricula.Location = new System.Drawing.Point(183, 193);
            this.txtbInicioMatricula.Mask = "00/00/0000";
            this.txtbInicioMatricula.Name = "txtbInicioMatricula";
            this.txtbInicioMatricula.Size = new System.Drawing.Size(212, 25);
            this.txtbInicioMatricula.TabIndex = 3;
            this.txtbInicioMatricula.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtbInicioMatricula_MaskInputRejected);
            this.txtbInicioMatricula.TextChanged += new System.EventHandler(this.txtbInicioMatricula_TextChanged);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorInicioMat
            // 
            this.errorInicioMat.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(120, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 194;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.GradientBottom = System.Drawing.Color.Navy;
            this.btnGuardar.GradientTop = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Location = new System.Drawing.Point(228, 467);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 193;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // RegistrarOferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 511);
            this.Controls.Add(this.txtbInicioMatricula);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMinutos);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.txtbFechaReg);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbObservacion);
            this.Controls.Add(this.txtbUltMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblDetallesUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarOferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarOferta";
            this.Load += new System.EventHandler(this.RegistrarOferta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInicioMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblDetallesUsuario;
        private System.Windows.Forms.TextBox txtbUltMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbObservacion;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbFechaReg;
        private System.Windows.Forms.ComboBox cmbHora;
        private System.Windows.Forms.ComboBox cmbMinutos;
        private System.Windows.Forms.Label label5;
        private RoundedButton btnCancelar;
        private RoundedButton btnGuardar;
        private System.Windows.Forms.MaskedTextBox txtbInicioMatricula;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorInicioMat;
    }
}