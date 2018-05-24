namespace Practico1v4.Views.ABMs
{
	partial class BaseEditor
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
			this.buttonConfirmar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonConfirmar
			// 
			this.buttonConfirmar.Location = new System.Drawing.Point(311, 263);
			this.buttonConfirmar.Name = "buttonConfirmar";
			this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirmar.TabIndex = 0;
			this.buttonConfirmar.Text = "Confirmar";
			this.buttonConfirmar.UseVisualStyleBackColor = true;
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(413, 263);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 1;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Location = new System.Drawing.Point(413, 21);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
			this.buttonLimpiar.TabIndex = 2;
			this.buttonLimpiar.Text = "Limpiar Campos";
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(124, 69);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 4;
			// 
			// BaseEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 298);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonConfirmar);
			this.Name = "BaseEditor";
			this.Text = "BaseEditor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}