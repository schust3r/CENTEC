namespace Presentacion.Modulos.Configuracion.cUsuario
{
    partial class RegistrarUsuario
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
            this.RdNo = new System.Windows.Forms.RadioButton();
            this.RdSi = new System.Windows.Forms.RadioButton();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblRegistrarUsuario = new System.Windows.Forms.Label();
            this.txtbContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPerfil = new System.Windows.Forms.ComboBox();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnRegistrar = new Presentacion.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(151, 79);
            this.cmbSede.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(212, 25);
            this.cmbSede.Sorted = true;
            this.cmbSede.TabIndex = 0;
            // 
            // RdNo
            // 
            this.RdNo.AutoSize = true;
            this.RdNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdNo.Location = new System.Drawing.Point(197, 283);
            this.RdNo.Name = "RdNo";
            this.RdNo.Size = new System.Drawing.Size(49, 22);
            this.RdNo.TabIndex = 6;
            this.RdNo.TabStop = true;
            this.RdNo.Text = "No";
            this.RdNo.UseVisualStyleBackColor = true;
            // 
            // RdSi
            // 
            this.RdSi.AutoSize = true;
            this.RdSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.RdSi.Location = new System.Drawing.Point(151, 283);
            this.RdSi.Name = "RdSi";
            this.RdSi.Size = new System.Drawing.Size(40, 22);
            this.RdSi.TabIndex = 5;
            this.RdSi.TabStop = true;
            this.RdSi.Text = "Sí";
            this.RdSi.UseVisualStyleBackColor = true;
            // 
            // lblActivo
            // 
            this.lblActivo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(51, 280);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(82, 25);
            this.lblActivo.TabIndex = 67;
            this.lblActivo.Text = "Activo";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            this.errorNombre.SetError(this.txtbNombre, "Nombre de usuario no puede ser vacío");
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(151, 237);
            this.txtbNombre.MinimumSize = new System.Drawing.Size(212, 32);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(212, 25);
            this.txtbNombre.TabIndex = 4;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(37, 196);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(96, 25);
            this.lblPerfil.TabIndex = 64;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbLogin
            // 
            this.errorLogin.SetError(this.txtbLogin, "Login no puede ser vacío");
            this.txtbLogin.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbLogin.Location = new System.Drawing.Point(151, 121);
            this.txtbLogin.MinimumSize = new System.Drawing.Size(212, 32);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(212, 25);
            this.txtbLogin.TabIndex = 1;
            this.txtbLogin.TextChanged += new System.EventHandler(this.txtbLogin_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(37, 121);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 25);
            this.lblLogin.TabIndex = 61;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSede
            // 
            this.lblSede.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSede.Location = new System.Drawing.Point(37, 79);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(100, 25);
            this.lblSede.TabIndex = 60;
            this.lblSede.Text = "Sede";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRegistrarUsuario
            // 
            this.lblRegistrarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistrarUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrarUsuario.Location = new System.Drawing.Point(90, 31);
            this.lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            this.lblRegistrarUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblRegistrarUsuario.TabIndex = 59;
            this.lblRegistrarUsuario.Text = "Nuevo registro";
            this.lblRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbContrasena
            // 
            this.errorPass.SetError(this.txtbContrasena, "Contraseña no puede quedar en blanco");
            this.txtbContrasena.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbContrasena.Location = new System.Drawing.Point(151, 160);
            this.txtbContrasena.MinimumSize = new System.Drawing.Size(212, 32);
            this.txtbContrasena.Name = "txtbContrasena";
            this.txtbContrasena.Size = new System.Drawing.Size(212, 25);
            this.txtbContrasena.TabIndex = 2;
            this.txtbContrasena.UseSystemPasswordChar = true;
            this.txtbContrasena.TextChanged += new System.EventHandler(this.txtbContrasena_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPerfil
            // 
            this.cmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerfil.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbPerfil.FormattingEnabled = true;
            this.cmbPerfil.Location = new System.Drawing.Point(151, 198);
            this.cmbPerfil.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbPerfil.Name = "cmbPerfil";
            this.cmbPerfil.Size = new System.Drawing.Size(212, 25);
            this.cmbPerfil.Sorted = true;
            this.cmbPerfil.TabIndex = 3;
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // errorPass
            // 
            this.errorPass.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(108, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.GradientBottom = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.GradientTop = System.Drawing.Color.SkyBlue;
            this.btnRegistrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRegistrar.Location = new System.Drawing.Point(206, 332);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(83, 33);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(385, 389);
            this.Controls.Add(this.cmbPerfil);
            this.Controls.Add(this.txtbContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.RdNo);
            this.Controls.Add(this.RdSi);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblRegistrarUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.RadioButton RdNo;
        private System.Windows.Forms.RadioButton RdSi;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblRegistrarUsuario;
        private RoundedButton btnCancelar;
        private RoundedButton btnRegistrar;
        private System.Windows.Forms.TextBox txtbContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPerfil;
        private System.Windows.Forms.ErrorProvider errorLogin;
        private System.Windows.Forms.ErrorProvider errorPass;
        private System.Windows.Forms.ErrorProvider errorNombre;
    }
}