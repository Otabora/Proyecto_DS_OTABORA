namespace Proyecto_DS_OTABORA.Vistas
{
    partial class FrmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ListaCitas = new System.Windows.Forms.TabPage();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEstadopa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnEditarpa = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.AgregarCitas = new System.Windows.Forms.TabPage();
            this.CmbConsul = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtNuevaCita = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtObservacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbServ = new System.Windows.Forms.ComboBox();
            this.TxtDiagnostico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFechacita = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.CmbPaciente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtCita = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.ListaCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AgregarCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ListaCitas);
            this.tabControl1.Controls.Add(this.AgregarCitas);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // ListaCitas
            // 
            this.ListaCitas.Controls.Add(this.DgvData);
            this.ListaCitas.Controls.Add(this.groupBox1);
            this.ListaCitas.Controls.Add(this.panel5);
            this.ListaCitas.Controls.Add(this.pictureBox1);
            this.ListaCitas.Controls.Add(this.panel6);
            this.ListaCitas.Controls.Add(this.BtnEstadopa);
            this.ListaCitas.Controls.Add(this.panel7);
            this.ListaCitas.Controls.Add(this.panel8);
            this.ListaCitas.Controls.Add(this.panel9);
            this.ListaCitas.Controls.Add(this.BtnReporte);
            this.ListaCitas.Controls.Add(this.BtnEditarpa);
            this.ListaCitas.Controls.Add(this.BtnNuevo);
            this.ListaCitas.Location = new System.Drawing.Point(4, 25);
            this.ListaCitas.Name = "ListaCitas";
            this.ListaCitas.Padding = new System.Windows.Forms.Padding(3);
            this.ListaCitas.Size = new System.Drawing.Size(887, 417);
            this.ListaCitas.TabIndex = 0;
            this.ListaCitas.Text = "Lista de Citas";
            this.ListaCitas.UseVisualStyleBackColor = true;
            this.ListaCitas.Click += new System.EventHandler(this.ListaCitas_Click);
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DgvData.Location = new System.Drawing.Point(29, 153);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(737, 150);
            this.DgvData.TabIndex = 87;
            this.DgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(86, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 77);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busquedas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(-3, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(893, 10);
            this.panel5.TabIndex = 85;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(776, 339);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(855, 253);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 26);
            this.panel6.TabIndex = 80;
            // 
            // BtnEstadopa
            // 
            this.BtnEstadopa.FlatAppearance.BorderSize = 0;
            this.BtnEstadopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadopa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEstadopa.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadopa.Image")));
            this.BtnEstadopa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEstadopa.Location = new System.Drawing.Point(779, 241);
            this.BtnEstadopa.Name = "BtnEstadopa";
            this.BtnEstadopa.Size = new System.Drawing.Size(90, 52);
            this.BtnEstadopa.TabIndex = 79;
            this.BtnEstadopa.Text = "Estado";
            this.BtnEstadopa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEstadopa.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(855, 184);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 26);
            this.panel7.TabIndex = 77;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(855, 112);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 26);
            this.panel8.TabIndex = 78;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(855, 48);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 26);
            this.panel9.TabIndex = 76;
            // 
            // BtnReporte
            // 
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnReporte.Image = ((System.Drawing.Image)(resources.GetObject("BtnReporte.Image")));
            this.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporte.Location = new System.Drawing.Point(779, 168);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(90, 52);
            this.BtnReporte.TabIndex = 75;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReporte.UseVisualStyleBackColor = true;
            // 
            // BtnEditarpa
            // 
            this.BtnEditarpa.FlatAppearance.BorderSize = 0;
            this.BtnEditarpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEditarpa.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarpa.Image")));
            this.BtnEditarpa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditarpa.Location = new System.Drawing.Point(779, 98);
            this.BtnEditarpa.Name = "BtnEditarpa";
            this.BtnEditarpa.Size = new System.Drawing.Size(90, 52);
            this.BtnEditarpa.TabIndex = 74;
            this.BtnEditarpa.Text = "Editar";
            this.BtnEditarpa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditarpa.UseVisualStyleBackColor = true;
            this.BtnEditarpa.Click += new System.EventHandler(this.BtnEditarpa_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(779, 29);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(90, 49);
            this.BtnNuevo.TabIndex = 73;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // AgregarCitas
            // 
            this.AgregarCitas.Controls.Add(this.label11);
            this.AgregarCitas.Controls.Add(this.TxtCita);
            this.AgregarCitas.Controls.Add(this.button1);
            this.AgregarCitas.Controls.Add(this.CmbConsul);
            this.AgregarCitas.Controls.Add(this.label7);
            this.AgregarCitas.Controls.Add(this.pictureBox2);
            this.AgregarCitas.Controls.Add(this.panel2);
            this.AgregarCitas.Controls.Add(this.panel4);
            this.AgregarCitas.Controls.Add(this.panel3);
            this.AgregarCitas.Controls.Add(this.BtnCancelar);
            this.AgregarCitas.Controls.Add(this.BtnEditar);
            this.AgregarCitas.Controls.Add(this.BtnGuardar);
            this.AgregarCitas.Controls.Add(this.DtNuevaCita);
            this.AgregarCitas.Controls.Add(this.label10);
            this.AgregarCitas.Controls.Add(this.TxtObservacion);
            this.AgregarCitas.Controls.Add(this.label9);
            this.AgregarCitas.Controls.Add(this.label8);
            this.AgregarCitas.Controls.Add(this.CmbServ);
            this.AgregarCitas.Controls.Add(this.TxtDiagnostico);
            this.AgregarCitas.Controls.Add(this.label6);
            this.AgregarCitas.Controls.Add(this.DtFechacita);
            this.AgregarCitas.Controls.Add(this.label5);
            this.AgregarCitas.Controls.Add(this.CmbDoctor);
            this.AgregarCitas.Controls.Add(this.CmbPaciente);
            this.AgregarCitas.Controls.Add(this.label4);
            this.AgregarCitas.Controls.Add(this.label3);
            this.AgregarCitas.Controls.Add(this.label2);
            this.AgregarCitas.Controls.Add(this.panel1);
            this.AgregarCitas.Location = new System.Drawing.Point(4, 25);
            this.AgregarCitas.Name = "AgregarCitas";
            this.AgregarCitas.Padding = new System.Windows.Forms.Padding(3);
            this.AgregarCitas.Size = new System.Drawing.Size(887, 417);
            this.AgregarCitas.TabIndex = 1;
            this.AgregarCitas.Text = "Agregar Citas";
            this.AgregarCitas.UseVisualStyleBackColor = true;
            this.AgregarCitas.Click += new System.EventHandler(this.AgregarCitas_Click);
            // 
            // CmbConsul
            // 
            this.CmbConsul.FormattingEnabled = true;
            this.CmbConsul.Location = new System.Drawing.Point(48, 240);
            this.CmbConsul.Name = "CmbConsul";
            this.CmbConsul.Size = new System.Drawing.Size(144, 24);
            this.CmbConsul.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 114;
            this.label7.Text = "Consultorio:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(809, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(865, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 26);
            this.panel2.TabIndex = 111;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(780, 378);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 26);
            this.panel4.TabIndex = 112;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(692, 378);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 26);
            this.panel3.TabIndex = 110;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(789, 357);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 52);
            this.BtnCancelar.TabIndex = 109;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.Location = new System.Drawing.Point(704, 356);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(90, 52);
            this.BtnEditar.TabIndex = 108;
            this.BtnEditar.Text = "Actualizar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(616, 355);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 49);
            this.BtnGuardar.TabIndex = 107;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // DtNuevaCita
            // 
            this.DtNuevaCita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtNuevaCita.Location = new System.Drawing.Point(229, 241);
            this.DtNuevaCita.Name = "DtNuevaCita";
            this.DtNuevaCita.Size = new System.Drawing.Size(200, 23);
            this.DtNuevaCita.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 105;
            this.label10.Text = "Nueva Cita:";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Location = new System.Drawing.Point(48, 295);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            this.TxtObservacion.Size = new System.Drawing.Size(553, 63);
            this.TxtObservacion.TabIndex = 104;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 16);
            this.label9.TabIndex = 103;
            this.label9.Text = "Observaciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 16);
            this.label8.TabIndex = 101;
            this.label8.Text = "Servicio Brindado:";
            // 
            // CmbServ
            // 
            this.CmbServ.FormattingEnabled = true;
            this.CmbServ.Location = new System.Drawing.Point(507, 151);
            this.CmbServ.Name = "CmbServ";
            this.CmbServ.Size = new System.Drawing.Size(321, 24);
            this.CmbServ.TabIndex = 100;
            // 
            // TxtDiagnostico
            // 
            this.TxtDiagnostico.Location = new System.Drawing.Point(48, 151);
            this.TxtDiagnostico.Multiline = true;
            this.TxtDiagnostico.Name = "TxtDiagnostico";
            this.TxtDiagnostico.Size = new System.Drawing.Size(426, 40);
            this.TxtDiagnostico.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 97;
            this.label6.Text = "Diagnostico:";
            // 
            // DtFechacita
            // 
            this.DtFechacita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechacita.Location = new System.Drawing.Point(628, 82);
            this.DtFechacita.Name = "DtFechacita";
            this.DtFechacita.Size = new System.Drawing.Size(200, 23);
            this.DtFechacita.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "Fecha de Cita:";
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Location = new System.Drawing.Point(326, 81);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(220, 24);
            this.CmbDoctor.TabIndex = 94;
            // 
            // CmbPaciente
            // 
            this.CmbPaciente.FormattingEnabled = true;
            this.CmbPaciente.Location = new System.Drawing.Point(43, 81);
            this.CmbPaciente.Name = "CmbPaciente";
            this.CmbPaciente.Size = new System.Drawing.Size(220, 24);
            this.CmbPaciente.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Doctor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Agregar Citas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Paciente:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 10);
            this.panel1.TabIndex = 86;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(269, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 29);
            this.button1.TabIndex = 116;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtCita
            // 
            this.TxtCita.Location = new System.Drawing.Point(159, 19);
            this.TxtCita.Name = "TxtCita";
            this.TxtCita.Size = new System.Drawing.Size(58, 23);
            this.TxtCita.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 118;
            this.label11.Text = "Numero de Cita:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PACIENTE";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DOCTOR";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "FECHACITA";
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "SERVICIO";
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CONSULTORIO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DIAGNOSTICO";
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "OBSERVACIONES";
            this.Column8.Name = "Column8";
            this.Column8.Width = 200;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "NUEVA CITA";
            this.Column9.Name = "Column9";
            this.Column9.Width = 90;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ESTADO";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // FrmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 446);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCitas";
            this.Text = "CItas/Consultas";
            this.Load += new System.EventHandler(this.FrmCitas_Load);
            this.tabControl1.ResumeLayout(false);
            this.ListaCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AgregarCitas.ResumeLayout(false);
            this.AgregarCitas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ListaCitas;
        private System.Windows.Forms.TabPage AgregarCitas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnEstadopa;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnEditarpa;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbServ;
        private System.Windows.Forms.TextBox TxtDiagnostico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtFechacita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.ComboBox CmbPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtNuevaCita;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtObservacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox CmbConsul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}