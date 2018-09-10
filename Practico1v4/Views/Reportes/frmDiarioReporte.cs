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

		private void frmDiarioReporte_FormClosing(object sender, FormClosingEventArgs e)
		{
			Helpers.MessageBoxManager.Cancel = "Cancelar";
			DialogResult r = MessageBox.Show("Ha impreso el libro diario sin errores?", "Confirmación", MessageBoxButtons.OKCancel);
			//DialogResult r = Helpers.CreadorMensajes.mensajeConfirmacion();
			if (r != DialogResult.Cancel)
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					UltimoDiario u = new UltimoDiario();
					u.UltimaFechaImpresion = FechaHasta;//DateTime.Now;
					u.UltimoNumeroAsiento = Common.TenantData.tenant.UltimoNroAsientoCargando;
					
					u.Id = context.UltimoDiario.FirstOrDefault().Id;
					var entry = context.UltimoDiario.Find(u.Id);
					context.Entry(entry).CurrentValues.SetValues(u);
					try
					{
						context.SaveChanges();
						DialogResult = DialogResult.OK;
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
				using (var context = new TenantsDBContext())
				{
					var entity = context.Tenants.Find(Common.TenantData.tenant.Id);
					//var t = new Tenant();
					Tenant t = context.Tenants.SingleOrDefault(x => x.Id == Common.TenantData.tenant.Id);
					t.FechaImpresionUltimoDiario = FechaHasta;
					context.Entry(entity).CurrentValues.SetValues(t);
					context.SaveChanges();
				}
			}
		}
	}
	
}
