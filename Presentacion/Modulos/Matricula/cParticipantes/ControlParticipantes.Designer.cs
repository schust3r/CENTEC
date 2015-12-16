namespace Presentacion.Modulos.Matricula.cParticipantes
{
    partial class ControlParticipantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlParticipantes));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.lblPressEnter = new System.Windows.Forms.Label();
            this.GridPart = new System.Windows.Forms.DataGridView();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCriteriosBusqueda = new System.Windows.Forms.Label();
            this.btnInfoVentana = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbIdenti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOferta = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.GridPart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Sans", 14F);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(740, 367);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(171, 36);
            this.btnImprimir.TabIndex = 111;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(195, 182);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(185, 26);
            this.cmbEstado.TabIndex = 100;
            this.cmbEstado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbEstado_DrawItem);
            this.cmbEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsuario_KeyDown);
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbUsuario.Location = new System.Drawing.Point(195, 142);
            this.txtbUsuario.MaxLength = 32;
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(185, 25);
            this.txtbUsuario.TabIndex = 102;
            this.txtbUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsuario_KeyDown);
            // 
            // lblAccion
            // 
            this.lblAccion.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccion.Location = new System.Drawing.Point(-55, 182);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(240, 25);
            this.lblAccion.TabIndex = 109;
            this.lblAccion.Text = "Estado";
            this.lblAccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPressEnter
            // 
            this.lblPressEnter.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPressEnter.Location = new System.Drawing.Point(192, 341);
            this.lblPressEnter.Name = "lblPressEnter";
            this.lblPressEnter.Size = new System.Drawing.Size(190, 20);
            this.lblPressEnter.TabIndex = 108;
            this.lblPressEnter.Text = "Presione ENTER para buscar";
            this.lblPressEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridPart
            // 
            this.GridPart.AllowUserToAddRows = false;
            this.GridPart.BackgroundColor = System.Drawing.Color.White;
            this.GridPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPart.GridColor = System.Drawing.Color.White;
            this.GridPart.Location = new System.Drawing.Point(396, 142);
            this.GridPart.Name = "GridPart";
            this.GridPart.ReadOnly = true;
            this.GridPart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPart.Size = new System.Drawing.Size(515, 219);
            this.GridPart.TabIndex = 107;
            this.GridPart.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridPart_CellDoubleClick);
            this.GridPart.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GridPart_DataBindingComplete);
            // 
            // lblResultados
            // 
            this.lblResultados.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(391, 102);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(220, 25);
            this.lblResultados.TabIndex = 106;
            this.lblResultados.Text = "Resultados";
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(-55, 142);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(240, 25);
            this.lblLogin.TabIndex = 105;
            this.lblLogin.Text = "Usuario";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCriteriosBusqueda
            // 
            this.lblCriteriosBusqueda.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteriosBusqueda.Location = new System.Drawing.Point(46, 102);
            this.lblCriteriosBusqueda.Name = "lblCriteriosBusqueda";
            this.lblCriteriosBusqueda.Size = new System.Drawing.Size(240, 25);
            this.lblCriteriosBusqueda.TabIndex = 104;
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
            this.btnInfoVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoVentana.Image")));
            this.btnInfoVentana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoVentana.Location = new System.Drawing.Point(11, 22);
            this.btnInfoVentana.Name = "btnInfoVentana";
            this.btnInfoVentana.Size = new System.Drawing.Size(397, 60);
            this.btnInfoVentana.TabIndex = 103;
            this.btnInfoVentana.Text = " > Reportes > Participantes";
            this.btnInfoVentana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfoVentana.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-55, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 113;
            this.label1.Text = "Oferta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbIdenti
            // 
            this.txtbIdenti.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbIdenti.Location = new System.Drawing.Point(195, 304);
            this.txtbIdenti.MaxLength = 32;
            this.txtbIdenti.Name = "txtbIdenti";
            this.txtbIdenti.Size = new System.Drawing.Size(185, 25);
            this.txtbIdenti.TabIndex = 114;
            this.txtbIdenti.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsuario_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-55, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 115;
            this.label2.Text = "Identificación";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(195, 264);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(185, 25);
            this.cmbTipo.TabIndex = 116;
            this.cmbTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsuario_KeyDown);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-55, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tipo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOferta
            // 
            this.cmbOferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOferta.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbOferta.FormattingEnabled = true;
            this.cmbOferta.Location = new System.Drawing.Point(195, 224);
            this.cmbOferta.Name = "cmbOferta";
            this.cmbOferta.Size = new System.Drawing.Size(185, 25);
            this.cmbOferta.TabIndex = 118;
            this.cmbOferta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbUsuario_KeyDown);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ControlParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbOferta);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbIdenti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblPressEnter);
            this.Controls.Add(this.GridPart);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCriteriosBusqueda);
            this.Controls.Add(this.btnInfoVentana);
            this.Name = "ControlParticipantes";
            this.Size = new System.Drawing.Size(928, 435);
            this.Load += new System.EventHandler(this.ControlParticipantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridPart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label lblPressEnter;
        private System.Windows.Forms.DataGridView GridPart;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCriteriosBusqueda;
        private System.Windows.Forms.Button btnInfoVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbIdenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOferta;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
