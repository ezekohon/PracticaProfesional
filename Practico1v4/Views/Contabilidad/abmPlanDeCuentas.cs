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
	public partial class abmPlanDeCuentas : Form
	{
		public abmPlanDeCuentas()
		{
			InitializeComponent();
		}
		public bool EspaciosPuestos { get; set; } = false;

		public string AccionActual { get; set; }

		public Cuenta CuentaSeleccionada { get; set; }

		VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

		private void PlanDeCuentas_Load(object sender, EventArgs e)
		{
			actualizarGrilla();
			dataGridView1.ClearSelection();
			comboBoxTipo.DataSource = Enum.GetValues(typeof(enumCuentas));
		}

		private enum enumCuentas
		{
			Título = 0,
			NoImputable = 1
		}

		private void actualizarGrilla()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Cuentas.OrderBy(x => x.CodigoBalance).Load();
				//var cuentasPadres = context.Cuentas.Where(c=> c.IdPadre == null);
				//TreeNode parentNode = new TreeNode();
				this.dataGridView1.DataSource = context.Cuentas.Local.ToBindingList();
			}
			EspaciosPuestos = false;
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			foreach(DataGridViewRow row in dataGridView1.Rows)
			{
				if ((int)row.Cells["Tipo"].Value == 0)
				{
					row.DefaultCellStyle.BackColor = Color.Yellow;
				}
				
				//string codbalance = (string)row.Cells["CodigoBalance"].Value;
				//int puntos = codbalance.Count(x => x == '.');
			}


		}

		private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			if (!EspaciosPuestos) { 
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					string cod = (string)row.Cells["CodigoBalance"].Value;//(string)dataGridView1.Rows[e.RowIndex].Cells["CodigoBalance"].Value;
					int puntos = cod.Count(x => x == '.');
					for (int i = 0; i < puntos; i++)
					{
						row.Cells["Nombre"].Value = "  " + (string)row.Cells["Nombre"].Value;
					}
				}
				EspaciosPuestos = true;
			}

		}

		private void buttonReporte_Click(object sender, EventArgs e)
		{
			Reportes.frmPlanDeCuentasReporte rpt = new Reportes.frmPlanDeCuentasReporte();
			rpt.ShowDialog(this);
		}

		private void toolStripButtonReporte_Click(object sender, EventArgs e)
		{
			Reportes.frmPlanDeCuentasReporte rpt = new Reportes.frmPlanDeCuentasReporte();
			rpt.ShowDialog(this);
		}

		private void toolStripButtonInsertar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				var row = dataGridView1.SelectedRows[0];
				Cuenta c = (Cuenta)row.DataBoundItem;
				if (c.Tipo == 0)
				{
					panel1.Enabled = true;
					textBoxCodBalance.Text = c.CodigoBalance;
					AccionActual = "A";
				}
				else
				{
					Helpers.CreadorMensajes.mensajeObservacion("Seleccione una cuenta título.");
				}
			}
			else
			{
				Helpers.CreadorMensajes.mensajeObservacion("Seleccione una fila para determinar el padre de la cuenta a ingresar.");
			}
		}

		private void toolStripButtonBorrar_Click(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				if (CuentaSeleccionada.Tipo == 1)
				{
					DialogResult r = Helpers.CreadorMensajes.mensajeEliminar("la Cuenta");
					if (r != DialogResult.Cancel)
					{
						//attach porque la entity no fue cargada en el mismo context
						context.Cuentas.Attach(CuentaSeleccionada);

						context.Cuentas.Remove(CuentaSeleccionada);
						context.SaveChanges();
						actualizarGrilla();
					}
				}
				else
					Helpers.CreadorMensajes.mensajeError("No puede eliminar una cuenta título.");
				
			}
		}

		private void textBoxCodBalanceHijo_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) || textBoxCodBalanceHijo.Text.Length == 2)
			{
				e.Handled = true;
			}
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			Cuenta c = new Cuenta();
			c.CodigoBalance = (String.IsNullOrWhiteSpace(textBoxCodBalanceHijo.Text)) ? textBoxCodBalance.Text : textBoxCodBalance.Text + '.' + textBoxCodBalanceHijo.Text;
			//si dejo actualizar el codigo de balance tengo que ir a cambiar todos los codbalancepadre
			c.CodigoPadre = textBoxCodBalance.Text;
			c.Nombre = textBoxNombre.Text;
			c.Tipo = (int)comboBoxTipo.SelectedItem;
			if (AccionActual == "M")
				c.Id = CuentaSeleccionada.Id;

			bool errorCodBalance = false;
			string mensaje = string.Empty;

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				if (context.Cuentas.Any(x => x.CodigoBalance == c.CodigoBalance))
					errorCodBalance = true;
			}

			if (errorCodBalance && AccionActual == "A")
				mensaje = "El código balance ya existe";

			if (string.IsNullOrWhiteSpace(mensaje))
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					if (AccionActual == "A")
					{
						try
						{
							context.Cuentas.Add(c);
							context.SaveChanges();
						}
						catch (Exception ex)
						{ throw ex; }

					}
					else
					{
						try
						{
							var entry = context.Cuentas.Find(CuentaSeleccionada.Id);
							context.Entry(entry).CurrentValues.SetValues(c);
							context.SaveChanges();
						}
						catch (Exception ex)
						{ throw ex; }
					}
				}

				panel1.Enabled = false;
				limpiarCampos();
				actualizarGrilla();
			}
			else
				Helpers.CreadorMensajes.mensajeError(mensaje);
		}

		private void toolStripButtonEditar_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				var row = dataGridView1.SelectedRows[0];
				Cuenta c = (Cuenta)row.DataBoundItem;
				//CuentaSeleccionada = c;
				panel1.Enabled = true;
				textBoxCodBalance.Text = c.CodigoBalance;
				textBoxNombre.Text = c.Nombre.Trim();
				comboBoxTipo.SelectedItem = (enumCuentas)Enum.ToObject(typeof(enumCuentas), c.Tipo);
				comboBoxTipo.Enabled = false;

				textBoxCodBalanceHijo.Enabled = false;
				AccionActual = "M";
			}
			else
			{
				Helpers.CreadorMensajes.mensajeObservacion("Seleccione una fila para modificar.");
			}

		}

		private void limpiarCampos()
		{
			textBoxCodBalance.Clear();
			textBoxCodBalanceHijo.Clear();
			textBoxNombre.Clear();
			textBoxCodBalanceHijo.Enabled = true;
			comboBoxTipo.Enabled = true;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			CuentaSeleccionada = (Cuenta)dataGridView1.SelectedRows[0].DataBoundItem;
		}

		private void textBoxBuscar_TextChanged(object sender, EventArgs e)
		{
			string filter = textBoxBuscar.Text;
			dataGridView1.DataSource = contextGlobal.Cuentas.Where(x => x.Nombre.Contains(filter)).ToList();
		}
	}
}
