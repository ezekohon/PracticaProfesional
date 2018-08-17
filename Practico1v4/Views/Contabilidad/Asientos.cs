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

namespace Practico1v4.Views.Contabilidad
{
	public partial class Asientos : Form
	{
		public Asientos()
		{
			System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
			CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			InitializeComponent();
		}

		//public enum enumTipo
		//{
		//	Apertura = 0,
		//	Normal = 1,
		//	Cierre = 2
		//}

		public int NroAsientoCargando { get; set; }

		public int NroRenglonActual { get; set; }

		private void Asientos_Load(object sender, EventArgs e)
		{
			comboBoxTipo.DataSource = Enum.GetValues(typeof(Renglon.enumTipo));
		}

		VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

		private void cargarGrilla()
		{
			//llenar la grilla con los renglones del asiento siendo cargado

		}

		private void altaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			panel1.Enabled = true;
			panel2.Enabled = true;

			var ultRenglon = contextGlobal.Renglones
										.OrderByDescending(x => x.Id)
										.FirstOrDefault();
			textBoxNAsiento.Text = (ultRenglon != null) ? (ultRenglon.NumeroAsiento + 1).ToString() : "1";
			textBoxNRenglon.Text = "1"; //?

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando).Load();
			}

		}

	

		private void textBoxCuentaID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
			{
				int id = (textBoxCuentaID.Text != "") ? Convert.ToInt32(textBoxCuentaID.Text) : 0;
				if (id != 0)
				{
					using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
					{
						Cuenta c = context.Cuentas.Where(x => x.Id == id).FirstOrDefault();
						if (c != null && c.Tipo == 1)
						{
							textBoxCuentaID.Text = c.Id.ToString();
							textBoxCuenta.Text = c.Nombre;
						}
						else
						{
							context.Cuentas.Load();
							using (helperPlanDeCuentas frm = new helperPlanDeCuentas())
							{
								
								frm.listaCuentas = context.Cuentas.Local.ToBindingList();
								DialogResult dr = frm.ShowDialog();
								if (dr == DialogResult.OK)
								{
									textBoxCuentaID.Text = frm.cuentaSeleccionada.CodigoBalance;
									textBoxCuenta.Text = frm.cuentaSeleccionada.Nombre;
									textBoxCuentaID.Enabled = false;
								}
							}
						}

					}
				}

			}
			else if (e.KeyCode.ToString() == "F1")
			{
				//abrir grid
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					context.Cuentas.Load();
					using (helperPlanDeCuentas frm = new helperPlanDeCuentas())
					{
						frm.listaCuentas = context.Cuentas.Local.ToBindingList();
						DialogResult dr = frm.ShowDialog();
						
						if (dr == DialogResult.OK)
						{
							textBoxCuentaID.Text = frm.cuentaSeleccionada.CodigoBalance;
							textBoxCuenta.Text = frm.cuentaSeleccionada.Nombre;
							textBoxCuentaID.Enabled = false;
						}
					}
				}
			}
		}

		private void textBoxCuentaID_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		//private void dataGridViewAyuda_DoubleClick(object sender, EventArgs e)
		//{
		//	if (dataGridViewAyuda.CurrentRow.Index != -1)
		//	{
		//		Cuenta p = new Cuenta();
		//		p.Id = Convert.ToInt32(dataGridViewAyuda.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
		//		using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
		//		{
		//			p = context.Cuentas.Where(x => x.Id == p.Id).FirstOrDefault();
		//			textBoxCuenta.Text = p.Nombre;
		//			textBoxCuentaID.Text = Convert.ToString(p.Id);
		//		}
		//		dataGridViewAyuda.Visible = false;
		//	}
		//}

		private int calcularNumeroRenglon()
		{
			return 0;
		}

		private void textBoxDebe_MouseClick(object sender, MouseEventArgs e)
		{
			textBoxHaber.Enabled = false;
		}

		private void textBoxDebe_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace( textBoxDebe.Text))
				textBoxHaber.Enabled = true;

			Double value;
			if (Double.TryParse(textBoxDebe.Text, out value))
				textBoxDebe.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
			else
				textBoxDebe.Text = String.Empty;
		}

		private void textBoxHaber_MouseClick(object sender, MouseEventArgs e)
		{
			textBoxDebe.Enabled = false;
		}

		private void textBoxHaber_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxHaber.Text))
				textBoxDebe.Enabled = true;

			Double value;
			if (Double.TryParse(textBoxHaber.Text, out value))
				textBoxHaber.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
			else
				textBoxHaber.Text = String.Empty;
		}

		private void textBoxCuentaID_Leave(object sender, EventArgs e)
		{
			//dataGridViewAyuda.Visible = false;
		}

		private void limpiarCamposRenglon()
		{
			textBoxCuenta.Clear();
			textBoxCuentaID.Clear();
			textBoxLeyenda.Clear();
			textBoxDebe.Clear();
			textBoxHaber.Clear();
			textBoxDebe.Enabled = true;
			textBoxHaber.Enabled = true;
			textBoxCuentaID.Enabled = true;
			//dataGridViewAyuda.Visible = false;
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			limpiarCamposRenglon();
		}

		private void buttonCargar_Click(object sender, EventArgs e)
		{
			//TODO asegurarse deque todoslos campos esten validados

			Renglon r = new Renglon();

			Cuenta c = new Cuenta();
			int cuentaId = (string.IsNullOrWhiteSpace(textBoxCuentaID.Text)) ? 0 : Convert.ToInt32(textBoxCuentaID.Text);

			c = contextGlobal.Cuentas.Where(x => x.Id == cuentaId).FirstOrDefault();

			r.NumeroAsiento = Convert.ToInt32(textBoxNAsiento.Text);
			r.FechaContabilidad = dateTimePickerContabilidad.Value;
			r.Tipo = (Renglon.enumTipo)comboBoxTipo.SelectedItem;
			r.NumeroRenglon = Convert.ToInt32(textBoxNRenglon.Text);
			r.IdCuenta = Convert.ToInt32(textBoxCuentaID.Text);
			r.FechaVencimiento = dateTimePickerVencimiento.Value;
			r.FechaOperacion = dateTimePickerOperacion.Value;

			
			r.Debe = (string.IsNullOrWhiteSpace(textBoxDebe.Text)) ? 0 : Convert.ToDecimal(textBoxDebe.Text);
			r.Haber = (string.IsNullOrWhiteSpace(textBoxHaber.Text)) ? 0 : Convert.ToDecimal(textBoxHaber.Text);

			r.Leyenda = textBoxLeyenda.Text;

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Renglones.Add(r);
				context.Cuentas.Attach(c);
				r.Cuenta = c;

				try
				{
					context.SaveChanges();
				}
				catch (Exception ex)
				{ throw ex; }
			}

			//todo cambiar el campo numero renglon
		}

		private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//agarrar si hay una fila seleccionada en la grilla y ponerla en los campos
		}

		private void textBoxDebe_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
		}

		private void textBoxHaber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//darle al usuario a elegir el asiento a retomar que todavia no fue pasado a la tabla diario/mayor
		}
	}
}
