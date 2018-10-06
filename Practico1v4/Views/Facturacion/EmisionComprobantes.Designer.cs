namespace Practico1v4.Views.Facturacion
{
	partial class EmisionComprobantes
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxClientes = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.comboBoxComprobante = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBoxArticulos = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.buttonAgregar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxNeto21 = new System.Windows.Forms.TextBox();
			this.textBoxIVA21 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxNeto27 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxIVA27 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxExento = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxNoGravado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxRNI = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxRetenciones = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxTotal = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.buttonGuardarImprimir = new System.Windows.Forms.Button();
			this.buttonEliminar = new System.Windows.Forms.Button();
			this.buttonAceptar = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nroArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioNetoVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tasaIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.impuestosInternosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.articuloIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.articuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tempComprobanteRenglonBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tempComprobanteRenglonBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.buttonAceptar);
			this.panel1.Controls.Add(this.comboBoxComprobante);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboBoxClientes);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 66);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cliente";
			// 
			// comboBoxClientes
			// 
			this.comboBoxClientes.FormattingEnabled = true;
			this.comboBoxClientes.Location = new System.Drawing.Point(15, 28);
			this.comboBoxClientes.Name = "comboBoxClientes";
			this.comboBoxClientes.Size = new System.Drawing.Size(201, 21);
			this.comboBoxClientes.TabIndex = 1;
			this.comboBoxClientes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientes_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(248, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Fecha";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(239, 28);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// comboBoxComprobante
			// 
			this.comboBoxComprobante.FormattingEnabled = true;
			this.comboBoxComprobante.Location = new System.Drawing.Point(361, 28);
			this.comboBoxComprobante.Name = "comboBoxComprobante";
			this.comboBoxComprobante.Size = new System.Drawing.Size(166, 21);
			this.comboBoxComprobante.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(368, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Comprobante";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Location = new System.Drawing.Point(12, 84);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 214);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.textBoxTotal);
			this.panel3.Controls.Add(this.label14);
			this.panel3.Controls.Add(this.textBoxRetenciones);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.textBoxRNI);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.textBoxNoGravado);
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.textBoxExento);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.textBoxIVA27);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.textBoxNeto27);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.textBoxIVA21);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.textBoxNeto21);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Location = new System.Drawing.Point(12, 304);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(776, 128);
			this.panel3.TabIndex = 2;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.buttonEliminar);
			this.panel4.Controls.Add(this.buttonAgregar);
			this.panel4.Controls.Add(this.textBoxCantidad);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.comboBoxArticulos);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Location = new System.Drawing.Point(15, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(746, 46);
			this.panel4.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn,
            this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn,
            this.nroArticuloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioNetoVentaDataGridViewTextBoxColumn,
            this.tasaIVADataGridViewTextBoxColumn,
            this.impuestosInternosDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.articuloIdDataGridViewTextBoxColumn,
            this.articuloDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tempComprobanteRenglonBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(15, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(746, 136);
			this.dataGridView1.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(31, 14);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Articulo";
			// 
			// comboBoxArticulos
			// 
			this.comboBoxArticulos.FormattingEnabled = true;
			this.comboBoxArticulos.Location = new System.Drawing.Point(90, 11);
			this.comboBoxArticulos.Name = "comboBoxArticulos";
			this.comboBoxArticulos.Size = new System.Drawing.Size(161, 21);
			this.comboBoxArticulos.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(284, 14);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Cantidad";
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Location = new System.Drawing.Point(346, 11);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
			this.textBoxCantidad.TabIndex = 8;
			// 
			// buttonAgregar
			// 
			this.buttonAgregar.Location = new System.Drawing.Point(477, 9);
			this.buttonAgregar.Name = "buttonAgregar";
			this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
			this.buttonAgregar.TabIndex = 9;
			this.buttonAgregar.Text = "Agregar";
			this.buttonAgregar.UseVisualStyleBackColor = true;
			this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(188, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(108, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Neto Gravado al 21%";
			// 
			// textBoxNeto21
			// 
			this.textBoxNeto21.Location = new System.Drawing.Point(302, 7);
			this.textBoxNeto21.Name = "textBoxNeto21";
			this.textBoxNeto21.ReadOnly = true;
			this.textBoxNeto21.Size = new System.Drawing.Size(100, 20);
			this.textBoxNeto21.TabIndex = 10;
			// 
			// textBoxIVA21
			// 
			this.textBoxIVA21.Location = new System.Drawing.Point(302, 33);
			this.textBoxIVA21.Name = "textBoxIVA21";
			this.textBoxIVA21.ReadOnly = true;
			this.textBoxIVA21.Size = new System.Drawing.Size(100, 20);
			this.textBoxIVA21.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(188, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "IVA facturado al 21%";
			// 
			// textBoxNeto27
			// 
			this.textBoxNeto27.Location = new System.Drawing.Point(302, 59);
			this.textBoxNeto27.Name = "textBoxNeto27";
			this.textBoxNeto27.ReadOnly = true;
			this.textBoxNeto27.Size = new System.Drawing.Size(100, 20);
			this.textBoxNeto27.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(188, 62);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(108, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Neto Gravado al 27%";
			// 
			// textBoxIVA27
			// 
			this.textBoxIVA27.Location = new System.Drawing.Point(302, 85);
			this.textBoxIVA27.Name = "textBoxIVA27";
			this.textBoxIVA27.ReadOnly = true;
			this.textBoxIVA27.Size = new System.Drawing.Size(100, 20);
			this.textBoxIVA27.TabIndex = 15;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(188, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(106, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "IVA facturado al 27%";
			// 
			// textBoxExento
			// 
			this.textBoxExento.Location = new System.Drawing.Point(492, 7);
			this.textBoxExento.Name = "textBoxExento";
			this.textBoxExento.ReadOnly = true;
			this.textBoxExento.Size = new System.Drawing.Size(100, 20);
			this.textBoxExento.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(421, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Exento";
			// 
			// textBoxNoGravado
			// 
			this.textBoxNoGravado.Location = new System.Drawing.Point(492, 33);
			this.textBoxNoGravado.Name = "textBoxNoGravado";
			this.textBoxNoGravado.ReadOnly = true;
			this.textBoxNoGravado.Size = new System.Drawing.Size(100, 20);
			this.textBoxNoGravado.TabIndex = 19;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(421, 36);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(65, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "No Gravado";
			// 
			// textBoxRNI
			// 
			this.textBoxRNI.Location = new System.Drawing.Point(492, 62);
			this.textBoxRNI.Name = "textBoxRNI";
			this.textBoxRNI.ReadOnly = true;
			this.textBoxRNI.Size = new System.Drawing.Size(100, 20);
			this.textBoxRNI.TabIndex = 21;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(421, 66);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(26, 13);
			this.label12.TabIndex = 22;
			this.label12.Text = "RNI";
			// 
			// textBoxRetenciones
			// 
			this.textBoxRetenciones.Location = new System.Drawing.Point(492, 91);
			this.textBoxRetenciones.Name = "textBoxRetenciones";
			this.textBoxRetenciones.ReadOnly = true;
			this.textBoxRetenciones.Size = new System.Drawing.Size(100, 20);
			this.textBoxRetenciones.TabIndex = 23;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(419, 94);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 13);
			this.label13.TabIndex = 24;
			this.label13.Text = "Retenciones";
			// 
			// textBoxTotal
			// 
			this.textBoxTotal.Location = new System.Drawing.Point(661, 62);
			this.textBoxTotal.Name = "textBoxTotal";
			this.textBoxTotal.ReadOnly = true;
			this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotal.TabIndex = 25;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(692, 40);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(31, 13);
			this.label14.TabIndex = 26;
			this.label14.Text = "Total";
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Location = new System.Drawing.Point(448, 438);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(105, 26);
			this.buttonGuardar.TabIndex = 3;
			this.buttonGuardar.Text = "Guardar";
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// buttonGuardarImprimir
			// 
			this.buttonGuardarImprimir.Location = new System.Drawing.Point(567, 438);
			this.buttonGuardarImprimir.Name = "buttonGuardarImprimir";
			this.buttonGuardarImprimir.Size = new System.Drawing.Size(105, 26);
			this.buttonGuardarImprimir.TabIndex = 4;
			this.buttonGuardarImprimir.Text = "Guardar e Imprimir";
			this.buttonGuardarImprimir.UseVisualStyleBackColor = true;
			// 
			// buttonEliminar
			// 
			this.buttonEliminar.Location = new System.Drawing.Point(646, 8);
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
			this.buttonEliminar.TabIndex = 10;
			this.buttonEliminar.Text = "Eliminar";
			this.buttonEliminar.UseVisualStyleBackColor = true;
			// 
			// buttonAceptar
			// 
			this.buttonAceptar.Location = new System.Drawing.Point(661, 29);
			this.buttonAceptar.Name = "buttonAceptar";
			this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
			this.buttonAceptar.TabIndex = 11;
			this.buttonAceptar.Text = "Aceptar";
			this.buttonAceptar.UseVisualStyleBackColor = true;
			this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn
			// 
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn.DataPropertyName = "tempComprobanteEncabezadoPieId";
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn.HeaderText = "tempComprobanteEncabezadoPieId";
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn.Name = "tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn";
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// tempComprobanteEncabezadoPieDataGridViewTextBoxColumn
			// 
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn.DataPropertyName = "tempComprobanteEncabezadoPie";
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn.HeaderText = "tempComprobanteEncabezadoPie";
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn.Name = "tempComprobanteEncabezadoPieDataGridViewTextBoxColumn";
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn.ReadOnly = true;
			this.tempComprobanteEncabezadoPieDataGridViewTextBoxColumn.Visible = false;
			// 
			// nroArticuloDataGridViewTextBoxColumn
			// 
			this.nroArticuloDataGridViewTextBoxColumn.DataPropertyName = "NroArticulo";
			this.nroArticuloDataGridViewTextBoxColumn.HeaderText = "NroArticulo";
			this.nroArticuloDataGridViewTextBoxColumn.Name = "nroArticuloDataGridViewTextBoxColumn";
			this.nroArticuloDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descripcionDataGridViewTextBoxColumn
			// 
			this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
			this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
			this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
			this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// precioNetoVentaDataGridViewTextBoxColumn
			// 
			this.precioNetoVentaDataGridViewTextBoxColumn.DataPropertyName = "PrecioNetoVenta";
			this.precioNetoVentaDataGridViewTextBoxColumn.HeaderText = "PrecioNetoVenta";
			this.precioNetoVentaDataGridViewTextBoxColumn.Name = "precioNetoVentaDataGridViewTextBoxColumn";
			this.precioNetoVentaDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tasaIVADataGridViewTextBoxColumn
			// 
			this.tasaIVADataGridViewTextBoxColumn.DataPropertyName = "TasaIVA";
			this.tasaIVADataGridViewTextBoxColumn.HeaderText = "TasaIVA";
			this.tasaIVADataGridViewTextBoxColumn.Name = "tasaIVADataGridViewTextBoxColumn";
			this.tasaIVADataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// impuestosInternosDataGridViewTextBoxColumn
			// 
			this.impuestosInternosDataGridViewTextBoxColumn.DataPropertyName = "ImpuestosInternos";
			this.impuestosInternosDataGridViewTextBoxColumn.HeaderText = "ImpuestosInternos";
			this.impuestosInternosDataGridViewTextBoxColumn.Name = "impuestosInternosDataGridViewTextBoxColumn";
			this.impuestosInternosDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// cantidadDataGridViewTextBoxColumn
			// 
			this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
			this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
			this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// importeDataGridViewTextBoxColumn
			// 
			this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
			this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
			this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
			this.importeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// articuloIdDataGridViewTextBoxColumn
			// 
			this.articuloIdDataGridViewTextBoxColumn.DataPropertyName = "ArticuloId";
			this.articuloIdDataGridViewTextBoxColumn.HeaderText = "ArticuloId";
			this.articuloIdDataGridViewTextBoxColumn.Name = "articuloIdDataGridViewTextBoxColumn";
			this.articuloIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.articuloIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// articuloDataGridViewTextBoxColumn
			// 
			this.articuloDataGridViewTextBoxColumn.DataPropertyName = "Articulo";
			this.articuloDataGridViewTextBoxColumn.HeaderText = "Articulo";
			this.articuloDataGridViewTextBoxColumn.Name = "articuloDataGridViewTextBoxColumn";
			this.articuloDataGridViewTextBoxColumn.ReadOnly = true;
			this.articuloDataGridViewTextBoxColumn.Visible = false;
			// 
			// tempComprobanteRenglonBindingSource
			// 
			this.tempComprobanteRenglonBindingSource.DataSource = typeof(Practico1v4.Models.tempComprobanteRenglon);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(683, 438);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(105, 26);
			this.buttonCancelar.TabIndex = 5;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			// 
			// EmisionComprobantes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 476);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonGuardarImprimir);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "EmisionComprobantes";
			this.Text = "EmisionComprobantes";
			this.Load += new System.EventHandler(this.EmisionComprobantes_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tempComprobanteRenglonBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBoxComprobante;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxClientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button buttonAgregar;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxArticulos;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxTotal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBoxRetenciones;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox textBoxRNI;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox textBoxNoGravado;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBoxExento;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxIVA27;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNeto27;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxIVA21;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxNeto21;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Button buttonGuardarImprimir;
		private System.Windows.Forms.Button buttonEliminar;
		private System.Windows.Forms.BindingSource tempComprobanteRenglonBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tempComprobanteEncabezadoPieIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tempComprobanteEncabezadoPieDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nroArticuloDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioNetoVentaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tasaIVADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn impuestosInternosDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn articuloIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonAceptar;
		private System.Windows.Forms.Button buttonCancelar;
	}
}