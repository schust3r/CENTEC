namespace Presentacion.Modulos.Configuracion.cUsuario
{
    partial class ControlUsuario
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
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtbPerfil = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridUsuario = new System.Windows.Forms.DataGridView();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnNuevoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(551, 324);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(176, 36);
            this.btnNuevoUsuario.TabIndex = 53;
            this.btnNuevoUsuario.Text = "Nuevo usuario";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEliminarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(733, 324);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(176, 36);
            this.btnEliminarUsuario.TabIndex = 52;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtbPerfil
            // 
            this.txtbPerfil.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPerfil.Location = new System.Drawing.Point(199, 208);
            this.txtbPerfil.MaxLength = 80;
            this.txtbPerfil.Name = "txtbPerfil";
            this.txtbPerfil.Size = new System.Drawing.Size(185, 32);
            this.txtbPerfil.TabIndex = 51;
            this.txtbPerfil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPerfil_KeyDown);
            // 
            // txtbNombre
            // 
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNombre.Location = new System.Drawing.Point(199, 167);
            this.txtbNombre.MaxLength = 150;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(185, 32);
            this.txtbNombre.TabIndex = 50;
            this.txtbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPerfil_KeyDown);
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(-51, 211);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(240, 25);
            this.lblPerfil.TabIndex = 49;
            this.lblPerfil.Text = "Perfil";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(196, 243);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 48;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridUsuario
            // 
            this.GridUsuario.AllowUserToAddRows = false;
            this.GridUsuario.AllowUserToDeleteRows = false;
            this.GridUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridUsuario.BackgroundColor = System.Drawing.Color.White;
            this.GridUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsuario.GridColor = System.Drawing.Color.White;
            this.GridUsuario.Location = new System.Drawing.Point(394, 125);
            this.GridUsuario.MultiSelect = false;
            this.GridUsuario.Name = "GridUsuario";
            this.GridUsuario.ReadOnly = true;
            this.GridUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridUsuario.Size = new System.Drawing.Size(515, 193);
            this.GridUsuario.TabIndex = 47;
            this.GridUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridUsuario_CellDoubleClick);
            // 
            // txtbLogin
            // 
            this.txtbLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbLogin.Location = new System.Drawing.Point(199, 125);
            this.txtbLogin.MaxLength = 32;
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(185, 32);
            this.txtbLogin.TabIndex = 46;
            this.txtbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbPerfil_KeyDown);
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(389, 85);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 45;
            this.lblResultados.Text = "Resultados";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(-51, 170);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(240, 25);
            this.lblNombre.TabIndex = 44;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(-51, 128);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(240, 25);
            this.lblLogin.TabIndex = 43;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(44, 85);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 42;
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
            this.btnInfoVentana.Image = global::Presentacion.Properties.Resources.usuario;
            this.btnInfoVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentana.Location = new System.Drawing.Point(9, 5);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(355, 60);
            this.btnInfoVentana.TabIndex = 41;
            this.btnInfoVentana.Text = " > Configuración > Usuario";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.txtbPerfil);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridUsuario);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlUsuario";
            this.Size = new System.Drawing.Size(928, 435);
            ((System.ComponentModel.ISupportInitialize)(this.GridUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtbPerfil;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridUsuario;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
    }
}
