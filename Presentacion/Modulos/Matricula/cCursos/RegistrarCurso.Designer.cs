namespace Presentacion.Modulos.Matricula.cCursos
{
    partial class RegistrarCurso
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
            this.txtbObservaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOferta = new System.Windows.Forms.ComboBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtbEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblDetallesUsuario = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbHorario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbFacilitador = new System.Windows.Forms.TextBox();
            this.txtbPobMeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbRequisitoDe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbFechaReg = new System.Windows.Forms.TextBox();
            this.txtbUltMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.rbMatPresNo = new System.Windows.Forms.RadioButton();
            this.rbMatPresSi = new System.Windows.Forms.RadioButton();
            this.lblActivo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nudCantidadPres = new System.Windows.Forms.NumericUpDown();
            this.nudEnLinea = new System.Windows.Forms.NumericUpDown();
            this.nudGrupo = new System.Windows.Forms.NumericUpDown();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMatTelNo = new System.Windows.Forms.RadioButton();
            this.rbMatTelSi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMatLinNo = new System.Windows.Forms.RadioButton();
            this.rbMatLinSi = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbEsperaNo = new System.Windows.Forms.RadioButton();
            this.rbEsperaSi = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new Presentacion.RoundedButton();
            this.btnGuardar = new Presentacion.RoundedButton();
            this.errorCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFacilitador = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPobMeta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHorario = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrupo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFacilitador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPobMeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbObservaciones
            // 
            this.txtbObservaciones.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbObservaciones.HideSelection = false;
            this.txtbObservaciones.Location = new System.Drawing.Point(598, 226);
            this.txtbObservaciones.MaxLength = 500;
            this.txtbObservaciones.Multiline = true;
            this.txtbObservaciones.Name = "txtbObservaciones";
            this.txtbObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbObservaciones.ShortcutsEnabled = false;
            this.txtbObservaciones.Size = new System.Drawing.Size(212, 70);
            this.txtbObservaciones.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label2.Location = new System.Drawing.Point(-48, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 99;
            this.label2.Text = "Sede";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbNombre
            // 
            this.errorNombre.SetError(this.txtbNombre, "Debe ingresar un nombre válido.");
            this.txtbNombre.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbNombre.Location = new System.Drawing.Point(164, 225);
            this.txtbNombre.MaxLength = 80;
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(212, 25);
            this.txtbNombre.TabIndex = 4;
            this.txtbNombre.TextChanged += new System.EventHandler(this.txtbNombre_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label4.Location = new System.Drawing.Point(4, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 96;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbOferta
            // 
            this.cmbOferta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOferta.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbOferta.FormattingEnabled = true;
            this.cmbOferta.Location = new System.Drawing.Point(164, 70);
            this.cmbOferta.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbOferta.Name = "cmbOferta";
            this.cmbOferta.Size = new System.Drawing.Size(212, 25);
            this.cmbOferta.TabIndex = 0;
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblPerfil.Location = new System.Drawing.Point(58, 146);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(96, 25);
            this.lblPerfil.TabIndex = 92;
            this.lblPerfil.Text = "Código";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbEstado
            // 
            this.txtbEstado.Enabled = false;
            this.txtbEstado.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbEstado.Location = new System.Drawing.Point(164, 106);
            this.txtbEstado.Name = "txtbEstado";
            this.txtbEstado.Size = new System.Drawing.Size(212, 25);
            this.txtbEstado.TabIndex = 1;
            this.txtbEstado.Text = "Planificado";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label1.Location = new System.Drawing.Point(43, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 90;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblLogin.Location = new System.Drawing.Point(4, 106);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(150, 25);
            this.lblLogin.TabIndex = 89;
            this.lblLogin.Text = "Estado";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSede
            // 
            this.lblSede.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.lblSede.Location = new System.Drawing.Point(-80, 70);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(234, 25);
            this.lblSede.TabIndex = 85;
            this.lblSede.Text = "Oferta";
            this.lblSede.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDetallesUsuario
            // 
            this.lblDetallesUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDetallesUsuario.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesUsuario.Location = new System.Drawing.Point(316, 22);
            this.lblDetallesUsuario.Name = "lblDetallesUsuario";
            this.lblDetallesUsuario.Size = new System.Drawing.Size(236, 25);
            this.lblDetallesUsuario.TabIndex = 84;
            this.lblDetallesUsuario.Text = "Registrar curso";
            this.lblDetallesUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbTotal.Location = new System.Drawing.Point(164, 424);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(212, 25);
            this.txtbTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label3.Location = new System.Drawing.Point(-48, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 110;
            this.label3.Text = "Total";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbHorario
            // 
            this.errorHorario.SetError(this.txtbHorario, "Horario no puede ser vacío.");
            this.txtbHorario.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbHorario.Location = new System.Drawing.Point(164, 384);
            this.txtbHorario.MaxLength = 100;
            this.txtbHorario.Name = "txtbHorario";
            this.txtbHorario.Size = new System.Drawing.Size(212, 25);
            this.txtbHorario.TabIndex = 8;
            this.txtbHorario.TextChanged += new System.EventHandler(this.txtbHorario_TextChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label5.Location = new System.Drawing.Point(4, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 108;
            this.label5.Text = "Horario";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbFacilitador
            // 
            this.errorFacilitador.SetError(this.txtbFacilitador, "El facilitador debe ser un nombre válido.");
            this.txtbFacilitador.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbFacilitador.Location = new System.Drawing.Point(164, 305);
            this.txtbFacilitador.MaxLength = 100;
            this.txtbFacilitador.Name = "txtbFacilitador";
            this.txtbFacilitador.Size = new System.Drawing.Size(212, 25);
            this.txtbFacilitador.TabIndex = 6;
            this.txtbFacilitador.TextChanged += new System.EventHandler(this.txtbFacilitador_TextChanged);
            // 
            // txtbPobMeta
            // 
            this.errorPobMeta.SetError(this.txtbPobMeta, "Población meta no puede ser vacío");
            this.txtbPobMeta.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbPobMeta.Location = new System.Drawing.Point(164, 344);
            this.txtbPobMeta.Name = "txtbPobMeta";
            this.txtbPobMeta.Size = new System.Drawing.Size(212, 25);
            this.txtbPobMeta.TabIndex = 7;
            this.txtbPobMeta.TextChanged += new System.EventHandler(this.txtbPobMeta_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label6.Location = new System.Drawing.Point(47, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 105;
            this.label6.Text = "Facilitador";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label7.Location = new System.Drawing.Point(-12, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 104;
            this.label7.Text = "Población meta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbRequisitoDe
            // 
            this.txtbRequisitoDe.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbRequisitoDe.Location = new System.Drawing.Point(598, 190);
            this.txtbRequisitoDe.MaxLength = 100;
            this.txtbRequisitoDe.Name = "txtbRequisitoDe";
            this.txtbRequisitoDe.Size = new System.Drawing.Size(212, 25);
            this.txtbRequisitoDe.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label8.Location = new System.Drawing.Point(386, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 25);
            this.label8.TabIndex = 118;
            this.label8.Text = "Curso requisito de";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label9.Location = new System.Drawing.Point(410, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 116;
            this.label9.Text = "Número de grupo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtbFechaReg
            // 
            this.txtbFechaReg.Enabled = false;
            this.txtbFechaReg.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbFechaReg.Location = new System.Drawing.Point(598, 71);
            this.txtbFechaReg.Name = "txtbFechaReg";
            this.txtbFechaReg.Size = new System.Drawing.Size(212, 25);
            this.txtbFechaReg.TabIndex = 10;
            // 
            // txtbUltMod
            // 
            this.txtbUltMod.Enabled = false;
            this.txtbUltMod.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbUltMod.Location = new System.Drawing.Point(598, 110);
            this.txtbUltMod.Name = "txtbUltMod";
            this.txtbUltMod.Size = new System.Drawing.Size(212, 25);
            this.txtbUltMod.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label10.Location = new System.Drawing.Point(415, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 25);
            this.label10.TabIndex = 113;
            this.label10.Text = "Fecha de registro";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label11.Location = new System.Drawing.Point(390, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 25);
            this.label11.TabIndex = 112;
            this.label11.Text = "Última modificación";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 13F);
            this.label12.Location = new System.Drawing.Point(386, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(202, 48);
            this.label12.TabIndex = 120;
            this.label12.Text = "Requisitos y observaciones";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rbMatPresNo
            // 
            this.rbMatPresNo.AutoSize = true;
            this.rbMatPresNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatPresNo.Location = new System.Drawing.Point(48, 6);
            this.rbMatPresNo.Name = "rbMatPresNo";
            this.rbMatPresNo.Size = new System.Drawing.Size(49, 22);
            this.rbMatPresNo.TabIndex = 16;
            this.rbMatPresNo.TabStop = true;
            this.rbMatPresNo.Text = "No";
            this.rbMatPresNo.UseVisualStyleBackColor = true;
            this.rbMatPresNo.CheckedChanged += new System.EventHandler(this.rbMatPresNo_CheckedChanged);
            // 
            // rbMatPresSi
            // 
            this.rbMatPresSi.AutoSize = true;
            this.rbMatPresSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.rbMatPresSi.Location = new System.Drawing.Point(2, 6);
            this.rbMatPresSi.Name = "rbMatPresSi";
            this.rbMatPresSi.Size = new System.Drawing.Size(40, 22);
            this.rbMatPresSi.TabIndex = 15;
            this.rbMatPresSi.TabStop = true;
            this.rbMatPresSi.Text = "Sí";
            this.rbMatPresSi.UseVisualStyleBackColor = true;
            this.rbMatPresSi.CheckedChanged += new System.EventHandler(this.rbMatPresSi_CheckedChanged);
            // 
            // lblActivo
            // 
            this.lblActivo.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.lblActivo.Location = new System.Drawing.Point(398, 305);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(190, 25);
            this.lblActivo.TabIndex = 121;
            this.lblActivo.Text = "Matrícula presencial";
            this.lblActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label13.Location = new System.Drawing.Point(398, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 25);
            this.label13.TabIndex = 124;
            this.label13.Text = "Matrícula telefónica";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label14.Location = new System.Drawing.Point(398, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 25);
            this.label14.TabIndex = 127;
            this.label14.Text = "Matrícula en línea";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label15.Location = new System.Drawing.Point(398, 389);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(190, 25);
            this.label15.TabIndex = 130;
            this.label15.Text = "Lista de espera";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label16.Location = new System.Drawing.Point(386, 467);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(202, 25);
            this.label16.TabIndex = 135;
            this.label16.Text = "Cantidad en línea";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label17.Location = new System.Drawing.Point(394, 414);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(198, 52);
            this.label17.TabIndex = 133;
            this.label17.Text = "Cantidad presencial y teléfonica";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudCantidadPres
            // 
            this.nudCantidadPres.Enabled = false;
            this.nudCantidadPres.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.nudCantidadPres.Location = new System.Drawing.Point(598, 426);
            this.nudCantidadPres.Name = "nudCantidadPres";
            this.nudCantidadPres.Size = new System.Drawing.Size(212, 25);
            this.nudCantidadPres.TabIndex = 23;
            this.nudCantidadPres.ValueChanged += new System.EventHandler(this.nudCantidadPres_ValueChanged);
            // 
            // nudEnLinea
            // 
            this.nudEnLinea.Enabled = false;
            this.nudEnLinea.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.nudEnLinea.Location = new System.Drawing.Point(598, 467);
            this.nudEnLinea.Name = "nudEnLinea";
            this.nudEnLinea.Size = new System.Drawing.Size(212, 25);
            this.nudEnLinea.TabIndex = 24;
            this.nudEnLinea.ValueChanged += new System.EventHandler(this.nudCantidadPres_ValueChanged);
            // 
            // nudGrupo
            // 
            this.nudGrupo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.nudGrupo.Location = new System.Drawing.Point(598, 150);
            this.nudGrupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGrupo.Name = "nudGrupo";
            this.nudGrupo.Size = new System.Drawing.Size(212, 25);
            this.nudGrupo.TabIndex = 12;
            this.nudGrupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(164, 183);
            this.cmbTipo.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(212, 25);
            this.cmbTipo.TabIndex = 3;
            // 
            // cmbSede
            // 
            this.cmbSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSede.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(164, 265);
            this.cmbSede.MinimumSize = new System.Drawing.Size(212, 0);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(212, 25);
            this.cmbSede.TabIndex = 5;
            // 
            // txtbCodigo
            // 
            this.errorCodigo.SetError(this.txtbCodigo, "El código no puede quedar en blanco.");
            this.txtbCodigo.Font = new System.Drawing.Font("Lucida Sans", 11F);
            this.txtbCodigo.Location = new System.Drawing.Point(164, 146);
            this.txtbCodigo.MaxLength = 50;
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(212, 25);
            this.txtbCodigo.TabIndex = 2;
            this.txtbCodigo.TextChanged += new System.EventHandler(this.txtbCodigo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMatPresNo);
            this.groupBox1.Controls.Add(this.rbMatPresSi);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(606, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 28);
            this.groupBox1.TabIndex = 168;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMatTelNo);
            this.groupBox2.Controls.Add(this.rbMatTelSi);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(606, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 28);
            this.groupBox2.TabIndex = 169;
            this.groupBox2.TabStop = false;
            // 
            // rbMatTelNo
            // 
            this.rbMatTelNo.AutoSize = true;
            this.rbMatTelNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatTelNo.Location = new System.Drawing.Point(48, 6);
            this.rbMatTelNo.Name = "rbMatTelNo";
            this.rbMatTelNo.Size = new System.Drawing.Size(49, 22);
            this.rbMatTelNo.TabIndex = 16;
            this.rbMatTelNo.TabStop = true;
            this.rbMatTelNo.Text = "No";
            this.rbMatTelNo.UseVisualStyleBackColor = true;
            this.rbMatTelNo.CheckedChanged += new System.EventHandler(this.rbMatTelNo_CheckedChanged);
            // 
            // rbMatTelSi
            // 
            this.rbMatTelSi.AutoSize = true;
            this.rbMatTelSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.rbMatTelSi.Location = new System.Drawing.Point(2, 6);
            this.rbMatTelSi.Name = "rbMatTelSi";
            this.rbMatTelSi.Size = new System.Drawing.Size(40, 22);
            this.rbMatTelSi.TabIndex = 15;
            this.rbMatTelSi.TabStop = true;
            this.rbMatTelSi.Text = "Sí";
            this.rbMatTelSi.UseVisualStyleBackColor = true;
            this.rbMatTelSi.CheckedChanged += new System.EventHandler(this.rbMatTelSi_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMatLinNo);
            this.groupBox3.Controls.Add(this.rbMatLinSi);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(606, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 28);
            this.groupBox3.TabIndex = 169;
            this.groupBox3.TabStop = false;
            // 
            // rbMatLinNo
            // 
            this.rbMatLinNo.AutoSize = true;
            this.rbMatLinNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMatLinNo.Location = new System.Drawing.Point(48, 6);
            this.rbMatLinNo.Name = "rbMatLinNo";
            this.rbMatLinNo.Size = new System.Drawing.Size(49, 22);
            this.rbMatLinNo.TabIndex = 16;
            this.rbMatLinNo.TabStop = true;
            this.rbMatLinNo.Text = "No";
            this.rbMatLinNo.UseVisualStyleBackColor = true;
            this.rbMatLinNo.CheckedChanged += new System.EventHandler(this.rbMatLinNo_CheckedChanged);
            // 
            // rbMatLinSi
            // 
            this.rbMatLinSi.AutoSize = true;
            this.rbMatLinSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.rbMatLinSi.Location = new System.Drawing.Point(2, 6);
            this.rbMatLinSi.Name = "rbMatLinSi";
            this.rbMatLinSi.Size = new System.Drawing.Size(40, 22);
            this.rbMatLinSi.TabIndex = 15;
            this.rbMatLinSi.TabStop = true;
            this.rbMatLinSi.Text = "Sí";
            this.rbMatLinSi.UseVisualStyleBackColor = true;
            this.rbMatLinSi.CheckedChanged += new System.EventHandler(this.rbMatLinSi_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbEsperaNo);
            this.groupBox4.Controls.Add(this.rbEsperaSi);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Location = new System.Drawing.Point(606, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 28);
            this.groupBox4.TabIndex = 169;
            this.groupBox4.TabStop = false;
            // 
            // rbEsperaNo
            // 
            this.rbEsperaNo.AutoSize = true;
            this.rbEsperaNo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEsperaNo.Location = new System.Drawing.Point(48, 6);
            this.rbEsperaNo.Name = "rbEsperaNo";
            this.rbEsperaNo.Size = new System.Drawing.Size(49, 22);
            this.rbEsperaNo.TabIndex = 16;
            this.rbEsperaNo.TabStop = true;
            this.rbEsperaNo.Text = "No";
            this.rbEsperaNo.UseVisualStyleBackColor = true;
            // 
            // rbEsperaSi
            // 
            this.rbEsperaSi.AutoSize = true;
            this.rbEsperaSi.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.rbEsperaSi.Location = new System.Drawing.Point(2, 6);
            this.rbEsperaSi.Name = "rbEsperaSi";
            this.rbEsperaSi.Size = new System.Drawing.Size(40, 22);
            this.rbEsperaSi.TabIndex = 15;
            this.rbEsperaSi.TabStop = true;
            this.rbEsperaSi.Text = "Sí";
            this.rbEsperaSi.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.GradientBottom = System.Drawing.Color.Crimson;
            this.btnCancelar.GradientTop = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(361, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 166;
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
            this.btnGuardar.Location = new System.Drawing.Point(469, 518);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 33);
            this.btnGuardar.TabIndex = 165;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorCodigo
            // 
            this.errorCodigo.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorFacilitador
            // 
            this.errorFacilitador.ContainerControl = this;
            // 
            // errorPobMeta
            // 
            this.errorPobMeta.ContainerControl = this;
            // 
            // errorHorario
            // 
            this.errorHorario.ContainerControl = this;
            // 
            // RegistrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 575);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbCodigo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.nudGrupo);
            this.Controls.Add(this.nudEnLinea);
            this.Controls.Add(this.nudCantidadPres);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbRequisitoDe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbFechaReg);
            this.Controls.Add(this.txtbUltMod);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbHorario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbFacilitador);
            this.Controls.Add(this.txtbPobMeta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbObservaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOferta);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.txtbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.lblDetallesUsuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCurso";
            this.Load += new System.EventHandler(this.RegistrarCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGrupo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFacilitador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPobMeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHorario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbObservaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOferta;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.TextBox txtbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblDetallesUsuario;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbHorario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbFacilitador;
        private System.Windows.Forms.TextBox txtbPobMeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbRequisitoDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbFechaReg;
        private System.Windows.Forms.TextBox txtbUltMod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbMatPresNo;
        private System.Windows.Forms.RadioButton rbMatPresSi;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nudCantidadPres;
        private System.Windows.Forms.NumericUpDown nudEnLinea;
        private System.Windows.Forms.NumericUpDown nudGrupo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbSede;
        private RoundedButton btnCancelar;
        private RoundedButton btnGuardar;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMatTelNo;
        private System.Windows.Forms.RadioButton rbMatTelSi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMatLinNo;
        private System.Windows.Forms.RadioButton rbMatLinSi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbEsperaNo;
        private System.Windows.Forms.RadioButton rbEsperaSi;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorCodigo;
        private System.Windows.Forms.ErrorProvider errorHorario;
        private System.Windows.Forms.ErrorProvider errorFacilitador;
        private System.Windows.Forms.ErrorProvider errorPobMeta;
    }
}