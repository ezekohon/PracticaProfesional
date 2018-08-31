using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
	}
}
