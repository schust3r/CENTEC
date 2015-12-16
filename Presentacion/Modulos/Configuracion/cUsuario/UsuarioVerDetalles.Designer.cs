namespace Presentacion.Modulos.Configuracion.cUsuario
{
    partial class UsuarioVerDetalles
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
            this.lblSede = new System.Windows.Forms.Label();
            this.lblDetallesUsuario = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.RdSi = new System.Windows.Forms.RadioButton();
            this.RdNo = new System.Windows.Forms.RadioButton();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnModificar = new Presentacion.RoundedButton();
            this.btnGuardar = new Presentacion.RoundedButton();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSede
            // 
            this.lblSede.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(12, 83);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(100, 25);
            this.lblSede.TabIndex = 41;
            this.lblSede.Text = "Sede";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetallesUsuario
            // 
            this.lblDetallesUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesUsuario.Location = new System.Drawing.Point(73, 28);
            this.lblDetallesUsuario.Name = "lblDetallesUsuario";
            this.lblDetallesUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblDetallesUsuario.TabIndex = 40;
            this.lblDetallesUsuario.Text = "Detalles de usuario";
            this.lblDetallesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Enabled = false;
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(126, 201);
            this.txtbNombre.MinimumSize = new System.Drawing.Size(212, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(212, 25);
            this.txtbNombre.TabIndex = 54;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(12, 165);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(96, 25);
            this.lblPerfil.TabIndex = 52;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Enabled = false;
            this.txtbLogin.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbLogin.Location = new System.Drawing.Point(126, 127);
            this.txtbLogin.MinimumSize = new System.Drawing.Size(212, 32);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(212, 25);
            this.txtbLogin.TabIndex = 51;
            this.txtbLogin.TextChanged += new System.EventHandler(this.txtbLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(12, 125);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 25);
            this.lblLogin.TabIndex = 49;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblActivo
            // 
            this.lblActivo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(26, 249);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(82, 25);
            this.lblActivo.TabIndex = 55;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RdSi
            // 
            this.RdSi.AutoSize = true;
            this.RdSi.Enabled = false;
            this.RdSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.RdSi.Location = new System.Drawing.Point(126, 252);
            this.RdSi.Name = "RdSi";
            this.RdSi.Size = new System.Drawing.Size(40, 22);
            this.RdSi.TabIndex = 56;
            this.RdSi.TabStop = true;
            this.RdSi.Text = "Sí";
            this.RdSi.UseVisualStyleBackColor = true;
            // 
            // RdNo
            // 
            this.RdNo.AutoSize = true;
            this.RdNo.Enabled = false;
            this.RdNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNo.Location = new System.Drawing.Point(172, 252);
            this.RdNo.Name = "RdNo";
            this.RdNo.Size = new System.Drawing.Size(49, 22);
            this.RdNo.TabIndex = 57;
            this.RdNo.TabStop = true;
            this.RdNo.Text = "No";
            this.RdNo.UseVisualStyleBackColor = true;
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.Enabled = false;
            this.cmbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(126, 83);
            this.cmbSede.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(212, 25);
            this.cmbSede.TabIndex = 58;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Enabled = false;
            this.cmbPerfil.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(126, 165);
            this.cmbPerfil.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(212, 25);
            this.cmbPerfil.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(48, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 48;
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
            this.btnModificar.Location = new System.Drawing.Point(148, 296);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 33);
            this.btnModificar.TabIndex = 47;
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
            this.btnGuardar.Location = new System.Drawing.Point(248, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // UsuarioVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(366, 352);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.RdNo);
            this.Controls.Add(this.RdSi);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblDetallesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioVerDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsuarioVerDetalles";
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedButton btnCancelar;
        private RoundedButton btnModificar;
        private RoundedButton btnGuardar;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblDetallesUsuario;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.RadioButton RdSi;
        private System.Windows.Forms.RadioButton RdNo;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.ErrorProvider errorNombre;
    }
}