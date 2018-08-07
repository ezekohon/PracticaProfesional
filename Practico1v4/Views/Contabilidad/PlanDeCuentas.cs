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

namespace Practico1v4.Views.Contabilidad
{
	public partial class PlanDeCuentas : Form
	{
		public PlanDeCuentas()
		{
			InitializeComponent();
		}

		private void PlanDeCuentas_Load(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Cuentas.OrderBy(x => x.CodigoBalance).Load();
				//var cuentasPadres = context.Cuentas.Where(c=> c.IdPadre == null);
				//TreeNode parentNode = new TreeNode();
				this.dataGridView1.DataSource = context.Cuentas.Local.ToBindingList();
				

			}
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach(DataGridViewRow row in dataGridView1.Rows)
			{
				if ((int)row.Cells["Tipo"].Value == 0)
				{
					row.DefaultCellStyle.BackColor = Color.Yellow;
				}
				
				//string codbalance = (string)row.Cells["CodigoBalance"].Value;
				//int puntos = codbalance.Count(x => x == '.');
			}


		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				string cod = (string)row.Cells["CodigoBalance"].Value;//(string)dataGridView1.Rows[e.RowIndex].Cells["CodigoBalance"].Value;
				int puntos = cod.Count(x => x == '.');
				for (int i = 0; i < puntos; i++)
				{
					row.Cells["Nombre"].Value = "  " + (string)row.Cells["Nombre"].Value;
				}
			}

		}

		private void buttonReporte_Click(object sender, EventArgs e)
		{
			Reportes.frmPlanDeCuentasReporte rpt = new Reportes.frmPlanDeCuentasReporte();
			rpt.ShowDialog(this);
		}

		private void toolStripButtonReporte_Click(object sender, EventArgs e)
		{
			Reportes.frmPlanDeCuentasReporte rpt = new Reportes.frmPlanDeCuentasReporte();
			rpt.ShowDialog(this);
		}

		private void toolStripButtonInsertar_Click(object sender, EventArgs e)
		{

		}

		private void toolStripButtonBorrar_Click(object sender, EventArgs e)
		{

		}
	}
}
