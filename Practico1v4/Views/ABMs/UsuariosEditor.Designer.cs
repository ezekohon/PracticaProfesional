namespace Practico1v4.Views.ABMs
{
	partial class UsuariosEditor
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
			this.buttonConfirmar = new System.Windows.Forms.Button();
			this.buttonCancelar = new System.Windows.Forms.Button();
			this.buttonLimpiar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderRol = new System.Windows.Forms.ErrorProvider(this.components);
			this.comboBoxRol = new System.Windows.Forms.ComboBox();
			this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
			this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonConfirmar
			// 
			this.buttonConfirmar.Location = new System.Drawing.Point(312, 252);
			this.buttonConfirmar.Name = "buttonConfirmar";
			this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
			this.buttonConfirmar.TabIndex = 0;
			this.buttonConfirmar.Text = "Guardar";
			this.buttonConfirmar.UseVisualStyleBackColor = true;
			this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
			// 
			// buttonCancelar
			// 
			this.buttonCancelar.Location = new System.Drawing.Point(413, 252);
			this.buttonCancelar.Name = "buttonCancelar";
			this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
			this.buttonCancelar.TabIndex = 1;
			this.buttonCancelar.Text = "Cancelar";
			this.buttonCancelar.UseVisualStyleBackColor = true;
			this.buttonCancelar.Visible = false;
			// 
			// buttonLimpiar
			// 
			this.buttonLimpiar.Location = new System.Drawing.Point(399, 21);
			this.buttonLimpiar.Name = "buttonLimpiar";
			this.buttonLimpiar.Size = new System.Drawing.Size(89, 23);
			this.buttonLimpiar.TabIndex = 2;
			this.buttonLimpiar.Text = "Limpiar Campos";
			this.buttonLimpiar.UseVisualStyleBackColor = true;
			this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Usuario";
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Location = new System.Drawing.Point(124, 69);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
			this.textBoxUsuario.TabIndex = 4;
			this.textBoxUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsuario_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Rol";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 276);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(500, 22);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(124, 106);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
			this.textBoxPassword.TabIndex = 9;
			this.textBoxPassword.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(34, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Contraseña";
			// 
			// errorProviderUsuario
			// 
			this.errorProviderUsuario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProviderUsuario.ContainerControl = this;
			// 
			// errorProviderRol
			// 
			this.errorProviderRol.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProviderRol.ContainerControl = this;
			// 
			// comboBoxRol
			// 
			this.comboBoxRol.FormattingEnabled = true;
			this.comboBoxRol.Location = new System.Drawing.Point(124, 142);
			this.comboBoxRol.Name = "comboBoxRol";
			this.comboBoxRol.Size = new System.Drawing.Size(100, 21);
			this.comboBoxRol.TabIndex = 10;
			// 
			// checkBoxShowPassword
			// 
			this.checkBoxShowPassword.AutoSize = true;
			this.checkBoxShowPassword.Location = new System.Drawing.Point(241, 108);
			this.checkBoxShowPassword.Name = "checkBoxShowPassword";
			this.checkBoxShowPassword.Size = new System.Drawing.Size(15, 14);
			this.checkBoxShowPassword.TabIndex = 11;
			this.checkBoxShowPassword.UseVisualStyleBackColor = true;
			this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
			// 
			// errorProviderPassword
			// 
			this.errorProviderPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProviderPassword.ContainerControl = this;
			// 
			// UsuariosEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 298);
			this.Controls.Add(this.checkBoxShowPassword);
			this.Controls.Add(this.comboBoxRol);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonLimpiar);
			this.Controls.Add(this.buttonCancelar);
			this.Controls.Add(this.buttonConfirmar);
			this.Name = "UsuariosEditor";
			this.Text = "UsuariosEditor";
			this.Load += new System.EventHandler(this.UsuariosEditor_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderRol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonConfirmar;
		private System.Windows.Forms.Button buttonCancelar;
		private System.Windows.Forms.Button buttonLimpiar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider errorProviderUsuario;
		private System.Windows.Forms.ErrorProvider errorProviderRol;
		private System.Windows.Forms.ComboBox comboBoxRol;
		private System.Windows.Forms.CheckBox checkBoxShowPassword;
		private System.Windows.Forms.ErrorProvider errorProviderPassword;
	}
}