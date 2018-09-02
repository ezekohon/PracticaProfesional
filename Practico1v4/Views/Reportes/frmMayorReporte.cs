using CrystalDecisions.CrystalReports.Engine;
using Practico1v4.Models;
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
	public partial class frmMayorReporte : Form
	{
		public frmMayorReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		public int NCuentaDesde { get; set; }
		public int NCuentaHasta { get; set; }
		public DateTime FechaDesde { get; set; }
		public DateTime FechaHasta { get; set; }

		private void frmMayorReporte_Load(object sender, EventArgs e)
		{
			Practico1v4.Reportes.MayorReporte rpt = new Practico1v4.Reportes.MayorReporte();

			//TextObject desde = (TextObject)rpt.ReportDefinition.ReportObjects["TextDesde"];
			//desde.Text = FechaDesde.ToString();
			//TextObject hasta = (TextObject)rpt.ReportDefinition.ReportObjects["TextHasta"];
			//hasta.Text = FechaHasta.ToString();


	


			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.DiarioMayor.Load();
				context.Cuentas.Load();
				//


				//

				rpt.Database.Tables[0].SetDataSource(context.DiarioMayor.Local);
					//x.IdCuenta >= NCuentaDesde &&
					//x.IdCuenta <= NCuentaHasta &&
					//x.FechaContabilidad >= FechaDesde &&
					//x.FechaContabilidad <= FechaHasta));
				rpt.Database.Tables[1].SetDataSource(context.Cuentas.Local);
				

				rpt.SetParameterValue("FechaDesde", FechaDesde);
				rpt.SetParameterValue("FechaHasta", FechaHasta);
				rpt.SetParameterValue("FechaInicioEjercicio", Common.TenantData.tenant.FechaInicioEjercicioContable);


			}
			crystalReportViewer1.ReportSource = rpt;
		}
	}
}
