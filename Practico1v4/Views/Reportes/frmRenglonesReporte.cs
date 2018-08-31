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
	public partial class frmRenglonesReporte : Form
	{
		public frmRenglonesReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		public int NAsientoDesde { get; set; }
		public int NAsientoHasta { get; set; }
		public DateTime FechaDesde { get; set; }
		public DateTime FechaHasta { get; set; }


		private void frmRenglonesReporte_Load(object sender, EventArgs e)
		{
			Practico1v4.Reportes.RenglonesReporte rpt = new Practico1v4.Reportes.RenglonesReporte();

			TextObject desde = (TextObject)rpt.ReportDefinition.ReportObjects["labelNAsientoDesde"];
			desde.Text = NAsientoDesde.ToString();
			TextObject hasta = (TextObject)rpt.ReportDefinition.ReportObjects["labelNAsientoHasta"];
			hasta.Text = NAsientoHasta.ToString();




			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Renglones.Load();
				context.Cuentas.Load();
				rpt.Database.Tables[0].SetDataSource(context.Renglones.Local.Where(x => 
					x.NumeroAsiento >= NAsientoDesde && 
					x.NumeroAsiento <= NAsientoHasta &&
					x.FechaContabilidad >= FechaDesde &&
					x.FechaContabilidad <= FechaHasta));
				rpt.Database.Tables[1].SetDataSource(context.Cuentas.Local);
				
			}
			crystalReportViewer1.ReportSource = rpt;
		}
	}
}
