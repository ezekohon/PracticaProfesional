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
    public partial class frmVendedoresReporte : Form
    {
        public frmVendedoresReporte()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            VendedoresReporte rpt = new VendedoresReporte();
            using (var context = new VentasDBContext())
            {
                context.PuntosDeVenta.Load();
                context.Vendedores.Load();
				context.Zonas.Load();
                rpt.Database.Tables[0].SetDataSource(context.Vendedores.Local);
                rpt.Database.Tables[1].SetDataSource(context.PuntosDeVenta.Local);
				rpt.Database.Tables[2].SetDataSource(context.Zonas.Local);
            }
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
