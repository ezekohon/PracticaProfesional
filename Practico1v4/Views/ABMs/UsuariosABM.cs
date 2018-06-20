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
		VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

		private void UsuariosABM_Load(object sender, EventArgs e)
		{
			actualizarGrilla();
			dataGridView1.ClearSelection();
		}

		private Usuario _usuarioSelected;

		public Usuario usuarioSelected {
			get { return _usuarioSelected; }
			set { _usuarioSelected = value; }
		}

		private void actualizarGrilla()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Usuarios.Include(r => r.Rol).Load();
				
				this.dataGridView1.DataSource = context.Usuarios.Local.ToBindingList();
				toolStripStatusLabel1.Text = context.Usuarios.Local.Count() + " registro(s) en la base de datos";
			}
		}

		private void textBoxBuscar_TextChanged(object sender, EventArgs e)
		{
			string filter = textBoxBuscar.Text;
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				dataGridView1.DataSource = contextGlobal.Usuarios.Where(x => x.Username.Contains(filter)).ToList();
				//var query = from r in context.Roles
				//			join u in context.Usuarios on r.Id equals u.Rol.Id
				//			where u.Username.Contains(filter)
				//			select new
				//			{
				//				Id = u.Id,
				//				Nombre = u.Username,
				//				Rol = u.Rol.Nombre,
				//			};
				//this.dataGridView1.DataSource = query.ToList();
				//dataGridView1.Columns[3].Visible = false;

			}
		}

		private void toolStripButtonInsertar_Click(object sender, EventArgs e)
		{
			UsuariosEditor frm = new UsuariosEditor();
			frm.currentStatus = UsuariosEditor.status.insertar;
			if (frm.ShowDialog(this) == DialogResult.OK)
				actualizarGrilla();
		}

		private void toolStripButtonEditar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				var row = dataGridView1.SelectedRows[0];
				var u = getUsuarioFromRow(row);
				UsuariosEditor frm = new UsuariosEditor();
				//frm.cargarDatos(u);
				frm.usuario = u;
				frm.currentStatus = UsuariosEditor.status.editar;
				frm.ShowDialog(this);
				actualizarGrilla();
			}
			else
			{
				Helpers.CreadorMensajes.mensajeObservacion("Seleccione una fila para editarla");
			}
		}

		private Usuario getUsuarioFromRow(DataGridViewRow row)
		{
			return (Usuario)row.DataBoundItem;
		}

		private void toolStripButtonBorrar_Click(object sender, EventArgs e)
		{
			eliminar();
		}

		private void eliminar()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				DialogResult r = Helpers.CreadorMensajes.mensajeEliminar("el Usuario");
				if (r != DialogResult.Cancel)
				{
					//attach porque la entity no fue cargada en el mismo context
					context.Usuarios.Attach(usuarioSelected);

					context.Usuarios.Remove(usuarioSelected);
					context.SaveChanges();
					actualizarGrilla();
				}
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			usuarioSelected = (Usuario)dataGridView1.SelectedRows[0].DataBoundItem;
		}

		private void toolStripButtonReporte_Click(object sender, EventArgs e)
		{
			Reportes.frmUsuariosReporte rpt = new Reportes.frmUsuariosReporte();
			rpt.ShowDialog(this);
		}
	}
}
