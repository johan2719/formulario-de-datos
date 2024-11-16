namespace formularios
{
    partial class formulariodatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cmbTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.rbtnMedicinaGeneral = new System.Windows.Forms.RadioButton();
            this.rbtnExamenLaboratorio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValorCopago = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cbmEstructura = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pila = new System.Windows.Forms.TabPage();
            this.btnEliminarPila = new System.Windows.Forms.Button();
            this.btnReportePila = new System.Windows.Forms.Button();
            this.dataGridViewPila = new System.Windows.Forms.DataGridView();
            this.Cola = new System.Windows.Forms.TabPage();
            this.btnEliminarCola = new System.Windows.Forms.Button();
            this.btnReporteCola = new System.Windows.Forms.Button();
            this.dataGridViewCola = new System.Windows.Forms.DataGridView();
            this.Lista = new System.Windows.Forms.TabPage();
            this.btnEliminarLista = new System.Windows.Forms.Button();
            this.btnReporteLista = new System.Windows.Forms.Button();
            this.dataGridViewLista = new System.Windows.Forms.DataGridView();
            this.TipoIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCopago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularCopago = new System.Windows.Forms.Button();
            this.textBoxReporte = new System.Windows.Forms.TextBox();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Pila.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).BeginInit();
            this.Cola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).BeginInit();
            this.Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE REGISTRO DE USUARIOS EN EL CENTRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EPS Salvando vidas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "estrato socioeconomico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor del Copago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "tipo de estructura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "reporte de datos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nro. identificacion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(317, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "edad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha de acceso";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cmbTipoIdentificacion
            // 
            this.cmbTipoIdentificacion.FormattingEnabled = true;
            this.cmbTipoIdentificacion.Items.AddRange(new object[] {
            "CC",
            "CE",
            "NUIP ",
            "PAS"});
            this.cmbTipoIdentificacion.Location = new System.Drawing.Point(171, 129);
            this.cmbTipoIdentificacion.Name = "cmbTipoIdentificacion";
            this.cmbTipoIdentificacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoIdentificacion.TabIndex = 12;
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(429, 129);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroIdentificacion.TabIndex = 13;
            this.txtNumeroIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(429, 166);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 15;
            this.txtEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbEstrato.Location = new System.Drawing.Point(171, 203);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(121, 21);
            this.cmbEstrato.TabIndex = 16;
            this.cmbEstrato.SelectedIndexChanged += new System.EventHandler(this.cmbEstrato_SelectedIndexChanged);
            // 
            // rbtnMedicinaGeneral
            // 
            this.rbtnMedicinaGeneral.AutoSize = true;
            this.rbtnMedicinaGeneral.Location = new System.Drawing.Point(2, 34);
            this.rbtnMedicinaGeneral.Name = "rbtnMedicinaGeneral";
            this.rbtnMedicinaGeneral.Size = new System.Drawing.Size(108, 17);
            this.rbtnMedicinaGeneral.TabIndex = 17;
            this.rbtnMedicinaGeneral.TabStop = true;
            this.rbtnMedicinaGeneral.Text = "Medicina General";
            this.rbtnMedicinaGeneral.UseVisualStyleBackColor = true;
            this.rbtnMedicinaGeneral.CheckedChanged += new System.EventHandler(this.rbtnMedicinaGeneral_CheckedChanged);
            // 
            // rbtnExamenLaboratorio
            // 
            this.rbtnExamenLaboratorio.AutoSize = true;
            this.rbtnExamenLaboratorio.Location = new System.Drawing.Point(116, 34);
            this.rbtnExamenLaboratorio.Name = "rbtnExamenLaboratorio";
            this.rbtnExamenLaboratorio.Size = new System.Drawing.Size(134, 17);
            this.rbtnExamenLaboratorio.TabIndex = 18;
            this.rbtnExamenLaboratorio.TabStop = true;
            this.rbtnExamenLaboratorio.Text = "Examen de Laboratorio";
            this.rbtnExamenLaboratorio.UseVisualStyleBackColor = true;
            this.rbtnExamenLaboratorio.CheckedChanged += new System.EventHandler(this.rbtnExamenLaboratorio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMedicinaGeneral);
            this.groupBox1.Controls.Add(this.rbtnExamenLaboratorio);
            this.groupBox1.Location = new System.Drawing.Point(320, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 86);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtValorCopago
            // 
            this.txtValorCopago.Location = new System.Drawing.Point(171, 242);
            this.txtValorCopago.Name = "txtValorCopago";
            this.txtValorCopago.ReadOnly = true;
            this.txtValorCopago.Size = new System.Drawing.Size(121, 20);
            this.txtValorCopago.TabIndex = 20;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(436, 313);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(93, 20);
            this.dtpFechaRegistro.TabIndex = 21;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(320, 364);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(429, 363);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 363);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbmEstructura
            // 
            this.cbmEstructura.FormattingEnabled = true;
            this.cbmEstructura.Location = new System.Drawing.Point(171, 297);
            this.cbmEstructura.Name = "cbmEstructura";
            this.cbmEstructura.Size = new System.Drawing.Size(121, 21);
            this.cbmEstructura.TabIndex = 25;
            this.cbmEstructura.SelectedIndexChanged += new System.EventHandler(this.cbmEstructura_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pila);
            this.tabControl1.Controls.Add(this.Cola);
            this.tabControl1.Controls.Add(this.Lista);
            this.tabControl1.Location = new System.Drawing.Point(24, 425);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(871, 100);
            this.tabControl1.TabIndex = 26;
            // 
            // Pila
            // 
            this.Pila.Controls.Add(this.btnEliminarPila);
            this.Pila.Controls.Add(this.btnReportePila);
            this.Pila.Controls.Add(this.dataGridViewPila);
            this.Pila.Location = new System.Drawing.Point(4, 22);
            this.Pila.Name = "Pila";
            this.Pila.Padding = new System.Windows.Forms.Padding(3);
            this.Pila.Size = new System.Drawing.Size(863, 74);
            this.Pila.TabIndex = 0;
            this.Pila.Text = "Pila";
            this.Pila.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPila
            // 
            this.btnEliminarPila.Location = new System.Drawing.Point(715, 45);
            this.btnEliminarPila.Name = "btnEliminarPila";
            this.btnEliminarPila.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPila.TabIndex = 2;
            this.btnEliminarPila.Text = "eliminar";
            this.btnEliminarPila.UseVisualStyleBackColor = true;
            this.btnEliminarPila.Click += new System.EventHandler(this.btnEliminarPila_Click);
            // 
            // btnReportePila
            // 
            this.btnReportePila.Location = new System.Drawing.Point(715, 6);
            this.btnReportePila.Name = "btnReportePila";
            this.btnReportePila.Size = new System.Drawing.Size(75, 23);
            this.btnReportePila.TabIndex = 1;
            this.btnReportePila.Text = "reporte";
            this.btnReportePila.UseVisualStyleBackColor = true;
            this.btnReportePila.Click += new System.EventHandler(this.btnReportePila_Click);
            // 
            // dataGridViewPila
            // 
            this.dataGridViewPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPila.Location = new System.Drawing.Point(1, 0);
            this.dataGridViewPila.Name = "dataGridViewPila";
            this.dataGridViewPila.Size = new System.Drawing.Size(693, 74);
            this.dataGridViewPila.TabIndex = 0;
            // 
            // Cola
            // 
            this.Cola.Controls.Add(this.btnEliminarCola);
            this.Cola.Controls.Add(this.btnReporteCola);
            this.Cola.Controls.Add(this.dataGridViewCola);
            this.Cola.Location = new System.Drawing.Point(4, 22);
            this.Cola.Name = "Cola";
            this.Cola.Padding = new System.Windows.Forms.Padding(3);
            this.Cola.Size = new System.Drawing.Size(863, 74);
            this.Cola.TabIndex = 1;
            this.Cola.Text = "Cola";
            this.Cola.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCola
            // 
            this.btnEliminarCola.Location = new System.Drawing.Point(713, 45);
            this.btnEliminarCola.Name = "btnEliminarCola";
            this.btnEliminarCola.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCola.TabIndex = 29;
            this.btnEliminarCola.Text = "eliminar";
            this.btnEliminarCola.UseVisualStyleBackColor = true;
            this.btnEliminarCola.Click += new System.EventHandler(this.btnEliminarCola_Click);
            // 
            // btnReporteCola
            // 
            this.btnReporteCola.Location = new System.Drawing.Point(713, 6);
            this.btnReporteCola.Name = "btnReporteCola";
            this.btnReporteCola.Size = new System.Drawing.Size(75, 23);
            this.btnReporteCola.TabIndex = 28;
            this.btnReporteCola.Text = "reporte";
            this.btnReporteCola.UseVisualStyleBackColor = true;
            this.btnReporteCola.Click += new System.EventHandler(this.btnReporteCola_Click);
            // 
            // dataGridViewCola
            // 
            this.dataGridViewCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCola.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCola.Name = "dataGridViewCola";
            this.dataGridViewCola.Size = new System.Drawing.Size(696, 74);
            this.dataGridViewCola.TabIndex = 27;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.btnEliminarLista);
            this.Lista.Controls.Add(this.btnReporteLista);
            this.Lista.Controls.Add(this.dataGridViewLista);
            this.Lista.Location = new System.Drawing.Point(4, 22);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(863, 74);
            this.Lista.TabIndex = 2;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLista
            // 
            this.btnEliminarLista.Location = new System.Drawing.Point(743, 45);
            this.btnEliminarLista.Name = "btnEliminarLista";
            this.btnEliminarLista.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarLista.TabIndex = 29;
            this.btnEliminarLista.Text = "eliminar";
            this.btnEliminarLista.UseVisualStyleBackColor = true;
            this.btnEliminarLista.Click += new System.EventHandler(this.btnEliminarLista_Click);
            // 
            // btnReporteLista
            // 
            this.btnReporteLista.Location = new System.Drawing.Point(743, 7);
            this.btnReporteLista.Name = "btnReporteLista";
            this.btnReporteLista.Size = new System.Drawing.Size(75, 23);
            this.btnReporteLista.TabIndex = 28;
            this.btnReporteLista.Text = "reporte";
            this.btnReporteLista.UseVisualStyleBackColor = true;
            this.btnReporteLista.Click += new System.EventHandler(this.btnReporteLista_Click);
            // 
            // dataGridViewLista
            // 
            this.dataGridViewLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoIdentificacion,
            this.NumeroIdentificacion,
            this.NombreCompleto,
            this.Edad,
            this.Estrato,
            this.TipoAtencion,
            this.FechaRegistro,
            this.ValorCopago});
            this.dataGridViewLista.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewLista.Name = "dataGridViewLista";
            this.dataGridViewLista.Size = new System.Drawing.Size(741, 74);
            this.dataGridViewLista.TabIndex = 27;
            // 
            // TipoIdentificacion
            // 
            this.TipoIdentificacion.HeaderText = "TipoIdentificacion";
            this.TipoIdentificacion.Name = "TipoIdentificacion";
            // 
            // NumeroIdentificacion
            // 
            this.NumeroIdentificacion.HeaderText = "NumeroIdentificacion";
            this.NumeroIdentificacion.Name = "NumeroIdentificacion";
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.Name = "NombreCompleto";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.Name = "Edad";
            // 
            // Estrato
            // 
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            // 
            // TipoAtencion
            // 
            this.TipoAtencion.HeaderText = "TipoAtencion";
            this.TipoAtencion.Name = "TipoAtencion";
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "FechaRegistro";
            this.FechaRegistro.Name = "FechaRegistro";
            // 
            // ValorCopago
            // 
            this.ValorCopago.HeaderText = "ValorCopago";
            this.ValorCopago.Name = "ValorCopago";
            // 
            // btnCalcularCopago
            // 
            this.btnCalcularCopago.Location = new System.Drawing.Point(170, 326);
            this.btnCalcularCopago.Name = "btnCalcularCopago";
            this.btnCalcularCopago.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularCopago.TabIndex = 27;
            this.btnCalcularCopago.Text = "calcular";
            this.btnCalcularCopago.UseVisualStyleBackColor = true;
            this.btnCalcularCopago.Click += new System.EventHandler(this.btnCalcularCopago_Click);
            // 
            // textBoxReporte
            // 
            this.textBoxReporte.Location = new System.Drawing.Point(134, 367);
            this.textBoxReporte.Name = "textBoxReporte";
            this.textBoxReporte.ReadOnly = true;
            this.textBoxReporte.Size = new System.Drawing.Size(165, 20);
            this.textBoxReporte.TabIndex = 28;
            this.textBoxReporte.TextChanged += new System.EventHandler(this.textBoxReporte_TextChanged);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(171, 165);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(121, 20);
            this.txtNombreCompleto.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(134, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(429, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "porfavor despues de registrar el reporte en \"reporte \" eliminar una copia del mis" +
    "mo graicas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(809, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "johan alexander gil ";
            // 
            // formulariodatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 553);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.textBoxReporte);
            this.Controls.Add(this.btnCalcularCopago);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbmEstructura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.txtValorCopago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbEstrato);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNumeroIdentificacion);
            this.Controls.Add(this.cmbTipoIdentificacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formulariodatos";
            this.Text = "formulario datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Pila.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPila)).EndInit();
            this.Cola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCola)).EndInit();
            this.Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox cmbTipoIdentificacion;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbEstrato;
        private System.Windows.Forms.RadioButton rbtnMedicinaGeneral;
        private System.Windows.Forms.RadioButton rbtnExamenLaboratorio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorCopago;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbmEstructura;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pila;
        private System.Windows.Forms.DataGridView dataGridViewPila;
        private System.Windows.Forms.TabPage Cola;
        private System.Windows.Forms.DataGridView dataGridViewCola;
        private System.Windows.Forms.TabPage Lista;
        private System.Windows.Forms.DataGridView dataGridViewLista;
        private System.Windows.Forms.Button btnCalcularCopago;
        private System.Windows.Forms.TextBox textBoxReporte;
        private System.Windows.Forms.Button btnEliminarPila;
        private System.Windows.Forms.Button btnReportePila;
        private System.Windows.Forms.Button btnReporteCola;
        private System.Windows.Forms.Button btnReporteLista;
        private System.Windows.Forms.Button btnEliminarCola;
        private System.Windows.Forms.Button btnEliminarLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCopago;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}