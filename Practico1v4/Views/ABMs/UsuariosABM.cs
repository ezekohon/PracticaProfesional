using Practico1v4.Helpers;
using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.ABMs
{
    public partial class UsuariosABM : Form
    {
        public UsuariosABM()
        {
            InitializeComponent();
        }
		VentasDBContext contextGlobal = new VentasDBContext();

		private void UsuariosABM_Load(object sender, EventArgs e)
		{
			actualizarGrilla();
		}

		private void actualizarGrilla()
		{
			using (var context = new VentasDBContext())
			{
				var query = from r in context.Roles
							join u in context.Usuarios on r.Id equals u.Rol.Id
							select new
							{
								Id = u.Id,
								Nombre = u.Username,
								Rol = u.Rol.Nombre,
							};
				this.dataGridView1.DataSource = query.ToList();
				toolStripStatusLabel1.Text = "Hay " + query.Count() + " registro(s) en la base de datos";
			}
		}

		private void textBoxBuscar_TextChanged(object sender, EventArgs e)
		{
			string filter = textBoxBuscar.Text;
			using (var context = new VentasDBContext())
			{
				var query = from r in context.Roles
							join u in context.Usuarios on r.Id equals u.Rol.Id
							where u.Username.Contains(filter)
							select new
							{
								Id = u.Id,
								Nombre = u.Username,
								Rol = u.Rol.Nombre,
							};
				this.dataGridView1.DataSource = query.ToList();
			}
		}

		private void toolStripButtonInsertar_Click(object sender, EventArgs e)
		{
			UsuariosEditor frm = new UsuariosEditor();
			frm.currentStatus = UsuariosEditor.status.insertar;
			frm.ShowDialog(this);
		}

		private void toolStripButtonEditar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				var row = dataGridView1.SelectedRows[0];
				UsuariosEditor frm = new UsuariosEditor();
				frm.cargarDatos(row);
				frm.currentStatus = UsuariosEditor.status.editar;
				frm.ShowDialog(this);
			}
			else
			{
				using (new CenterWinDialog(this))
				{
					MessageBox.Show("Seleccione una fila para editarla", "");
				}
			}
		}
	}
}
