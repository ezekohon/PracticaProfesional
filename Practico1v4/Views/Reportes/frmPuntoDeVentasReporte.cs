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
using Practico1v4.Models;
using Practico1v4.Reportes;

namespace Practico1v4.Views.Reportes
{
    public partial class frmPuntoDeVentasReporte : Form
    {
        public frmPuntoDeVentasReporte()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            PuntoDeVentasReporte rpt = new PuntoDeVentasReporte();
            using (var context = new VentasDBContext())
            {
                context.PuntosDeVenta.Load();
                rpt.SetDataSource(context.PuntosDeVenta.Local);
            }
            crystalReportViewer1.ReportSource = rpt;
            
       
        }

    }
}
