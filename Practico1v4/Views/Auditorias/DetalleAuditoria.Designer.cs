namespace Practico1v4.Views.Auditorias
{
	partial class DetalleAuditoria
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
			this.auditEntryPropertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AuditEntryPropertyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.propertyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.oldValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.newValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.auditEntryPropertyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AuditEntryPropertyID,
            this.propertyNameDataGridViewTextBoxColumn,
            this.oldValueDataGridViewTextBoxColumn,
            this.newValueDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.auditEntryPropertyBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(416, 234);
			this.dataGridView1.TabIndex = 0;
			// 
			// auditEntryPropertyBindingSource
			// 
			this.auditEntryPropertyBindingSource.DataSource = typeof(Z.EntityFramework.Plus.AuditEntryProperty);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "NewValue";
			this.dataGridViewTextBoxColumn1.HeaderText = "NewValue";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "OldValue";
			this.dataGridViewTextBoxColumn2.HeaderText = "OldValue";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// AuditEntryPropertyID
			// 
			this.AuditEntryPropertyID.DataPropertyName = "AuditEntryPropertyID";
			this.AuditEntryPropertyID.HeaderText = "Id";
			this.AuditEntryPropertyID.Name = "AuditEntryPropertyID";
			this.AuditEntryPropertyID.ReadOnly = true;
			this.AuditEntryPropertyID.Width = 103;
			// 
			// propertyNameDataGridViewTextBoxColumn
			// 
			this.propertyNameDataGridViewTextBoxColumn.DataPropertyName = "PropertyName";
			this.propertyNameDataGridViewTextBoxColumn.HeaderText = "Propiedad";
			this.propertyNameDataGridViewTextBoxColumn.Name = "propertyNameDataGridViewTextBoxColumn";
			this.propertyNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.propertyNameDataGridViewTextBoxColumn.Width = 104;
			// 
			// oldValueDataGridViewTextBoxColumn
			// 
			this.oldValueDataGridViewTextBoxColumn.DataPropertyName = "OldValue";
			this.oldValueDataGridViewTextBoxColumn.HeaderText = "Valor Anterior";
			this.oldValueDataGridViewTextBoxColumn.Name = "oldValueDataGridViewTextBoxColumn";
			this.oldValueDataGridViewTextBoxColumn.ReadOnly = true;
			this.oldValueDataGridViewTextBoxColumn.Width = 103;
			// 
			// newValueDataGridViewTextBoxColumn
			// 
			this.newValueDataGridViewTextBoxColumn.DataPropertyName = "NewValue";
			this.newValueDataGridViewTextBoxColumn.HeaderText = "Valor Nuevo";
			this.newValueDataGridViewTextBoxColumn.Name = "newValueDataGridViewTextBoxColumn";
			this.newValueDataGridViewTextBoxColumn.ReadOnly = true;
			this.newValueDataGridViewTextBoxColumn.Width = 103;
			// 
			// DetalleAuditoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 234);
			this.Controls.Add(this.dataGridView1);
			this.Name = "DetalleAuditoria";
			this.Text = "DetalleAuditoria";
			this.Load += new System.EventHandler(this.DetalleAuditoria_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.auditEntryPropertyBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource auditEntryPropertyBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn AuditEntryPropertyID;
		private System.Windows.Forms.DataGridViewTextBoxColumn propertyNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oldValueDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn newValueDataGridViewTextBoxColumn;
	}
}