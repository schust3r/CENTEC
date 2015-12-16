namespace Presentacion.Modulos.Matricula.cParticipantes
{
    partial class Comprobante
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
            this.btnCancelar = new Presentacion.RoundedButton();
            this.lblDetallesUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(324, 519);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblDetallesUsuario
            // 
            this.lblDetallesUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesUsuario.Location = new System.Drawing.Point(248, 18);
            this.lblDetallesUsuario.Name = "lblDetallesUsuario";
            this.lblDetallesUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblDetallesUsuario.TabIndex = 65;
            this.lblDetallesUsuario.Text = "Comprobante";
            this.lblDetallesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 440);
            this.panel1.TabIndex = 67;
            // 
            // Comprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 564);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDetallesUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton btnCancelar;
        private System.Windows.Forms.Label lblDetallesUsuario;
        private System.Windows.Forms.Panel panel1;
    }
}