namespace Presentacion.cLogin
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.loadGif = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlImagenAzul = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtbPass = new System.Windows.Forms.TextBox();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblInicioDeSecion = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlLogin.SuspendLayout();
            this.loadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadGif)).BeginInit();
            this.pnlImagenAzul.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLogin.Controls.Add(this.btnCerrar);
            this.pnlLogin.Controls.Add(this.pnlImagenAzul);
            this.pnlLogin.Controls.Add(this.pnlLogo);
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1024, 640);
            this.pnlLogin.TabIndex = 2;
            // 
            // loadPanel
            // 
            this.loadPanel.Controls.Add(this.label1);
            this.loadPanel.Controls.Add(this.loadGif);
            this.loadPanel.Location = new System.Drawing.Point(0, 0);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(410, 412);
            this.loadPanel.TabIndex = 42;
            this.loadPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido a CENTEC, espere mientras ingresamos...";
            // 
            // loadGif
            // 
            this.loadGif.Image = ((System.Drawing.Image)(resources.GetObject("loadGif.Image")));
            this.loadGif.Location = new System.Drawing.Point(82, 95);
            this.loadGif.Name = "loadGif";
            this.loadGif.Size = new System.Drawing.Size(249, 207);
            this.loadGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadGif.TabIndex = 0;
            this.loadGif.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Lucida Console", 23F);
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(969, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(43, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "x";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlImagenAzul
            // 
            this.pnlImagenAzul.BackColor = System.Drawing.Color.White;
            this.pnlImagenAzul.BackgroundImage = global::Presentacion.Properties.Resources.bienvenida;
            this.pnlImagenAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlImagenAzul.Controls.Add(this.loadPanel);
            this.pnlImagenAzul.Controls.Add(this.btnIngresar);
            this.pnlImagenAzul.Controls.Add(this.txtbPass);
            this.pnlImagenAzul.Controls.Add(this.lblPressEnter);
            this.pnlImagenAzul.Controls.Add(this.txtbLogin);
            this.pnlImagenAzul.Controls.Add(this.lblNombre);
            this.pnlImagenAzul.Controls.Add(this.lblLogin);
            this.pnlImagenAzul.Controls.Add(this.lblInicioDeSecion);
            this.pnlImagenAzul.Location = new System.Drawing.Point(304, 138);
            this.pnlImagenAzul.Name = "pnlImagenAzul";
            this.pnlImagenAzul.Size = new System.Drawing.Size(410, 412);
            this.pnlImagenAzul.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Location = new System.Drawing.Point(143, 299);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(144, 36);
            this.btnIngresar.TabIndex = 41;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtbPass
            // 
            this.txtbPass.AcceptsReturn = true;
            this.txtbPass.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPass.Location = new System.Drawing.Point(30, 248);
            this.txtbPass.Name = "txtbPass";
            this.txtbPass.PasswordChar = '*';
            this.txtbPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbPass.Size = new System.Drawing.Size(360, 32);
            this.txtbPass.TabIndex = 40;
            this.txtbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbPass.UseSystemPasswordChar = true;
            this.txtbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPass_KeyDown);
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.BackColor = System.Drawing.Color.Transparent;
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lblPressEnter.ForeColor = System.Drawing.Color.White;
            this.lblPressEnter.Location = new System.Drawing.Point(27, 359);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(360, 20);
            this.lblPressEnter.TabIndex = 39;
            this.lblPressEnter.Text = "Todos los derechos reservados  Ⓒ 2015.";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLogin.Location = new System.Drawing.Point(30, 171);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(360, 32);
            this.txtbLogin.TabIndex = 38;
            this.txtbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNombre.Location = new System.Drawing.Point(26, 220);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 25);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Contraseña";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLogin.Location = new System.Drawing.Point(29, 143);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(113, 25);
            this.lblLogin.TabIndex = 36;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInicioDeSecion
            // 
            this.lblInicioDeSecion.BackColor = System.Drawing.Color.Transparent;
            this.lblInicioDeSecion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInicioDeSecion.Font = new System.Drawing.Font("Lucida Sans", 30F);
            this.lblInicioDeSecion.ForeColor = System.Drawing.Color.White;
            this.lblInicioDeSecion.Location = new System.Drawing.Point(22, 64);
            this.lblInicioDeSecion.Name = "lblInicioDeSecion";
            this.lblInicioDeSecion.Size = new System.Drawing.Size(368, 47);
            this.lblInicioDeSecion.TabIndex = 35;
            this.lblInicioDeSecion.Text = "INICIO DE SESIÓN";
            this.lblInicioDeSecion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Presentacion.Properties.Resources.Logo;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLogo.Location = new System.Drawing.Point(253, 49);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(508, 83);
            this.pnlLogo.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CENTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLogin.ResumeLayout(false);
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadGif)).EndInit();
            this.pnlImagenAzul.ResumeLayout(false);
            this.pnlImagenAzul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel pnlImagenAzul;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtbPass;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblInicioDeSecion;
        private System.Windows.Forms.Panel loadPanel;
        private System.Windows.Forms.PictureBox loadGif;
        private System.Windows.Forms.Label label1;
    }
}