﻿namespace Practico1v4.Views.Auditorias
{
	partial class MainAuditorias
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.auditEntryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entitySetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.createdDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.auditEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxTabla = new System.Windows.Forms.TextBox();
			this.textBoxCreador = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.auditEntryBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auditEntryIDDataGridViewTextBoxColumn,
            this.entitySetNameDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.createdDateDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.auditEntryBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(628, 396);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// auditEntryIDDataGridViewTextBoxColumn
			// 
			this.auditEntryIDDataGridViewTextBoxColumn.DataPropertyName = "AuditEntryID";
			this.auditEntryIDDataGridViewTextBoxColumn.HeaderText = "Id";
			this.auditEntryIDDataGridViewTextBoxColumn.Name = "auditEntryIDDataGridViewTextBoxColumn";
			this.auditEntryIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// entitySetNameDataGridViewTextBoxColumn
			// 
			this.entitySetNameDataGridViewTextBoxColumn.DataPropertyName = "EntitySetName";
			this.entitySetNameDataGridViewTextBoxColumn.HeaderText = "Tabla";
			this.entitySetNameDataGridViewTextBoxColumn.Name = "entitySetNameDataGridViewTextBoxColumn";
			this.entitySetNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// createdByDataGridViewTextBoxColumn
			// 
			this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
			this.createdByDataGridViewTextBoxColumn.HeaderText = "Creador";
			this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
			this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// createdDateDataGridViewTextBoxColumn
			// 
			this.createdDateDataGridViewTextBoxColumn.DataPropertyName = "CreatedDate";
			this.createdDateDataGridViewTextBoxColumn.HeaderText = "Fecha Creado";
			this.createdDateDataGridViewTextBoxColumn.Name = "createdDateDataGridViewTextBoxColumn";
			this.createdDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// stateDataGridViewTextBoxColumn
			// 
			this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
			this.stateDataGridViewTextBoxColumn.HeaderText = "Estado";
			this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
			this.stateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// auditEntryBindingSource
			// 
			this.auditEntryBindingSource.DataSource = typeof(Z.EntityFramework.Plus.AuditEntry);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(23, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tabla";
			// 
			// textBoxTabla
			// 
			this.textBoxTabla.Location = new System.Drawing.Point(83, 10);
			this.textBoxTabla.Name = "textBoxTabla";
			this.textBoxTabla.Size = new System.Drawing.Size(91, 20);
			this.textBoxTabla.TabIndex = 2;
			this.textBoxTabla.TextChanged += new System.EventHandler(this.textBoxTabla_TextChanged);
			// 
			// textBoxCreador
			// 
			this.textBoxCreador.Location = new System.Drawing.Point(244, 11);
			this.textBoxCreador.Name = "textBoxCreador";
			this.textBoxCreador.Size = new System.Drawing.Size(90, 20);
			this.textBoxCreador.TabIndex = 3;
			this.textBoxCreador.TextChanged += new System.EventHandler(this.textBoxCreador_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(180, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Creador";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(340, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fecha";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxCreador);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxTabla);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(607, 36);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar por:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(392, 10);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 7;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// MainAuditorias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainAuditorias";
			this.Text = "Auditorias";
			this.Load += new System.EventHandler(this.MainAuditorias_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.auditEntryBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource auditEntryBindingSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxTabla;
		private System.Windows.Forms.TextBox textBoxCreador;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DataGridViewTextBoxColumn auditEntryIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn entitySetNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createdDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
	}
}