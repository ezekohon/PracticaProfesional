namespace Practico1v4.Views.Auditorias
{
	partial class TablaAuditoria
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCreador = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxId = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.labelNombreTabla = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 60);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(772, 333);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxCreador);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxId);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(19, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(765, 36);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtrar por:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(556, 10);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
			this.dateTimePicker1.TabIndex = 7;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(491, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fecha";
			// 
			// textBoxCreador
			// 
			this.textBoxCreador.Location = new System.Drawing.Point(362, 11);
			this.textBoxCreador.Name = "textBoxCreador";
			this.textBoxCreador.Size = new System.Drawing.Size(90, 20);
			this.textBoxCreador.TabIndex = 3;
			this.textBoxCreador.TextChanged += new System.EventHandler(this.textBoxCreador_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(95, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Id Registro";
			// 
			// textBoxId
			// 
			this.textBoxId.Location = new System.Drawing.Point(180, 10);
			this.textBoxId.Name = "textBoxId";
			this.textBoxId.Size = new System.Drawing.Size(91, 20);
			this.textBoxId.TabIndex = 2;
			this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(288, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Creador";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelNombreTabla});
			this.statusStrip1.Location = new System.Drawing.Point(0, 396);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(796, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// labelNombreTabla
			// 
			this.labelNombreTabla.Name = "labelNombreTabla";
			this.labelNombreTabla.Size = new System.Drawing.Size(118, 17);
			this.labelNombreTabla.Text = "toolStripStatusLabel1";
			// 
			// TablaAuditoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 418);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "TablaAuditoria";
			this.Text = "TablaAuditoria";
			this.Load += new System.EventHandler(this.TablaAuditoria_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCreador;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel labelNombreTabla;
	}
}