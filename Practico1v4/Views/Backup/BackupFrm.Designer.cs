namespace Practico1v4.Views.Backup
{
	partial class BackupFrm
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
			this.buttonBackup = new System.Windows.Forms.Button();
			this.buttonRestaurar = new System.Windows.Forms.Button();
			this.textBoxRestauracion = new System.Windows.Forms.TextBox();
			this.buttonBuscarRestaurar = new System.Windows.Forms.Button();
			this.buttonRestaurarElegir = new System.Windows.Forms.Button();
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.textBoxBackup = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonBackup
			// 
			this.buttonBackup.Enabled = false;
			this.buttonBackup.Location = new System.Drawing.Point(31, 77);
			this.buttonBackup.Name = "buttonBackup";
			this.buttonBackup.Size = new System.Drawing.Size(191, 23);
			this.buttonBackup.TabIndex = 2;
			this.buttonBackup.Text = "Copia de Seguridad";
			this.buttonBackup.UseVisualStyleBackColor = true;
			this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
			// 
			// buttonRestaurar
			// 
			this.buttonRestaurar.Location = new System.Drawing.Point(31, 251);
			this.buttonRestaurar.Name = "buttonRestaurar";
			this.buttonRestaurar.Size = new System.Drawing.Size(191, 23);
			this.buttonRestaurar.TabIndex = 5;
			this.buttonRestaurar.Text = "Restaurar a última copia";
			this.buttonRestaurar.UseVisualStyleBackColor = true;
			this.buttonRestaurar.Click += new System.EventHandler(this.buttonRestaurar_Click);
			// 
			// textBoxRestauracion
			// 
			this.textBoxRestauracion.Location = new System.Drawing.Point(31, 138);
			this.textBoxRestauracion.Name = "textBoxRestauracion";
			this.textBoxRestauracion.ReadOnly = true;
			this.textBoxRestauracion.Size = new System.Drawing.Size(100, 20);
			this.textBoxRestauracion.TabIndex = 6;
			// 
			// buttonBuscarRestaurar
			// 
			this.buttonBuscarRestaurar.Location = new System.Drawing.Point(147, 136);
			this.buttonBuscarRestaurar.Name = "buttonBuscarRestaurar";
			this.buttonBuscarRestaurar.Size = new System.Drawing.Size(75, 23);
			this.buttonBuscarRestaurar.TabIndex = 7;
			this.buttonBuscarRestaurar.Text = "Buscar";
			this.buttonBuscarRestaurar.UseVisualStyleBackColor = true;
			this.buttonBuscarRestaurar.Click += new System.EventHandler(this.buttonBuscarRestaurar_Click);
			// 
			// buttonRestaurarElegir
			// 
			this.buttonRestaurarElegir.Location = new System.Drawing.Point(31, 173);
			this.buttonRestaurarElegir.Name = "buttonRestaurarElegir";
			this.buttonRestaurarElegir.Size = new System.Drawing.Size(191, 23);
			this.buttonRestaurarElegir.TabIndex = 8;
			this.buttonRestaurarElegir.Text = "Restaurar";
			this.buttonRestaurarElegir.UseVisualStyleBackColor = true;
			this.buttonRestaurarElegir.Click += new System.EventHandler(this.buttonRestaurarElegir_Click);
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Location = new System.Drawing.Point(147, 38);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
			this.buttonBuscar.TabIndex = 10;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
			// 
			// textBoxBackup
			// 
			this.textBoxBackup.Location = new System.Drawing.Point(31, 40);
			this.textBoxBackup.Name = "textBoxBackup";
			this.textBoxBackup.ReadOnly = true;
			this.textBoxBackup.Size = new System.Drawing.Size(100, 20);
			this.textBoxBackup.TabIndex = 9;
			// 
			// BackupFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 286);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.textBoxBackup);
			this.Controls.Add(this.buttonRestaurarElegir);
			this.Controls.Add(this.buttonBuscarRestaurar);
			this.Controls.Add(this.textBoxRestauracion);
			this.Controls.Add(this.buttonRestaurar);
			this.Controls.Add(this.buttonBackup);
			this.Name = "BackupFrm";
			this.Text = "BackupFrm";
			this.Load += new System.EventHandler(this.BackupFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonBackup;
		private System.Windows.Forms.Button buttonRestaurar;
		private System.Windows.Forms.TextBox textBoxRestauracion;
		private System.Windows.Forms.Button buttonBuscarRestaurar;
		private System.Windows.Forms.Button buttonRestaurarElegir;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.TextBox textBoxBackup;
	}
}