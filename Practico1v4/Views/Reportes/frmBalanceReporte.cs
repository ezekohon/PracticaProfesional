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
	public partial class frmBalanceReporte : Form
	{
		public frmBalanceReporte()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		public DateTime FechaDesde { get; set; }
		public DateTime FechaHasta { get; set; }

		private void frmBalanceReporte_Load(object sender, EventArgs e)
		{
			

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Database.ExecuteSqlCommand("TRUNCATE TABLE [tempBalances]");
			}

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				//Multiple Active Result Sets (MARS) activo para poder loopear doble, feature malo, puede traer problemas
				
				context.Cuentas.Load();
				context.DiarioMayor.Include(r => r.Cuenta).Load(); //esta loadeando las cuentas??
				decimal debitos;
				decimal creditos;
				decimal sInicial;
				foreach (Cuenta c in context.Cuentas)
				{
					debitos = 0;
					creditos = 0;
					sInicial = 0;
					foreach (DiarioMayor renglon in context.DiarioMayor)
					{
						if (renglon.Cuenta.CodigoBalance.StartsWith(c.CodigoBalance)) //si es hijo
						{
							if (FechaDesde == Common.TenantData.tenant.FechaInicioEjercicioContable)
							{
								if(renglon.Tipo == enumTipo.Apertura)
								{
									sInicial = sInicial + renglon.Debe - renglon.Haber;
								}
								debitos += renglon.Debe;
								creditos += renglon.Haber;
							}
							else
							{
								if (renglon.FechaContabilidad < FechaDesde)
								{
									sInicial = sInicial + renglon.Debe - renglon.Haber;
								}
								else
								{
									debitos += renglon.Debe;
									creditos += renglon.Haber;
								}
							}
						}
					}
					tempBalance cBalance = new tempBalance();
					cBalance.CodigoBalance = c.CodigoBalance;
					cBalance.CodigoPadre = c.CodigoPadre;
					cBalance.Debitos = debitos;
					cBalance.Creditos = creditos;
					cBalance.Nombre = c.Nombre;
					cBalance.Tipo = c.Tipo;
					cBalance.SaldoAcumulado = debitos - creditos;
					cBalance.SaldoInicial = sInicial;
					cBalance.SaldoCierre = cBalance.SaldoInicial + cBalance.SaldoAcumulado;

					context.tempBalance.Add(cBalance);
				}

				context.SaveChanges();


			}

			Practico1v4.Reportes.BalanceReporte rpt = new Practico1v4.Reportes.BalanceReporte();

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.tempBalance.Load();

				rpt.Database.Tables[0].SetDataSource(context.tempBalance.Local.OrderBy(x => x.CodigoBalance));

				rpt.SetParameterValue("FechaDesde", FechaDesde);
				rpt.SetParameterValue("FechaHasta", FechaHasta);


			}


			crystalReportViewer1.ReportSource = rpt;
		}
	}
}
