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
	public partial class frmDiarioReporte : Form
	{
		public frmDiarioReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		public DateTime FechaHasta { get; set; }

		private void frmDiarioReporte_Load(object sender, EventArgs e)
		{
			Practico1v4.Reportes.DiarioReporte rpt = new Practico1v4.Reportes.DiarioReporte();

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.DiarioMayor.Load();
				context.Cuentas.Load();

				rpt.Database.Tables[1].SetDataSource(context.DiarioMayor.Local);
					//.OrderBy(x => x.FechaContabilidad)
					//.OrderBy(x => x.Tipo)
					//.OrderBy(x => x.NumeroAsiento)
					//.OrderBy(x => x.Debe));//.Where(x =>);
				rpt.Database.Tables[0].SetDataSource(context.Cuentas.Local);

				rpt.SetParameterValue("FechaDesde", Common.TenantData.tenant.FechaImpresionUltimoDiario.AddDays(1));
				rpt.SetParameterValue("FechaHasta", FechaHasta);
				rpt.SetParameterValue("FechaCierreEjercicio", Common.TenantData.tenant.FechaCierreEjercicioContable);
			}
			crystalReportViewer1.ReportSource = rpt;
		}

	}
	
}
