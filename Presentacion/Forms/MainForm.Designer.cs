namespace Presentacion.Inicio
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnSalir = new Presentacion.RoundedButton();
            this.btnVerAyuda = new Presentacion.RoundedButton();
            this.btnInicio = new Presentacion.RoundedButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnMatricula = new System.Windows.Forms.Button();
            this.pnlLinea = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlMainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMainForm.BackColor = System.Drawing.Color.White;
            this.pnlMainForm.Controls.Add(this.MainPanel);
            this.pnlMainForm.Controls.Add(this.btnSalir);
            this.pnlMainForm.Controls.Add(this.btnVerAyuda);
            this.pnlMainForm.Controls.Add(this.btnInicio);
            this.pnlMainForm.Controls.Add(this.pnlLogo);
            this.pnlMainForm.Controls.Add(this.btnConfiguracion);
            this.pnlMainForm.Controls.Add(this.btnMatricula);
            this.pnlMainForm.Controls.Add(this.pnlLinea);
            this.pnlMainForm.Location = new System.Drawing.Point(0, 0);
            this.pnlMainForm.MinimumSize = new System.Drawing.Size(1024, 640);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(1024, 640);
            this.pnlMainForm.TabIndex = 4;
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(42, 167);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(928, 435);
            this.MainPanel.TabIndex = 39;
            this.MainPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.MainPanel_ControlAdded);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.GradientBottom = System.Drawing.Color.Crimson;
            this.btnSalir.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnSalir.Location = new System.Drawing.Point(825, 47);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(145, 40);
            this.btnSalir.TabIndex = 38;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVerAyuda
            // 
            this.btnVerAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerAyuda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerAyuda.ForeColor = System.Drawing.Color.White;
            this.btnVerAyuda.GradientBottom = System.Drawing.Color.RoyalBlue;
            this.btnVerAyuda.GradientTop = System.Drawing.Color.SkyBlue;
            this.btnVerAyuda.Location = new System.Drawing.Point(675, 47);
            this.btnVerAyuda.Name = "btnVerAyuda";
            this.btnVerAyuda.Size = new System.Drawing.Size(145, 40);
            this.btnVerAyuda.TabIndex = 37;
            this.btnVerAyuda.Text = "VER AYUDA";
            this.btnVerAyuda.UseVisualStyleBackColor = true;
            this.btnVerAyuda.Click += new System.EventHandler(this.btnVerAyuda_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.GradientBottom = System.Drawing.Color.Navy;
            this.btnInicio.GradientTop = System.Drawing.Color.DodgerBlue;
            this.btnInicio.Location = new System.Drawing.Point(525, 47);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(145, 40);
            this.btnInicio.TabIndex = 36;
            this.btnInicio.Text = "INICIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Presentacion.Properties.Resources.logoSmall;
            this.pnlLogo.Location = new System.Drawing.Point(42, 47);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(330, 50);
            this.pnlLogo.TabIndex = 12;
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Font = new System.Drawing.Font("Lucida Sans", 16.25F);
            this.btnConfiguracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfiguracion.Location = new System.Drawing.Point(326, 116);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(170, 36);
            this.btnConfiguracion.TabIndex = 5;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            this.btnConfiguracion.MouseEnter += new System.EventHandler(this.btnConfiguracion_MouseEnter);
            this.btnConfiguracion.MouseLeave += new System.EventHandler(this.btnConfiguracion_MouseLeave);
            // 
            // btnMatricula
            // 
            this.btnMatricula.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMatricula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricula.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMatricula.FlatAppearance.BorderSize = 0;
            this.btnMatricula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMatricula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatricula.Font = new System.Drawing.Font("Lucida Sans", 16.25F);
            this.btnMatricula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMatricula.Location = new System.Drawing.Point(76, 116);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(121, 36);
            this.btnMatricula.TabIndex = 4;
            this.btnMatricula.Text = "Matrícula";
            this.btnMatricula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMatricula.UseVisualStyleBackColor = false;
            this.btnMatricula.Click += new System.EventHandler(this.btnMatricula_Click);
            this.btnMatricula.MouseEnter += new System.EventHandler(this.btnMatricula_MouseEnter);
            this.btnMatricula.MouseLeave += new System.EventHandler(this.btnMatricula_MouseLeave);
            // 
            // pnlLinea
            // 
            this.pnlLinea.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlLinea.Location = new System.Drawing.Point(42, 158);
            this.pnlLinea.Name = "pnlLinea";
            this.pnlLinea.Size = new System.Drawing.Size(928, 2);
            this.pnlLinea.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.pnlMainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CENTEC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMainForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainForm;
        private RoundedButton btnVerAyuda;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlLinea;
        private System.Windows.Forms.Panel MainPanel;
        private RoundedButton btnSalir;
        private RoundedButton btnInicio;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnMatricula;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}