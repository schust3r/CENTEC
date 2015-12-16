namespace Presentacion.Modulos.Matricula.cMatricula
{
    partial class ControlMatriculaPres1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMatriculaPres1));
            this.cmbTipoMat = new System.Windows.Forms.ComboBox();
            this.lvlTipoDeEvento = new System.Windows.Forms.Label();
            this.txtbSede = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.GridCursos = new System.Windows.Forms.DataGridView();
            this.Cup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAReservar = new System.Windows.Forms.NumericUpDown();
            this.txtbCupos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbObservaciones = new System.Windows.Forms.TextBox();
            this.txtbReq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            this.btnReservar = new Presentacion.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAReservar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoMat
            // 
            this.cmbTipoMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMat.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbTipoMat.FormattingEnabled = true;
            this.cmbTipoMat.Location = new System.Drawing.Point(245, 99);
            this.cmbTipoMat.Name = "cmbTipoMat";
            this.cmbTipoMat.Size = new System.Drawing.Size(155, 25);
            this.cmbTipoMat.TabIndex = 0;
            // 
            // lvlTipoDeEvento
            // 
            this.lvlTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lvlTipoDeEvento.Location = new System.Drawing.Point(77, 68);
            this.lvlTipoDeEvento.Name = "lvlTipoDeEvento";
            this.lvlTipoDeEvento.Size = new System.Drawing.Size(162, 25);
            this.lvlTipoDeEvento.TabIndex = 99;
            this.lvlTipoDeEvento.Text = "Sede";
            this.lvlTipoDeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbSede
            // 
            this.txtbSede.Enabled = false;
            this.txtbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbSede.Location = new System.Drawing.Point(245, 68);
            this.txtbSede.MaxLength = 32;
            this.txtbSede.Name = "txtbSede";
            this.txtbSede.Size = new System.Drawing.Size(155, 25);
            this.txtbSede.TabIndex = 98;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lblLogin.Location = new System.Drawing.Point(77, 99);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 25);
            this.lblLogin.TabIndex = 97;
            this.lblLogin.Text = "Tipo de matrícula";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(704, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "Tiempo restante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblTiempo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTiempo.Location = new System.Drawing.Point(769, 61);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(54, 25);
            this.lblTiempo.TabIndex = 104;
            this.lblTiempo.Text = "5:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridCursos
            // 
            this.GridCursos.AllowUserToAddRows = false;
            this.GridCursos.AllowUserToDeleteRows = false;
            this.GridCursos.AllowUserToOrderColumns = true;
            this.GridCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridCursos.BackgroundColor = System.Drawing.Color.White;
            this.GridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCursos.Location = new System.Drawing.Point(33, 173);
            this.GridCursos.MultiSelect = false;
            this.GridCursos.Name = "GridCursos";
            this.GridCursos.ReadOnly = true;
            this.GridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridCursos.Size = new System.Drawing.Size(467, 221);
            this.GridCursos.TabIndex = 105;
            this.GridCursos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCursos_RowEnter);
            // 
            // Cup
            // 
            this.Cup.BackColor = System.Drawing.Color.Transparent;
            this.Cup.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.Cup.Location = new System.Drawing.Point(16, 177);
            this.Cup.Name = "Cup";
            this.Cup.Size = new System.Drawing.Size(133, 25);
            this.Cup.TabIndex = 108;
            this.Cup.Text = "Cupos restantes";
            this.Cup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label3.Location = new System.Drawing.Point(13, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "Cupos a reservar";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAReservar
            // 
            this.nudAReservar.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.nudAReservar.Location = new System.Drawing.Point(155, 208);
            this.nudAReservar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAReservar.Name = "nudAReservar";
            this.nudAReservar.Size = new System.Drawing.Size(86, 25);
            this.nudAReservar.TabIndex = 2;
            this.nudAReservar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAReservar.ValueChanged += new System.EventHandler(this.nudAReservar_ValueChanged);
            // 
            // txtbCupos
            // 
            this.txtbCupos.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbCupos.Location = new System.Drawing.Point(155, 177);
            this.txtbCupos.MaxLength = 32;
            this.txtbCupos.Name = "txtbCupos";
            this.txtbCupos.ReadOnly = true;
            this.txtbCupos.Size = new System.Drawing.Size(86, 25);
            this.txtbCupos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 35);
            this.label1.TabIndex = 111;
            this.label1.Text = "Selección de cursos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 35);
            this.label4.TabIndex = 112;
            this.label4.Text = "Detalle de curso";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtbObservaciones);
            this.panel1.Controls.Add(this.txtbReq);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Cup);
            this.panel1.Controls.Add(this.nudAReservar);
            this.panel1.Controls.Add(this.txtbCupos);
            this.panel1.Location = new System.Drawing.Point(522, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 245);
            this.panel1.TabIndex = 114;
            // 
            // txtbObservaciones
            // 
            this.txtbObservaciones.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbObservaciones.Location = new System.Drawing.Point(155, 84);
            this.txtbObservaciones.MaxLength = 32;
            this.txtbObservaciones.Multiline = true;
            this.txtbObservaciones.Name = "txtbObservaciones";
            this.txtbObservaciones.ReadOnly = true;
            this.txtbObservaciones.Size = new System.Drawing.Size(213, 87);
            this.txtbObservaciones.TabIndex = 116;
            // 
            // txtbReq
            // 
            this.txtbReq.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbReq.Location = new System.Drawing.Point(155, 46);
            this.txtbReq.MaxLength = 32;
            this.txtbReq.Name = "txtbReq";
            this.txtbReq.ReadOnly = true;
            this.txtbReq.Size = new System.Drawing.Size(213, 25);
            this.txtbReq.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label6.Location = new System.Drawing.Point(16, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 114;
            this.label6.Text = "Observaciones";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label5.Location = new System.Drawing.Point(16, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 113;
            this.label5.Text = "Requisitos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnInfoVentana.Location = new System.Drawing.Point(12, 3);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(448, 63);
            this.btnInfoVentana.TabIndex = 101;
            this.btnInfoVentana.Text = " > Negocio > Matrícula presencial";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // btnReservar
            // 
            this.btnReservar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservar.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.GradientBottom = System.Drawing.Color.SeaGreen;
            this.btnReservar.GradientTop = System.Drawing.Color.LimeGreen;
            this.btnReservar.Location = new System.Drawing.Point(650, 373);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(155, 43);
            this.btnReservar.TabIndex = 3;
            this.btnReservar.Text = "RESERVAR";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // ControlMatriculaPres1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCursos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInfoVentana);
            this.Controls.Add(this.cmbTipoMat);
            this.Controls.Add(this.lvlTipoDeEvento);
            this.Controls.Add(this.txtbSede);
            this.Controls.Add(this.lblLogin);
            this.Name = "ControlMatriculaPres1";
            this.Size = new System.Drawing.Size(928, 435);
            this.Load += new System.EventHandler(this.ControlMatriculaPres1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAReservar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoMat;
        private System.Windows.Forms.Label lvlTipoDeEvento;
        private System.Windows.Forms.TextBox txtbSede;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnInfoVentana;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.DataGridView GridCursos;
        private System.Windows.Forms.Label Cup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAReservar;
        private System.Windows.Forms.TextBox txtbCupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private RoundedButton btnReservar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbObservaciones;
        private System.Windows.Forms.TextBox txtbReq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
