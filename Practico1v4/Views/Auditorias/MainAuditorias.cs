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
using Z.EntityFramework.Plus;

namespace Practico1v4.Views.Auditorias
{
	public partial class MainAuditorias : Form
	{
		public MainAuditorias()
		{
			InitializeComponent();
		}

		private AuditEntry _auditEntrySelected;

		public AuditEntry auditEntrySelected {
			get { return _auditEntrySelected; }
			set { _auditEntrySelected = value; }
		}

		VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

		private void MainAuditorias_Load(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				dataGridView1.DataSource = context.AuditEntries.OrderByDescending(x => x.CreatedDate).ToList();
				comboBoxTablas.ValueMember = "AuditEntryID";
				comboBoxTablas.DisplayMember = "EntitySetName";
				comboBoxTablas.DataSource = context.AuditEntries.GroupBy(x => x.EntitySetName).Select(x => x.FirstOrDefault()).ToList();
			}
			dataGridView1.ClearSelection();
		}

		private void textBoxTabla_TextChanged(object sender, EventArgs e)
		{
			string filter = textBoxTabla.Text;
			dataGridView1.DataSource = contextGlobal.AuditEntries.Where(x => x.EntitySetName.Contains(filter)).ToList();
		}

		private void textBoxCreador_TextChanged(object sender, EventArgs e)
		{
			string filter = textBoxCreador.Text;
			dataGridView1.DataSource = contextGlobal.AuditEntries.Where(x => x.CreatedBy.Contains(filter)).ToList();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DateTime date = dateTimePicker1.Value;
				dataGridView1.DataSource = contextGlobal.AuditEntries.Where(x => DbFunctions.TruncateTime(x.CreatedDate) == DbFunctions.TruncateTime(date)).ToList();
			}
			catch (Exception ex)
			{
				Console.Write(ex);
				throw;
			}
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			switch (e.Value.ToString())
			{
				case "EntityModified":
					e.Value = "Modificado";
					break;
				case "EntityAdded":
					e.Value = "Insertado";
					break;
				case "EntityDeleted":
					e.Value = "Eliminado";
					break;
			}
		}


		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			auditEntrySelected = (AuditEntry)dataGridView1.SelectedRows[0].DataBoundItem;
			DetalleAuditoria form = new DetalleAuditoria();
			form.IdEntry = auditEntrySelected.AuditEntryID;
			form.StartPosition = FormStartPosition.CenterParent;
			form.ShowDialog(this);
		}

		private void buttonIrTabla_Click(object sender, EventArgs e)
		{
			TablaAuditoria frm = new TablaAuditoria();
			frm.entry = (AuditEntry)comboBoxTablas.SelectedItem;
			frm.ShowDialog(this);
		}
	}
}
