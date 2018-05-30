namespace Practico1v4.Views.ABMs
{
    partial class UsuariosABM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosABM));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxBuscar = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonInsertar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEditar = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBorrar = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonReporte = new System.Windows.Forms.ToolStripButton();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.rolDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.usuarioBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 105);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(491, 194);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 302);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(515, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Buscar por usuario :";
			// 
			// textBoxBuscar
			// 
			this.textBoxBuscar.Location = new System.Drawing.Point(114, 66);
			this.textBoxBuscar.Name = "textBoxBuscar";
			this.textBoxBuscar.Size = new System.Drawing.Size(100, 20);
			this.textBoxBuscar.TabIndex = 3;
			this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInsertar,
            this.toolStripButtonEditar,
            this.toolStripButtonBorrar,
            this.toolStripSeparator1,
            this.toolStripButtonReporte});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(515, 50);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButtonInsertar
			// 
			this.toolStripButtonInsertar.AutoSize = false;
			this.toolStripButtonInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonInsertar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertar.Image")));
			this.toolStripButtonInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonInsertar.Name = "toolStripButtonInsertar";
			this.toolStripButtonInsertar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonInsertar.Text = "toolStripButton1";
			this.toolStripButtonInsertar.Click += new System.EventHandler(this.toolStripButtonInsertar_Click);
			// 
			// toolStripButtonEditar
			// 
			this.toolStripButtonEditar.AutoSize = false;
			this.toolStripButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEditar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditar.Image")));
			this.toolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonEditar.Name = "toolStripButtonEditar";
			this.toolStripButtonEditar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonEditar.Text = "toolStripButton2";
			this.toolStripButtonEditar.Click += new System.EventHandler(this.toolStripButtonEditar_Click);
			// 
			// toolStripButtonBorrar
			// 
			this.toolStripButtonBorrar.AutoSize = false;
			this.toolStripButtonBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBorrar.Image")));
			this.toolStripButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonBorrar.Name = "toolStripButtonBorrar";
			this.toolStripButtonBorrar.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonBorrar.Text = "toolStripButton3";
			this.toolStripButtonBorrar.Click += new System.EventHandler(this.toolStripButtonBorrar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
			// 
			// toolStripButtonReporte
			// 
			this.toolStripButtonReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonReporte.AutoSize = false;
			this.toolStripButtonReporte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonReporte.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReporte.Image")));
			this.toolStripButtonReporte.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonReporte.Name = "toolStripButtonReporte";
			this.toolStripButtonReporte.Size = new System.Drawing.Size(47, 47);
			this.toolStripButtonReporte.Text = "toolStripButton4";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// rolDataGridViewTextBoxColumn
			// 
			this.rolDataGridViewTextBoxColumn.DataPropertyName = "Rol";
			this.rolDataGridViewTextBoxColumn.HeaderText = "Rol";
			this.rolDataGridViewTextBoxColumn.Name = "rolDataGridViewTextBoxColumn";
			this.rolDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// usuarioBindingSource
			// 
			this.usuarioBindingSource.DataSource = typeof(Practico1v4.Models.Usuario);
			// 
			// UsuariosABM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 324);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.textBoxBuscar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UsuariosABM";
			this.Text = "UsuariosABM";
			this.Load += new System.EventHandler(this.UsuariosABM_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBorrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReporte;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rolDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource usuarioBindingSource;
	}
}