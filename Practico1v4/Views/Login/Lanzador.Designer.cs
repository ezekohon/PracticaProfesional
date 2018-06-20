namespace Practico1v4
{
    partial class Lanzador
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
			this.textBoxUsuario = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelOlvidoPassword = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxTenant = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Location = new System.Drawing.Point(160, 157);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
			this.textBoxUsuario.TabIndex = 0;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(160, 205);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.UseSystemPasswordChar = true;
			this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(169, 268);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Ingresar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// labelOlvidoPassword
			// 
			this.labelOlvidoPassword.AutoSize = true;
			this.labelOlvidoPassword.Location = new System.Drawing.Point(147, 307);
			this.labelOlvidoPassword.Name = "labelOlvidoPassword";
			this.labelOlvidoPassword.Size = new System.Drawing.Size(113, 13);
			this.labelOlvidoPassword.TabIndex = 5;
			this.labelOlvidoPassword.TabStop = true;
			this.labelOlvidoPassword.Text = "Olvidó su contraseña?";
			this.labelOlvidoPassword.Visible = false;
			this.labelOlvidoPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelOlvidoPassword_LinkClicked);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "EMPRESA";
			// 
			// textBoxTenant
			// 
			this.textBoxTenant.Location = new System.Drawing.Point(160, 43);
			this.textBoxTenant.Name = "textBoxTenant";
			this.textBoxTenant.Size = new System.Drawing.Size(100, 20);
			this.textBoxTenant.TabIndex = 7;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(286, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 8;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(305, 92);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 10;
			this.button4.Text = "Nueva";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Lanzador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 329);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBoxTenant);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelOlvidoPassword);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsuario);
			this.Name = "Lanzador";
			this.Text = "Ingreso al sistema";
			this.Load += new System.EventHandler(this.Lanzador_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel labelOlvidoPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxTenant;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
	}
}

