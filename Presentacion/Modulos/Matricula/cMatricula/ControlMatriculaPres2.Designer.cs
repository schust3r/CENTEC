namespace Presentacion.Modulos.Matricula.cMatricula
{
    partial class ControlMatriculaPres2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMatriculaPres2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvlTipoDeEvento = new System.Windows.Forms.Label();
            this.txtbSede = new System.Windows.Forms.TextBox();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GridCupos = new System.Windows.Forms.DataGridView();
            this.btnReservarAd = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalirMat = new System.Windows.Forms.Button();
            this.btnMatricular = new Presentacion.RoundedButton();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoApoyo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblTiempo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTiempo.Location = new System.Drawing.Point(769, 61);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(54, 25);
            this.lblTiempo.TabIndex = 109;
            this.lblTiempo.Text = "5:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(704, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "Tiempo restante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvlTipoDeEvento
            // 
            this.lvlTipoDeEvento.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lvlTipoDeEvento.Location = new System.Drawing.Point(148, 72);
            this.lvlTipoDeEvento.Name = "lvlTipoDeEvento";
            this.lvlTipoDeEvento.Size = new System.Drawing.Size(49, 25);
            this.lvlTipoDeEvento.TabIndex = 106;
            this.lvlTipoDeEvento.Text = "Sede";
            this.lvlTipoDeEvento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbSede
            // 
            this.txtbSede.Enabled = false;
            this.txtbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbSede.Location = new System.Drawing.Point(203, 72);
            this.txtbSede.MaxLength = 32;
            this.txtbSede.Name = "txtbSede";
            this.txtbSede.Size = new System.Drawing.Size(155, 25);
            this.txtbSede.TabIndex = 105;
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
            this.btnInfoVentana.TabIndex = 107;
            this.btnInfoVentana.Text = " > Negocio > Matrícula presencial";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 36);
            this.label1.TabIndex = 113;
            this.label1.Text = "Cupos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridCupos
            // 
            this.GridCupos.AllowUserToAddRows = false;
            this.GridCupos.AllowUserToDeleteRows = false;
            this.GridCupos.AllowUserToOrderColumns = true;
            this.GridCupos.BackgroundColor = System.Drawing.Color.White;
            this.GridCupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Cursos,
            this.Identificacion,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Correo,
            this.ListaEspera,
            this.TipoIdentificacion,
            this.Observaciones,
            this.TipoApoyo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = "\"\"";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridCupos.DefaultCellStyle = dataGridViewCellStyle1;
            this.GridCupos.Location = new System.Drawing.Point(149, 141);
            this.GridCupos.Name = "GridCupos";
            this.GridCupos.ReadOnly = true;
            this.GridCupos.Size = new System.Drawing.Size(656, 231);
            this.GridCupos.TabIndex = 112;
            this.GridCupos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridCupos_CellMouseClick);
            // 
            // btnReservarAd
            // 
            this.btnReservarAd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReservarAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservarAd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReservarAd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReservarAd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReservarAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservarAd.Font = new System.Drawing.Font("Lucida Sans", 12.5F);
            this.btnReservarAd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReservarAd.Location = new System.Drawing.Point(149, 381);
            this.btnReservarAd.Name = "btnReservarAd";
            this.btnReservarAd.Size = new System.Drawing.Size(250, 36);
            this.btnReservarAd.TabIndex = 116;
            this.btnReservarAd.Text = "Reservar un cupo adicional";
            this.btnReservarAd.UseVisualStyleBackColor = false;
            this.btnReservarAd.Click += new System.EventHandler(this.btnReservarAd_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Location = new System.Drawing.Point(418, 381);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 36);
            this.btnLimpiar.TabIndex = 115;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalirMat
            // 
            this.btnSalirMat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalirMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalirMat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalirMat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalirMat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalirMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMat.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnSalirMat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalirMat.Location = new System.Drawing.Point(550, 381);
            this.btnSalirMat.Name = "btnSalirMat";
            this.btnSalirMat.Size = new System.Drawing.Size(98, 36);
            this.btnSalirMat.TabIndex = 117;
            this.btnSalirMat.Text = "Salir";
            this.btnSalirMat.UseVisualStyleBackColor = false;
            this.btnSalirMat.Click += new System.EventHandler(this.btnSalirMat_Click);
            // 
            // btnMatricular
            // 
            this.btnMatricular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatricular.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.btnMatricular.ForeColor = System.Drawing.Color.White;
            this.btnMatricular.GradientBottom = System.Drawing.Color.Crimson;
            this.btnMatricular.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnMatricular.Location = new System.Drawing.Point(664, 381);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(141, 36);
            this.btnMatricular.TabIndex = 114;
            this.btnMatricular.Text = "MATRICULAR";
            this.btnMatricular.UseVisualStyleBackColor = true;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 50;
            // 
            // Cursos
            // 
            this.Cursos.HeaderText = "Cursos";
            this.Cursos.Name = "Cursos";
            this.Cursos.ReadOnly = true;
            this.Cursos.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Cursos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Identificacion
            // 
            this.Identificacion.HeaderText = "Identificación";
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.ReadOnly = true;
            this.Identificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Identificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo electrónico";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // ListaEspera
            // 
            this.ListaEspera.HeaderText = "Lista de espera";
            this.ListaEspera.Name = "ListaEspera";
            this.ListaEspera.ReadOnly = true;
            // 
            // TipoIdentificacion
            // 
            this.TipoIdentificacion.HeaderText = "Tipo de identificación";
            this.TipoIdentificacion.Name = "TipoIdentificacion";
            this.TipoIdentificacion.ReadOnly = true;
            this.TipoIdentificacion.Visible = false;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            this.Observaciones.Visible = false;
            // 
            // TipoApoyo
            // 
            this.TipoApoyo.HeaderText = "Tipo de apoyo requerido";
            this.TipoApoyo.Name = "TipoApoyo";
            this.TipoApoyo.ReadOnly = true;
            this.TipoApoyo.Visible = false;
            // 
            // ControlMatriculaPres2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSalirMat);
            this.Controls.Add(this.btnReservarAd);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCupos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInfoVentana);
            this.Controls.Add(this.lvlTipoDeEvento);
            this.Controls.Add(this.txtbSede);
            this.Name = "ControlMatriculaPres2";
            this.Size = new System.Drawing.Size(928, 435);
            this.Load += new System.EventHandler(this.ControlMatriculaPres2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInfoVentana;
        private System.Windows.Forms.Label lvlTipoDeEvento;
        private System.Windows.Forms.TextBox txtbSede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridCupos;
        private RoundedButton btnMatricular;
        private System.Windows.Forms.Button btnReservarAd;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalirMat;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ListaEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoApoyo;
    }
}
