namespace Practico1v4.Views.Login
{
	partial class NuevaEmpresa
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.buttonCrear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Location = new System.Drawing.Point(132, 58);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
			this.textBoxNombre.TabIndex = 1;
			// 
			// buttonCrear
			// 
			this.buttonCrear.Location = new System.Drawing.Point(144, 200);
			this.buttonCrear.Name = "buttonCrear";
			this.buttonCrear.Size = new System.Drawing.Size(75, 23);
			this.buttonCrear.TabIndex = 2;
			this.buttonCrear.Text = "Crear";
			this.buttonCrear.UseVisualStyleBackColor = true;
			this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
			// 
			// NuevaEmpresa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 276);
			this.Controls.Add(this.buttonCrear);
			this.Controls.Add(this.textBoxNombre);
			this.Controls.Add(this.label1);
			this.Name = "NuevaEmpresa";
			this.Text = "NuevaEmpresa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Button buttonCrear;
	}
}