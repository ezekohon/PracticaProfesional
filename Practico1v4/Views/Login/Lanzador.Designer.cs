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
			this.buttonIngresar = new System.Windows.Forms.Button();
			this.labelOlvidoPassword = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxTenant = new System.Windows.Forms.TextBox();
			this.buttonAccederEmpresa = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.nuevaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxUsuario
			// 
			this.textBoxUsuario.Enabled = false;
			this.textBoxUsuario.Location = new System.Drawing.Point(160, 181);
			this.textBoxUsuario.Name = "textBoxUsuario";
			this.textBoxUsuario.Size = new System.Drawing.Size(100, 20);
			this.textBoxUsuario.TabIndex = 0;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Enabled = false;
			this.textBoxPassword.Location = new System.Drawing.Point(160, 229);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
			this.textBoxPassword.TabIndex = 1;
			this.textBoxPassword.UseSystemPasswordChar = true;
			this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(65, 184);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Usuario";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Contraseña";
			// 
			// buttonIngresar
			// 
			this.buttonIngresar.Enabled = false;
			this.buttonIngresar.Location = new System.Drawing.Point(169, 268);
			this.buttonIngresar.Name = "buttonIngresar";
			this.buttonIngresar.Size = new System.Drawing.Size(75, 23);
			this.buttonIngresar.TabIndex = 4;
			this.buttonIngresar.Text = "Ingresar";
			this.buttonIngresar.UseVisualStyleBackColor = true;
			this.buttonIngresar.Click += new System.EventHandler(this.button1_Click);
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
			this.label3.Location = new System.Drawing.Point(65, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "EMPRESA";
			// 
			// textBoxTenant
			// 
			this.textBoxTenant.Location = new System.Drawing.Point(160, 56);
			this.textBoxTenant.Name = "textBoxTenant";
			this.textBoxTenant.Size = new System.Drawing.Size(100, 20);
			this.textBoxTenant.TabIndex = 7;
			// 
			// buttonAccederEmpresa
			// 
			this.buttonAccederEmpresa.Location = new System.Drawing.Point(156, 98);
			this.buttonAccederEmpresa.Name = "buttonAccederEmpresa";
			this.buttonAccederEmpresa.Size = new System.Drawing.Size(104, 23);
			this.buttonAccederEmpresa.TabIndex = 8;
			this.buttonAccederEmpresa.Text = "Acceder Empresa";
			this.buttonAccederEmpresa.UseVisualStyleBackColor = true;
			this.buttonAccederEmpresa.Click += new System.EventHandler(this.buttonAccederEmpresa_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaEmpresaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(396, 24);
			this.menuStrip1.TabIndex = 9;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// nuevaEmpresaToolStripMenuItem
			// 
			this.nuevaEmpresaToolStripMenuItem.Name = "nuevaEmpresaToolStripMenuItem";
			this.nuevaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.nuevaEmpresaToolStripMenuItem.Text = "Nueva Empresa";
			this.nuevaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.nuevaEmpresaToolStripMenuItem_Click);
			// 
			// Lanzador
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 329);
			this.Controls.Add(this.buttonAccederEmpresa);
			this.Controls.Add(this.textBoxTenant);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labelOlvidoPassword);
			this.Controls.Add(this.buttonIngresar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsuario);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Lanzador";
			this.Text = "Ingreso al sistema";
			this.Load += new System.EventHandler(this.Lanzador_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonIngresar;
		private System.Windows.Forms.LinkLabel labelOlvidoPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxTenant;
		private System.Windows.Forms.Button buttonAccederEmpresa;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem nuevaEmpresaToolStripMenuItem;
	}
}

