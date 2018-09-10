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
	public partial class ReportesContabilidad : Form
	{
		public ReportesContabilidad()
		{
			InitializeComponent();
		}

		private void buttonGenerarMayor_Click(object sender, EventArgs e)
		{
			Reportes.frmMayorReporte frm = new Reportes.frmMayorReporte();
			//frm.NCuentaDesde = Convert.ToInt32(textBoxCuentaDesde.Text);
			//frm.NCuentaHasta = Convert.ToInt32(textBoxCuentaHasta.Text);
			frm.FechaDesde = dateTimePickerDesde.Value;
			frm.FechaHasta = dateTimePickerHasta.Value;

			frm.ShowDialog(this);
		}

		private void buttonGenerarDiario_Click(object sender, EventArgs e)
		{
			Reportes.frmDiarioReporte frm = new Reportes.frmDiarioReporte();

			frm.FechaHasta = dateTimePickerHasta.Value;
			frm.ShowDialog(this);
			cargarGrilla();
		}

		private void buttonGenerarBalance_Click(object sender, EventArgs e)
		{
			Reportes.frmBalanceReporte frm = new Reportes.frmBalanceReporte();

			frm.FechaDesde = dateTimePickerDesde.Value;
			frm.FechaHasta = dateTimePickerHasta.Value;
			frm.ShowDialog(this);
		}

		private void ReportesContabilidad_Load(object sender, EventArgs e)
		{
			cargarGrilla();
		}

		private void cargarGrilla()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.UltimoDiario.Load();
				dataGridView1.DataSource = context.UltimoDiario.Local;
			}
		}
	}
}
