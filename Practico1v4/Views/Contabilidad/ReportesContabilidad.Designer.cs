namespace Practico1v4.Views.Contabilidad
{
	partial class ReportesContabilidad
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonGenerarMayor = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
			this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxAsientoDesde = new System.Windows.Forms.TextBox();
			this.textBoxAsientoHasta = new System.Windows.Forms.TextBox();
			this.textBoxCuentaHasta = new System.Windows.Forms.TextBox();
			this.textBoxCuentaDesde = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonGenerarDiario = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBoxCuentaHasta);
			this.panel1.Controls.Add(this.textBoxCuentaDesde);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.textBoxAsientoHasta);
			this.panel1.Controls.Add(this.textBoxAsientoDesde);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dateTimePickerHasta);
			this.panel1.Controls.Add(this.dateTimePickerDesde);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(655, 164);
			this.panel1.TabIndex = 0;
			// 
			// buttonGenerarMayor
			// 
			this.buttonGenerarMayor.Location = new System.Drawing.Point(51, 189);
			this.buttonGenerarMayor.Name = "buttonGenerarMayor";
			this.buttonGenerarMayor.Size = new System.Drawing.Size(138, 23);
			this.buttonGenerarMayor.TabIndex = 5;
			this.buttonGenerarMayor.Text = "Generar Mayor";
			this.buttonGenerarMayor.UseVisualStyleBackColor = true;
			this.buttonGenerarMayor.Click += new System.EventHandler(this.buttonGenerarMayor_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(373, 42);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Hasta";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Desde";
			// 
			// dateTimePickerHasta
			// 
			this.dateTimePickerHasta.CustomFormat = "dd/MM/yyyy";
			this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerHasta.Location = new System.Drawing.Point(448, 35);
			this.dateTimePickerHasta.Name = "dateTimePickerHasta";
			this.dateTimePickerHasta.Size = new System.Drawing.Size(99, 20);
			this.dateTimePickerHasta.TabIndex = 1;
			// 
			// dateTimePickerDesde
			// 
			this.dateTimePickerDesde.CustomFormat = "dd/MM/yyyy";
			this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDesde.Location = new System.Drawing.Point(128, 35);
			this.dateTimePickerDesde.Name = "dateTimePickerDesde";
			this.dateTimePickerDesde.Size = new System.Drawing.Size(100, 20);
			this.dateTimePickerDesde.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(373, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Asiento Hasta";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 85);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Asiento Desde";
			// 
			// textBoxAsientoDesde
			// 
			this.textBoxAsientoDesde.Location = new System.Drawing.Point(128, 80);
			this.textBoxAsientoDesde.Name = "textBoxAsientoDesde";
			this.textBoxAsientoDesde.Size = new System.Drawing.Size(100, 20);
			this.textBoxAsientoDesde.TabIndex = 7;
			// 
			// textBoxAsientoHasta
			// 
			this.textBoxAsientoHasta.Location = new System.Drawing.Point(448, 82);
			this.textBoxAsientoHasta.Name = "textBoxAsientoHasta";
			this.textBoxAsientoHasta.Size = new System.Drawing.Size(99, 20);
			this.textBoxAsientoHasta.TabIndex = 8;
			// 
			// textBoxCuentaHasta
			// 
			this.textBoxCuentaHasta.Location = new System.Drawing.Point(448, 124);
			this.textBoxCuentaHasta.Name = "textBoxCuentaHasta";
			this.textBoxCuentaHasta.Size = new System.Drawing.Size(99, 20);
			this.textBoxCuentaHasta.TabIndex = 12;
			// 
			// textBoxCuentaDesde
			// 
			this.textBoxCuentaDesde.Location = new System.Drawing.Point(128, 122);
			this.textBoxCuentaDesde.Name = "textBoxCuentaDesde";
			this.textBoxCuentaDesde.Size = new System.Drawing.Size(100, 20);
			this.textBoxCuentaDesde.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(373, 131);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Cuenta Hasta";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(36, 127);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "Cuenta Desde";
			// 
			// buttonGenerarDiario
			// 
			this.buttonGenerarDiario.Location = new System.Drawing.Point(252, 189);
			this.buttonGenerarDiario.Name = "buttonGenerarDiario";
			this.buttonGenerarDiario.Size = new System.Drawing.Size(135, 23);
			this.buttonGenerarDiario.TabIndex = 6;
			this.buttonGenerarDiario.Text = "Generar Diario";
			this.buttonGenerarDiario.UseVisualStyleBackColor = true;
			// 
			// ReportesContabilidad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 450);
			this.Controls.Add(this.buttonGenerarDiario);
			this.Controls.Add(this.buttonGenerarMayor);
			this.Controls.Add(this.panel1);
			this.Name = "ReportesContabilidad";
			this.Text = "ReportesContabilidad";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonGenerarMayor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
		private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
		private System.Windows.Forms.TextBox textBoxAsientoHasta;
		private System.Windows.Forms.TextBox textBoxAsientoDesde;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxCuentaHasta;
		private System.Windows.Forms.TextBox textBoxCuentaDesde;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonGenerarDiario;
	}
}