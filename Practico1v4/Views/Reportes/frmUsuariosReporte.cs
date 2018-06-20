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
	public partial class frmUsuariosReporte : Form
	{
		public frmUsuariosReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{
			UsuariosReporte rpt = new UsuariosReporte();
			
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Usuarios.Load();
				context.Roles.Load();
				rpt.Database.Tables[0].SetDataSource(context.Usuarios.Local);
				rpt.Database.Tables[1].SetDataSource(context.Roles.Local);
			}
			crystalReportViewer1.ReportSource = rpt;
			//crystalReportViewer1.AllowedExportFormats = CrystalDecisions.Shared.ViewerExportFormats.
		}
	}
}
