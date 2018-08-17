namespace Practico1v4.Views.Contabilidad
{
	partial class abmPlanDeCuentas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(abmPlanDeCuentas));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textBoxBuscar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonInsertar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBorrar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonReporte = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxCodBalanceHijo = new System.Windows.Forms.TextBox();
			this.comboBoxTipo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxCodBalance = new System.Windows.Forms.TextBox();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigoBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoBalance,
            this.Nombre,
            this.Tipo});
			this.dataGridView1.DataSource = this.cuentaBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(3, 154);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(626, 294);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			// 
			// textBoxBuscar
			// 
			this.textBoxBuscar.Location = new System.Drawing.Point(82, 128);
			this.textBoxBuscar.Name = "textBoxBuscar";
			this.textBoxBuscar.Size = new System.Drawing.Size(141, 20);
			this.textBoxBuscar.TabIndex = 1;
			this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Buscar ";
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsertar,
            this.toolStripButtonEditar,
            this.toolStripButtonBorrar,
            this.toolStripSeparator1,
            this.toolStripButtonReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(630, 50);
			this.toolStrip1.TabIndex = 5;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonInsertar
			// 
			this.toolStripButtonInsertar.AutoSize = false;
			this.toolStripButtonInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonInsertar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertar.Image")));
			this.toolStripButtonInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonInsertar.Name = "toolStripButtonInsertar";
			this.toolStripButtonInsertar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonInsertar.Text = "toolStripButton1";
			this.toolStripButtonInsertar.Click += new System.EventHandler(this.toolStripButtonInsertar_Click);
			// 
			// toolStripButtonEditar
			// 
			this.toolStripButtonEditar.AutoSize = false;
			this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
			this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditar.Name = "toolStripButtonEditar";
			this.toolStripButtonEditar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonEditar.Text = "toolStripButton2";
			this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
			// 
			// toolStripButtonBorrar
			// 
			this.toolStripButtonBorrar.AutoSize = false;
			this.toolStripButtonBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBorrar.Image")));
			this.toolStripButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBorrar.Name = "toolStripButtonBorrar";
			this.toolStripButtonBorrar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonBorrar.Text = "toolStripButton3";
			this.toolStripButtonBorrar.Click += new System.EventHandler(this.toolStripButtonBorrar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
			// 
			// toolStripButtonReporte
			// 
			this.toolStripButtonReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonReporte.AutoSize = false;
			this.toolStripButtonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonReporte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReporte.Image")));
			this.toolStripButtonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonReporte.Name = "toolStripButtonReporte";
			this.toolStripButtonReporte.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonReporte.Text = "toolStripButton4";
			this.toolStripButtonReporte.Click += new System.EventHandler(this.toolStripButtonReporte_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.buttonGuardar);
			this.panel1.Controls.Add(this.textBoxCodBalanceHijo);
			this.panel1.Controls.Add(this.comboBoxTipo);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxCodBalance);
			this.panel1.Controls.Add(this.textBoxNombre);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Enabled = false;
			this.panel1.Location = new System.Drawing.Point(3, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(626, 79);
			this.panel1.TabIndex = 6;
			// 
			// textBoxCodBalanceHijo
			// 
			this.textBoxCodBalanceHijo.Location = new System.Drawing.Point(214, 9);
			this.textBoxCodBalanceHijo.Name = "textBoxCodBalanceHijo";
			this.textBoxCodBalanceHijo.Size = new System.Drawing.Size(52, 20);
			this.textBoxCodBalanceHijo.TabIndex = 17;
			this.textBoxCodBalanceHijo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodBalanceHijo_KeyPress);
			// 
			// comboBoxTipo
			// 
			this.comboBoxTipo.FormattingEnabled = true;
			this.comboBoxTipo.Items.AddRange(new object[] {
            "0",
            "1"});
			this.comboBoxTipo.Location = new System.Drawing.Point(342, 9);
			this.comboBoxTipo.Name = "comboBoxTipo";
			this.comboBoxTipo.Size = new System.Drawing.Size(100, 21);
			this.comboBoxTipo.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(296, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 13);
			this.label1.TabIndex = 13;
			this.label1.Text = "Tipo";
			// 
			// textBoxCodBalance
			// 
			this.textBoxCodBalance.Location = new System.Drawing.Point(108, 9);
			this.textBoxCodBalance.Name = "textBoxCodBalance";
			this.textBoxCodBalance.ReadOnly = true;
			this.textBoxCodBalance.Size = new System.Drawing.Size(100, 20);
			this.textBoxCodBalance.TabIndex = 12;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(108, 46);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(334, 20);
			this.textBoxNombre.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Codigo Balance";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Nombre";
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Location = new System.Drawing.Point(546, 51);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
			this.buttonGuardar.TabIndex = 18;
			this.buttonGuardar.Text = "Guardar";
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// codigoBalance
			// 
			this.codigoBalance.DataPropertyName = "CodigoBalance";
			this.codigoBalance.HeaderText = "CodigoBalance";
			this.codigoBalance.Name = "codigoBalance";
			this.codigoBalance.ReadOnly = true;
			// 
			// Nombre
			// 
			this.Nombre.DataPropertyName = "Nombre";
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "Tipo";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// cuentaBindingSource
			// 
			this.cuentaBindingSource.DataSource = typeof(Practico1v4.Models.Cuenta);
			// 
			// PlanDeCuentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 450);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxBuscar);
			this.Controls.Add(this.dataGridView1);
			this.Name = "PlanDeCuentas";
			this.Text = "PlanDeCuentas";
			this.Load += new System.EventHandler(this.PlanDeCuentas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cuentaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource cuentaBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn codigoBalance;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.TextBox textBoxBuscar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButtonInsertar;
		private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
		private System.Windows.Forms.ToolStripButton toolStripButtonBorrar;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton toolStripButtonReporte;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBoxTipo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxCodBalance;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCodBalanceHijo;
		private System.Windows.Forms.Button buttonGuardar;
	}
}