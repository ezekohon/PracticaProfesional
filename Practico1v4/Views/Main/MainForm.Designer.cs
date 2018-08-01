namespace Practico1v4.Views.Main
{
    partial class MainForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.aBMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.puntoDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.auditoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMsToolStripMenuItem,
            this.auditoríasToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem,
            this.copiaDeSeguridadToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// aBMsToolStripMenuItem
			// 
			this.aBMsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntoDeVentasToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.usuariosToolStripMenuItem});
			this.aBMsToolStripMenuItem.Name = "aBMsToolStripMenuItem";
			this.aBMsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.aBMsToolStripMenuItem.Text = "ABMs";
			// 
			// puntoDeVentasToolStripMenuItem
			// 
			this.puntoDeVentasToolStripMenuItem.Name = "puntoDeVentasToolStripMenuItem";
			this.puntoDeVentasToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.puntoDeVentasToolStripMenuItem.Text = "Punto de Ventas";
			this.puntoDeVentasToolStripMenuItem.Click += new System.EventHandler(this.puntoDeVentasToolStripMenuItem_Click);
			// 
			// vendedoresToolStripMenuItem
			// 
			this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
			this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.vendedoresToolStripMenuItem.Text = "Vendedores";
			this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
			this.usuariosToolStripMenuItem.Text = "Usuarios";
			this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
			// 
			// auditoríasToolStripMenuItem
			// 
			this.auditoríasToolStripMenuItem.Name = "auditoríasToolStripMenuItem";
			this.auditoríasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.auditoríasToolStripMenuItem.Text = "Auditorías";
			this.auditoríasToolStripMenuItem.Click += new System.EventHandler(this.auditoríasToolStripMenuItem_Click);
			// 
			// cerrarSesiónToolStripMenuItem
			// 
			this.cerrarSesiónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
			this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
			this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
			// 
			// copiaDeSeguridadToolStripMenuItem
			// 
			this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
			this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
			this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad";
			this.copiaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.copiaDeSeguridadToolStripMenuItem_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEmpresa,
            this.toolStripStatusLabelUsuario});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(800, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelEmpresa
			// 
			this.toolStripStatusLabelEmpresa.Name = "toolStripStatusLabelEmpresa";
			this.toolStripStatusLabelEmpresa.Size = new System.Drawing.Size(55, 17);
			this.toolStripStatusLabelEmpresa.Text = "dsadsads";
			// 
			// toolStripStatusLabelUsuario
			// 
			this.toolStripStatusLabelUsuario.Name = "toolStripStatusLabelUsuario";
			this.toolStripStatusLabelUsuario.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabelUsuario.Text = "toolStripStatusLabel1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntoDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem auditoríasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEmpresa;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUsuario;
	}
}