namespace Proyecto_DS_OTABORA.Vistas
{
    partial class FrmDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoctores));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Listadoc = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.DgvData = new System.Windows.Forms.DataGridView();
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
            this.AgreDoc = new System.Windows.Forms.TabPage();
            this.TxtIdDoc = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.DtFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtTelfono = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCetificado = new System.Windows.Forms.TextBox();
            this.CmbEspecial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Listadoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.AgreDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Listadoc);
            this.tabControl1.Controls.Add(this.AgreDoc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 446);
            this.tabControl1.TabIndex = 0;
            // 
            // Listadoc
            // 
            this.Listadoc.Controls.Add(this.panel5);
            this.Listadoc.Controls.Add(this.label1);
            this.Listadoc.Controls.Add(this.pictureBox1);
            this.Listadoc.Controls.Add(this.panel6);
            this.Listadoc.Controls.Add(this.BtnEstado);
            this.Listadoc.Controls.Add(this.panel7);
            this.Listadoc.Controls.Add(this.panel8);
            this.Listadoc.Controls.Add(this.panel9);
            this.Listadoc.Controls.Add(this.BtnReporte);
            this.Listadoc.Controls.Add(this.BtnEdit);
            this.Listadoc.Controls.Add(this.BtnNuevo);
            this.Listadoc.Controls.Add(this.TxtBuscar);
            this.Listadoc.Controls.Add(this.DgvData);
            this.Listadoc.Location = new System.Drawing.Point(4, 25);
            this.Listadoc.Margin = new System.Windows.Forms.Padding(4);
            this.Listadoc.Name = "Listadoc";
            this.Listadoc.Padding = new System.Windows.Forms.Padding(4);
            this.Listadoc.Size = new System.Drawing.Size(887, 417);
            this.Listadoc.TabIndex = 0;
            this.Listadoc.Text = "Lista Doctores";
            this.Listadoc.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, -2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(893, 10);
            this.panel5.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 83;
            this.label1.Text = "Busqueda por Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(783, 338);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(853, 220);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 23);
            this.panel6.TabIndex = 81;
            // 
            // BtnEstado
            // 
            this.BtnEstado.FlatAppearance.BorderSize = 0;
            this.BtnEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEstado.Image = ((System.Drawing.Image)(resources.GetObject("BtnEstado.Image")));
            this.BtnEstado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEstado.Location = new System.Drawing.Point(786, 210);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(80, 46);
            this.BtnEstado.TabIndex = 80;
            this.BtnEstado.Text = "Estado";
            this.BtnEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEstado.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(853, 159);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(7, 23);
            this.panel7.TabIndex = 78;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(853, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(7, 23);
            this.panel8.TabIndex = 79;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(853, 38);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(7, 23);
            this.panel9.TabIndex = 77;
            // 
            // BtnReporte
            // 
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnReporte.Image = ((System.Drawing.Image)(resources.GetObject("BtnReporte.Image")));
            this.BtnReporte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporte.Location = new System.Drawing.Point(786, 145);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(80, 50);
            this.BtnReporte.TabIndex = 76;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReporte.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEdit.Location = new System.Drawing.Point(786, 83);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(80, 46);
            this.BtnEdit.TabIndex = 75;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNuevo.Location = new System.Drawing.Point(786, 21);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 44);
            this.BtnNuevo.TabIndex = 74;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(52, 77);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(314, 23);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
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
            this.DgvData.Location = new System.Drawing.Point(52, 123);
            this.DgvData.Name = "DgvData";
            this.DgvData.Size = new System.Drawing.Size(703, 263);
            this.DgvData.TabIndex = 0;
            this.DgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_DOC";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ESPECIALIDAD";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CERTIFICADO";
            this.Column5.Name = "Column5";
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
            this.Column8.HeaderText = "DIRECCION";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "FECHA";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "ESTADO";
            this.Column10.Name = "Column10";
            // 
            // AgreDoc
            // 
            this.AgreDoc.Controls.Add(this.TxtIdDoc);
            this.AgreDoc.Controls.Add(this.pictureBox2);
            this.AgreDoc.Controls.Add(this.panel2);
            this.AgreDoc.Controls.Add(this.panel4);
            this.AgreDoc.Controls.Add(this.panel3);
            this.AgreDoc.Controls.Add(this.BtnCancelar);
            this.AgreDoc.Controls.Add(this.BtnEditar);
            this.AgreDoc.Controls.Add(this.BtnGuardar);
            this.AgreDoc.Controls.Add(this.DtFecha);
            this.AgreDoc.Controls.Add(this.label9);
            this.AgreDoc.Controls.Add(this.TxtDireccion);
            this.AgreDoc.Controls.Add(this.label8);
            this.AgreDoc.Controls.Add(this.label7);
            this.AgreDoc.Controls.Add(this.TxtTelfono);
            this.AgreDoc.Controls.Add(this.label6);
            this.AgreDoc.Controls.Add(this.TxtCorreo);
            this.AgreDoc.Controls.Add(this.label5);
            this.AgreDoc.Controls.Add(this.TxtCetificado);
            this.AgreDoc.Controls.Add(this.CmbEspecial);
            this.AgreDoc.Controls.Add(this.label4);
            this.AgreDoc.Controls.Add(this.label3);
            this.AgreDoc.Controls.Add(this.TxtApellido);
            this.AgreDoc.Controls.Add(this.panel1);
            this.AgreDoc.Controls.Add(this.TxtNombre);
            this.AgreDoc.Controls.Add(this.label2);
            this.AgreDoc.Location = new System.Drawing.Point(4, 25);
            this.AgreDoc.Margin = new System.Windows.Forms.Padding(4);
            this.AgreDoc.Name = "AgreDoc";
            this.AgreDoc.Padding = new System.Windows.Forms.Padding(4);
            this.AgreDoc.Size = new System.Drawing.Size(887, 417);
            this.AgreDoc.TabIndex = 1;
            this.AgreDoc.Text = "Agregar Doc";
            this.AgreDoc.UseVisualStyleBackColor = true;
            // 
            // TxtIdDoc
            // 
            this.TxtIdDoc.Location = new System.Drawing.Point(827, 16);
            this.TxtIdDoc.Name = "TxtIdDoc";
            this.TxtIdDoc.Size = new System.Drawing.Size(53, 23);
            this.TxtIdDoc.TabIndex = 82;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(803, 355);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(837, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 26);
            this.panel2.TabIndex = 79;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(752, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 26);
            this.panel4.TabIndex = 80;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(664, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 26);
            this.panel3.TabIndex = 78;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCancelar.Location = new System.Drawing.Point(761, 275);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(90, 52);
            this.BtnCancelar.TabIndex = 77;
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
            this.BtnEditar.Location = new System.Drawing.Point(676, 274);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(90, 52);
            this.BtnEditar.TabIndex = 76;
            this.BtnEditar.Text = "Actualizar";
            this.BtnEditar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.Image")));
            this.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnGuardar.Location = new System.Drawing.Point(588, 273);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 49);
            this.BtnGuardar.TabIndex = 75;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DtFecha
            // 
            this.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFecha.Location = new System.Drawing.Point(548, 202);
            this.DtFecha.Name = "DtFecha";
            this.DtFecha.Size = new System.Drawing.Size(205, 23);
            this.DtFecha.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(548, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "Fecha Ingreso";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(27, 202);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(463, 62);
            this.TxtDireccion.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 71;
            this.label8.Text = "Direccion:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 16);
            this.label7.TabIndex = 70;
            this.label7.Text = "Numero Telefonico:";
            // 
            // TxtTelfono
            // 
            this.TxtTelfono.Location = new System.Drawing.Point(288, 128);
            this.TxtTelfono.Name = "TxtTelfono";
            this.TxtTelfono.Size = new System.Drawing.Size(202, 23);
            this.TxtTelfono.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(548, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Correo:";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(551, 128);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(202, 23);
            this.TxtCorreo.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Numero Certidicado:";
            // 
            // TxtCetificado
            // 
            this.TxtCetificado.Location = new System.Drawing.Point(27, 128);
            this.TxtCetificado.Name = "TxtCetificado";
            this.TxtCetificado.Size = new System.Drawing.Size(202, 23);
            this.TxtCetificado.TabIndex = 65;
            // 
            // CmbEspecial
            // 
            this.CmbEspecial.FormattingEnabled = true;
            this.CmbEspecial.Items.AddRange(new object[] {
            ""});
            this.CmbEspecial.Location = new System.Drawing.Point(548, 47);
            this.CmbEspecial.Name = "CmbEspecial";
            this.CmbEspecial.Size = new System.Drawing.Size(205, 24);
            this.CmbEspecial.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 63;
            this.label4.Text = "Especialidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 62;
            this.label3.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(288, 48);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(202, 23);
            this.TxtApellido.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 10);
            this.panel1.TabIndex = 60;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(27, 47);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(202, 23);
            this.TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // FrmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 446);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoctores";
            this.Load += new System.EventHandler(this.FrmDoctores_Load);
            this.tabControl1.ResumeLayout(false);
            this.Listadoc.ResumeLayout(false);
            this.Listadoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.AgreDoc.ResumeLayout(false);
            this.AgreDoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Listadoc;
        private System.Windows.Forms.TabPage AgreDoc;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnEstado;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.ComboBox CmbEspecial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox TxtTelfono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCetificado;
        private System.Windows.Forms.DateTimePicker DtFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TxtIdDoc;
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