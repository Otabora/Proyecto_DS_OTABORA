namespace Proyecto_DS_OTABORA.Vistas
{
    partial class FrmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacientes));
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TapListpaciente = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEstadopa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnEditarpa = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TapLisAgregar = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbEstadoC = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFechanac = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIdedntidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.TapListpaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.TapLisAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(49, 80);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(364, 23);
            this.TxtBuscar.TabIndex = 33;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(46, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Busqueda por nombre:";
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(903, 356);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(54, 23);
            this.Txtcodigo.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(-3, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 10);
            this.panel3.TabIndex = 40;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TapListpaciente);
            this.tabControl1.Controls.Add(this.TapLisAgregar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 446);
            this.tabControl1.TabIndex = 41;
            // 
            // TapListpaciente
            // 
            this.TapListpaciente.Controls.Add(this.panel10);
            this.TapListpaciente.Controls.Add(this.pictureBox1);
            this.TapListpaciente.Controls.Add(this.panel6);
            this.TapListpaciente.Controls.Add(this.BtnEstadopa);
            this.TapListpaciente.Controls.Add(this.panel7);
            this.TapListpaciente.Controls.Add(this.panel8);
            this.TapListpaciente.Controls.Add(this.panel9);
            this.TapListpaciente.Controls.Add(this.BtnReporte);
            this.TapListpaciente.Controls.Add(this.BtnEditarpa);
            this.TapListpaciente.Controls.Add(this.button5);
            this.TapListpaciente.Controls.Add(this.DgvData);
            this.TapListpaciente.Controls.Add(this.label10);
            this.TapListpaciente.Controls.Add(this.TxtBuscar);
            this.TapListpaciente.Location = new System.Drawing.Point(4, 25);
            this.TapListpaciente.Name = "TapListpaciente";
            this.TapListpaciente.Padding = new System.Windows.Forms.Padding(3);
            this.TapListpaciente.Size = new System.Drawing.Size(887, 417);
            this.TapListpaciente.TabIndex = 0;
            this.TapListpaciente.Text = "Lista de Pacientes";
            this.TapListpaciente.UseVisualStyleBackColor = true;
            this.TapListpaciente.Click += new System.EventHandler(this.TapListpaciente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(785, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(850, 255);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(8, 26);
            this.panel6.TabIndex = 72;
            // 
            // BtnEstadopa
            // 
            this.BtnEstadopa.FlatAppearance.BorderSize = 0;
            this.BtnEstadopa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstadopa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEstadopa.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstadopa.Image")));
            this.BtnEstadopa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEstadopa.Location = new System.Drawing.Point(774, 243);
            this.BtnEstadopa.Name = "BtnEstadopa";
            this.BtnEstadopa.Size = new System.Drawing.Size(90, 52);
            this.BtnEstadopa.TabIndex = 71;
            this.BtnEstadopa.Text = "Estado";
            this.BtnEstadopa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEstadopa.UseVisualStyleBackColor = true;
            this.BtnEstadopa.Click += new System.EventHandler(this.BtnEstadopa_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(850, 186);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(8, 26);
            this.panel7.TabIndex = 69;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(850, 114);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(8, 26);
            this.panel8.TabIndex = 70;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(850, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(8, 26);
            this.panel9.TabIndex = 68;
            // 
            // BtnReporte
            // 
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnReporte.Image = ((System.Drawing.Image)(resources.GetObject("BtnReporte.Image")));
            this.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporte.Location = new System.Drawing.Point(774, 170);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(90, 52);
            this.BtnReporte.TabIndex = 66;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnEditarpa
            // 
            this.BtnEditarpa.FlatAppearance.BorderSize = 0;
            this.BtnEditarpa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarpa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEditarpa.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditarpa.Image")));
            this.BtnEditarpa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditarpa.Location = new System.Drawing.Point(774, 100);
            this.BtnEditarpa.Name = "BtnEditarpa";
            this.BtnEditarpa.Size = new System.Drawing.Size(90, 52);
            this.BtnEditarpa.TabIndex = 65;
            this.BtnEditarpa.Text = "Editar";
            this.BtnEditarpa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditarpa.UseVisualStyleBackColor = true;
            this.BtnEditarpa.Click += new System.EventHandler(this.BtnEditarpa_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.Location = new System.Drawing.Point(774, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 49);
            this.button5.TabIndex = 64;
            this.button5.Text = "Nuevo";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // DgvData
            // 
            this.DgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.dtNOM,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.DgvData.Location = new System.Drawing.Point(30, 121);
            this.DgvData.Name = "DgvData";
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(713, 268);
            this.DgvData.TabIndex = 13;
            this.DgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellDoubleClick_1);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // dtNOM
            // 
            this.dtNOM.HeaderText = "NOMBRE";
            this.dtNOM.Name = "dtNOM";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "IDENTIDAD";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "FECHA_NAC";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DIRECCION";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SEXO";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TELEFONO";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CORREO";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ESTADO_CIVIL";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ESTADO";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            // 
            // TapLisAgregar
            // 
            this.TapLisAgregar.Controls.Add(this.panel1);
            this.TapLisAgregar.Controls.Add(this.label12);
            this.TapLisAgregar.Controls.Add(this.panel5);
            this.TapLisAgregar.Controls.Add(this.panel2);
            this.TapLisAgregar.Controls.Add(this.panel4);
            this.TapLisAgregar.Controls.Add(this.BtnCancelar);
            this.TapLisAgregar.Controls.Add(this.BtnEditar);
            this.TapLisAgregar.Controls.Add(this.BtnGuardar);
            this.TapLisAgregar.Controls.Add(this.TxtTelefono);
            this.TapLisAgregar.Controls.Add(this.TxtCorreo);
            this.TapLisAgregar.Controls.Add(this.label9);
            this.TapLisAgregar.Controls.Add(this.CmbEstadoC);
            this.TapLisAgregar.Controls.Add(this.label8);
            this.TapLisAgregar.Controls.Add(this.label7);
            this.TapLisAgregar.Controls.Add(this.label1);
            this.TapLisAgregar.Controls.Add(this.CmbSexo);
            this.TapLisAgregar.Controls.Add(this.TxtDireccion);
            this.TapLisAgregar.Controls.Add(this.label6);
            this.TapLisAgregar.Controls.Add(this.DtFechanac);
            this.TapLisAgregar.Controls.Add(this.label5);
            this.TapLisAgregar.Controls.Add(this.TxtIdedntidad);
            this.TapLisAgregar.Controls.Add(this.label4);
            this.TapLisAgregar.Controls.Add(this.TxtApellido);
            this.TapLisAgregar.Controls.Add(this.label3);
            this.TapLisAgregar.Controls.Add(this.TxtNombre);
            this.TapLisAgregar.Controls.Add(this.label2);
            this.TapLisAgregar.Location = new System.Drawing.Point(4, 25);
            this.TapLisAgregar.Name = "TapLisAgregar";
            this.TapLisAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.TapLisAgregar.Size = new System.Drawing.Size(887, 417);
            this.TapLisAgregar.TabIndex = 1;
            this.TapLisAgregar.Text = "Agregar Paciente";
            this.TapLisAgregar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(21, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "Nombres:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(603, 331);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(8, 26);
            this.panel5.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(475, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 26);
            this.panel2.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(338, 334);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 26);
            this.panel4.TabIndex = 53;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(527, 315);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 52);
            this.BtnCancelar.TabIndex = 52;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEditar.Location = new System.Drawing.Point(399, 315);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(90, 52);
            this.BtnEditar.TabIndex = 51;
            this.BtnEditar.Text = "Editar";
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
            this.BtnGuardar.Location = new System.Drawing.Point(262, 315);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 49);
            this.BtnGuardar.TabIndex = 50;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(203, 199);
            this.TxtTelefono.Mask = "9999-9999";
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(155, 23);
            this.TxtTelefono.TabIndex = 49;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(398, 199);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(206, 23);
            this.TxtCorreo.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(658, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 47;
            this.label9.Text = "Estado Civil:";
            // 
            // CmbEstadoC
            // 
            this.CmbEstadoC.FormattingEnabled = true;
            this.CmbEstadoC.Items.AddRange(new object[] {
            "",
            "Soltero",
            "Casado",
            "Union Libre"});
            this.CmbEstadoC.Location = new System.Drawing.Point(661, 198);
            this.CmbEstadoC.Name = "CmbEstadoC";
            this.CmbEstadoC.Size = new System.Drawing.Size(140, 24);
            this.CmbEstadoC.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(405, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Correo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(200, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Telefono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Sexo:";
            // 
            // CmbSexo
            // 
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.CmbSexo.Location = new System.Drawing.Point(28, 198);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(140, 24);
            this.CmbSexo.TabIndex = 42;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(266, 127);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(535, 23);
            this.TxtDireccion.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(298, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Direccion";
            // 
            // DtFechanac
            // 
            this.DtFechanac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFechanac.Location = new System.Drawing.Point(24, 127);
            this.DtFechanac.Name = "DtFechanac";
            this.DtFechanac.Size = new System.Drawing.Size(206, 23);
            this.DtFechanac.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // TxtIdedntidad
            // 
            this.TxtIdedntidad.Location = new System.Drawing.Point(545, 55);
            this.TxtIdedntidad.Name = "TxtIdedntidad";
            this.TxtIdedntidad.Size = new System.Drawing.Size(256, 23);
            this.TxtIdedntidad.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(542, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Identidad:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(266, 55);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(247, 23);
            this.TxtApellido.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(263, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Apellidos:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(24, 55);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(215, 23);
            this.TxtNombre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-217, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombres:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 10);
            this.panel1.TabIndex = 86;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel10.Location = new System.Drawing.Point(0, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(893, 10);
            this.panel10.TabIndex = 86;
            // 
            // FrmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 446);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Txtcodigo);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.FrmPacientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.TapListpaciente.ResumeLayout(false);
            this.TapListpaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.TapLisAgregar.ResumeLayout(false);
            this.TapLisAgregar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TapListpaciente;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TabPage TapLisAgregar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.MaskedTextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbEstadoC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtFechanac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIdedntidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnEditarpa;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnEstadopa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel1;
    }
}