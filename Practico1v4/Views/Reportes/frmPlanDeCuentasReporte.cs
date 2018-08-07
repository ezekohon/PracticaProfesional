using Practico1v4.Models;
using Practico1v4.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Reportes
{
	public partial class frmPlanDeCuentasReporte : Form
	{
		public frmPlanDeCuentasReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			PlanDeCuentasReporte rpt = new PlanDeCuentasReporte();
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Cuentas.Load();
				rpt.SetDataSource(context.Cuentas.Local);
			}
			crystalReportViewer1.ReportSource = rpt;
			
		}
	}
}
