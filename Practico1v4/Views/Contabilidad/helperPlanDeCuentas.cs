using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Contabilidad
{
	public partial class helperPlanDeCuentas : Form
	{
		public helperPlanDeCuentas()
		{
			InitializeComponent();
		}

		public BindingList<Cuenta> listaCuentas { get; set; }

		public Cuenta cuentaSeleccionada { get; set; }

		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			var row = dataGridView1.SelectedRows[0];
			Cuenta c = (Cuenta)row.DataBoundItem;
			
			if (c.Tipo == 1)
			{
				cuentaSeleccionada = c;
				DialogResult = DialogResult.OK;
			}
			else
				Helpers.CreadorMensajes.mensajeObservacion("Seleccione una cuenta imputable");
		}

		private void helperPlanDeCuentas_Load(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Cuentas.OrderBy(x => x.CodigoBalance).Load();
				dataGridView1.DataSource = context.Cuentas.Local;
			}
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if ((int)row.Cells["Tipo"].Value == 0)
				{
					row.DefaultCellStyle.BackColor = Color.Yellow;
				}

				//string codbalance = (string)row.Cells["CodigoBalance"].Value;
				//int puntos = codbalance.Count(x => x == '.');
			}
		}
	}
}
