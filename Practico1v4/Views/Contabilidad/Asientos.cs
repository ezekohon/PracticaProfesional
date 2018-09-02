using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public string AccionActual { get; set; }

		public int NroAsientoCargando { get; set; }

		public int NroRenglonActual { get; set; }
		public Renglon RenglonActual { get; set; }
		public decimal DebeActual { get; set; }
		public decimal HaberActual { get; set; }

		private void Asientos_Load(object sender, EventArgs e)
		{
			comboBoxTipo.DataSource = Enum.GetValues(typeof(enumTipo));
			if (DateTime.Now.Date != Common.TenantData.tenant.FechaInicioEjercicioContable)
			{
				comboBoxTipo.DataSource = Enum.GetValues(typeof(enumTipo))
					.Cast<enumTipo>()
					.Where(x => x != enumTipo.Apertura)
					.ToArray();

				if (DateTime.Now.Date != Common.TenantData.tenant.FechaCierreEjercicioContable)
					comboBoxTipo.DataSource = Enum.GetValues(typeof(enumTipo))
						.Cast<enumTipo>()
						.Where(x => x == enumTipo.Normal)
						.ToArray();
			}

			dateTimePickerOperacion.Value = dateTimePickerContabilidad.Value;
			dateTimePickerVencimiento.Value = dateTimePickerContabilidad.Value;


			dateTimePickerRPTDesde.Value = Common.TenantData.tenant.FechaInicioEjercicioContable;
			dateTimePickerRPTHasta.Value = Common.TenantData.tenant.FechaCierreEjercicioContable;

			//comentado para desarrollo, pero va
			//dateTimePickerContabilidad.MinDate = Common.TenantData.tenant.FechaInicioEjercicioContable;
			//dateTimePickerContabilidad.MaxDate = Common.TenantData.tenant.FechaCierreEjercicioContable;
		}

		VentasDBContext contextGlobal = new VentasDBContext(Common.TenantData.tenant.ConnectionString);

		private void cargarGrilla()
		{
			//llenar la grilla con los renglones del asiento siendo cargado
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Renglones.Include(r => r.Cuenta).Where(x => x.NumeroAsiento == NroAsientoCargando).Load();
				dataGridView1.DataSource = context.Renglones.Local;
			}
			actualizarDebeHaber();
			calcularDiferenciaDebeHaber();
		}

		private void altaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			deshabilitarAltaRetomar();
			panelDatosAsiento.Enabled = true;
			textBoxNAsiento.Visible = true;
			comboBoxNAsientos.Visible = false;
			aumentarUltimoRenglonCargandoTenant();

			textBoxNAsiento.Text = Common.TenantData.tenant.UltimoNroAsientoCargando.ToString();

			textBoxRPTAsientoDesde.Text = Common.TenantData.tenant.UltimoNroAsientoCargando.ToString();
			textBoxRPTAsientoHasta.Text = Common.TenantData.tenant.UltimoNroAsientoCargando.ToString();


			//using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			//{
			//	context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando).Load();
			//}

		}

		private void buttonAceptarDatosAsiento_Click(object sender, EventArgs e)
		{
			panelDatosAsiento.Enabled = false;
			panelDatosRenglon.Enabled = true;
			NroAsientoCargando = (textBoxNAsiento.Visible) ? Convert.ToInt32(textBoxNAsiento.Text) : Convert.ToInt32(comboBoxNAsientos.Text) ;

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				var reng = context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando).OrderByDescending(y => y.NumeroRenglon).FirstOrDefault();
				NroRenglonActual = (reng != null) ? reng.NumeroRenglon + 1 : 1;
				textBoxNRenglon.Text = NroRenglonActual.ToString();

			}
			cargarGrilla();
			
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
									textBoxCuentaID.Text = frm.cuentaSeleccionada.Id.ToString();
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
							textBoxCuentaID.Text = frm.cuentaSeleccionada.Id.ToString();
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
			if (string.IsNullOrWhiteSpace(textBoxDebe.Text) || Convert.ToDecimal(textBoxDebe.Text) == 0)
				textBoxHaber.Enabled = true;

			Double value;

			if (Double.TryParse(textBoxDebe.Text, out value))
				textBoxDebe.Text = value.ToString("F"); //String.Format("{0:C2}", value);
															   //else
															   //	textBoxDebe.Text = String.Empty;
		}

		private void textBoxHaber_MouseClick(object sender, MouseEventArgs e)
		{
			textBoxDebe.Enabled = false;
		}

		private void textBoxHaber_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxHaber.Text) || Convert.ToDecimal(textBoxHaber.Text) == 0)
				textBoxDebe.Enabled = true;

			Double value;
			if (Double.TryParse(textBoxHaber.Text, out value))
				textBoxHaber.Text = value.ToString("F");
			//	textBoxHaber.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
			//else
			//	textBoxHaber.Text = String.Empty;
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
			int cuentaId = (string.IsNullOrWhiteSpace(textBoxCuentaID.Text)) ? 0 : Convert.ToInt32( textBoxCuentaID.Text);

			c = contextGlobal.Cuentas.Where(x => x.Id == cuentaId).FirstOrDefault();

			r.NumeroAsiento = (textBoxNAsiento.Visible) ? Convert.ToInt32(textBoxNAsiento.Text) : Convert.ToInt32(comboBoxNAsientos.Text);
			r.FechaContabilidad = dateTimePickerContabilidad.Value;
			r.Tipo = (enumTipo)comboBoxTipo.SelectedItem;
			r.NumeroRenglon = Convert.ToInt32(textBoxNRenglon.Text);
			r.IdCuenta = c.Id;
			r.FechaVencimiento = dateTimePickerVencimiento.Value;
			r.FechaOperacion = dateTimePickerOperacion.Value;
			r.Registrado = enumRegistrado.NoRegistrado;
			r.OK_Carga = enumokCarga.OK;

			
			r.Debe = (string.IsNullOrWhiteSpace(textBoxDebe.Text)) ? 0 : Convert.ToDecimal(textBoxDebe.Text);
			r.Haber = (string.IsNullOrWhiteSpace(textBoxHaber.Text)) ? 0 : Convert.ToDecimal(textBoxHaber.Text);

			r.Leyenda = textBoxLeyenda.Text;

			if (AccionActual == "M")
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					r.Id = RenglonActual.Id;
					var entry = context.Renglones.Find(RenglonActual.Id);
					context.Entry(entry).CurrentValues.SetValues(r);
					context.SaveChanges();
				}
			}
			else
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					context.Renglones.Add(r);
					context.Cuentas.Attach(c);
					r.Cuenta = c;

					NroRenglonActual++;
					textBoxNRenglon.Text = NroRenglonActual.ToString();
					try
					{
						context.SaveChanges();
					}
					catch (Exception ex)
					{ throw ex; }
				}
				
			}
			
			cargarGrilla();
			limpiarCamposRenglon();
		}

		private void modificaciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//agarrar si hay una fila seleccionada en la grilla y ponerla en los campos
			
			if (dataGridView1.SelectedRows.Count == 1)
			{
				AccionActual = "M";
				var row = dataGridView1.SelectedRows[0];
				Renglon r = (Renglon)row.DataBoundItem;
				RenglonActual = r;
				cargarEnEdicion(r);
			}
			else
			{
				Helpers.CreadorMensajes.mensajeObservacion("Seleccione un renglón para modificar.");
			}
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
			deshabilitarAltaRetomar();
			panelDatosAsiento.Enabled = true;
			comboBoxNAsientos.Visible = true;
			textBoxNAsiento.Visible = false;
			List<int> listaAsientos = new List<int>();
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				var lista = context.Renglones.GroupBy(x => x.NumeroAsiento);
				foreach(var g in lista)
				{
					listaAsientos.Add(g.FirstOrDefault().NumeroAsiento);
				}
			}
			comboBoxNAsientos.DataSource = listaAsientos;
		}

		private void actualizarDebeHaber()
		{
			DebeActual = 0;
			HaberActual = 0;
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				Renglon c = (Renglon)row.DataBoundItem;
				if (c.Debe != 0)
				{
					DebeActual += c.Debe;
					labelDebe.Text = DebeActual.ToString();
				}
				else
				{
					HaberActual += c.Haber;
					labelHaber.Text = HaberActual.ToString();
				}
			}
		}

		private void calcularDiferenciaDebeHaber()
		{
			labelDiferencia.Text = (HaberActual - DebeActual).ToString(); 
		}

		private void aumentarUltimoRenglonCargandoTenant()
		{
			using (var context = new TenantsDBContext())
			{
				var entry = context.Tenants.Find(Common.TenantData.tenant.Id);

				entry.UltimoNroAsientoCargando++;
				context.Entry(entry).CurrentValues.SetValues(entry);
				context.SaveChanges();
				Common.TenantData.tenant = entry;
				//var ten = context.Tenants.Where(x => x.BaseDeDatos == Common.TenantData.tenant.BaseDeDatos).SingleOrDefault();
				//ten.UltimoNroAsientoCargando++;
			}
		}

		private void cargarEnEdicion(Renglon r)
		{
			textBoxNRenglon.Text = r.NumeroRenglon.ToString();
			textBoxCuenta.Text = r.Cuenta.Nombre;
			textBoxCuentaID.Text = r.IdCuenta.ToString();
			dateTimePickerOperacion.Value = r.FechaOperacion;
			dateTimePickerVencimiento.Value = r.FechaVencimiento;

			textBoxLeyenda.Text = r.Leyenda;

			//if (r.Debe != 0)
			//{
				textBoxDebe.Text = r.Debe.ToString();
				//textBoxDebe.Enabled = true;
			//}
			//else
			//{
				textBoxHaber.Text = r.Haber.ToString();
				//textBoxHaber.Enabled = true;
			//}
			
			
		}

		private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 1)
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					DialogResult r = Helpers.CreadorMensajes.mensajeEliminar("el Renglón");
					if (r != DialogResult.Cancel)
					{
						var row = dataGridView1.SelectedRows[0];
						Renglon renglon = (Renglon)row.DataBoundItem;
						//attach porque la entity no fue cargada en el mismo context
						context.Renglones.Attach(renglon);

						context.Renglones.Remove(renglon);
						context.SaveChanges();
						cargarGrilla();

					}
				}

			}
		}

		private void comboBoxNAsientos_SelectedIndexChanged(object sender, EventArgs e)
		{
			//cargar tipoasiento, fecha contab y la grilla
			NroAsientoCargando = Convert.ToInt32(comboBoxNAsientos.Text);
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				var tipo = context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando).FirstOrDefault().Tipo;
				comboBoxTipo.SelectedItem = tipo;
				var fContab = context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando).FirstOrDefault().FechaContabilidad;
				dateTimePickerContabilidad.Value = fContab;
				var listaRenglones = context.Renglones.Where(x => x.NumeroAsiento == NroAsientoCargando);
				dataGridView1.DataSource = listaRenglones.ToList();
			}
		}

		private void abandonarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				DialogResult r = Helpers.CreadorMensajes.mensajeEliminar("el Asiento entero");
				if (r != DialogResult.Cancel)
				{
					foreach (DataGridViewRow row in dataGridView1.Rows)
					{
						Renglon renglon = (Renglon)row.DataBoundItem;
						//attach porque la entity no fue cargada en el mismo context
						context.Renglones.Attach(renglon);

						context.Renglones.Remove(renglon);
					}
					context.SaveChanges();
					cargarGrilla();
					panelDatosAsiento.Enabled = false;
					panelDatosRenglon.Enabled = false;
					habilitarAltaRetomar();
				}
			}
		}

		private void salirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//chekea el debe/haber
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				if (DebeActual - HaberActual == 0)
				{
					habilitarAltaRetomar();
					panelDatosAsiento.Enabled = false;
					panelDatosRenglon.Enabled = false;
				}
				else
					Helpers.CreadorMensajes.mensajeError("El debe no concuerda con el haber, no puede salir de asiento!");
			}
		}

		private bool validarCampos()
		{
			return true;
		}

		private void dateTimePickerContabilidad_ValueChanged(object sender, EventArgs e)
		{

		}

		private void deshabilitarAltaRetomar()
		{
			altaToolStripMenuItem.Enabled = false;
			toolStripMenuItemRetomar.Enabled = false;
		}
		private void habilitarAltaRetomar()
		{
			altaToolStripMenuItem.Enabled = true;
			toolStripMenuItemRetomar.Enabled = true;
		}

		private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//chekea el debe/haber
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				if (DebeActual - HaberActual == 0)
				{
					this.Close();
				}
				else
					Helpers.CreadorMensajes.mensajeError("El debe no concuerda con el haber, no puede salir de la pantalla!");
			}
		}

		private void listarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reportes.frmRenglonesReporte frm = new Reportes.frmRenglonesReporte();
			frm.NAsientoDesde = Convert.ToInt32(textBoxRPTAsientoDesde.Text);
			frm.NAsientoHasta = Convert.ToInt32(textBoxRPTAsientoHasta.Text);

			frm.ShowDialog(this);
		}

		private void buttonListar_Click(object sender, EventArgs e)
		{
			Reportes.frmRenglonesReporte frm = new Reportes.frmRenglonesReporte();
			frm.NAsientoDesde = Convert.ToInt32(textBoxRPTAsientoDesde.Text);
			frm.NAsientoHasta = Convert.ToInt32(textBoxRPTAsientoHasta.Text);
			frm.FechaDesde = dateTimePickerRPTDesde.Value;
			frm.FechaHasta = dateTimePickerRPTHasta.Value;

			frm.ShowDialog(this);
		}

		private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var asientoDesde = (string.IsNullOrWhiteSpace(textBoxRPTAsientoDesde.Text)) ? 0 : Convert.ToInt32(textBoxRPTAsientoDesde.Text);
			var asientoHasta = (string.IsNullOrWhiteSpace(textBoxRPTAsientoHasta.Text)) ? 0 : Convert.ToInt32(textBoxRPTAsientoHasta.Text);

			if (asientoHasta != 0 && asientoDesde != 0)
			{
				ObservableCollection<Renglon> listaRegistrar = new ObservableCollection<Renglon>();
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					context.Renglones.Where(x => x.NumeroAsiento >= asientoDesde && x.NumeroAsiento <= asientoHasta).Include(y => y.Cuenta).Load();
					listaRegistrar = context.Renglones.Local;
				}

				var agrupadosAsientos = listaRegistrar.GroupBy(x => x.NumeroAsiento);
				bool errorDH = false;
				int asientoError = 0;
				decimal dh = 0;
				foreach(var group in agrupadosAsientos)
				{
					foreach(Renglon r in group)
					{
						dh += (r.Debe != 0) ? r.Debe : -r.Haber;
					}

					if (dh != 0)
					{
						errorDH = true;
						asientoError = group.FirstOrDefault().NumeroAsiento;
					}
					dh = 0;
				}

				if (errorDH)
					Helpers.CreadorMensajes.mensajeError("No puede registrar los asientos, el debe y haber no concuerdan en el asiento " + asientoError.ToString());
				else
				{
					//registrar
					using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
					{
						context.DiarioMayor.Load();
						var ultima = context.DiarioMayor.Local.OrderByDescending(x => x.FechaInsertado).FirstOrDefault();
						int nAsiento = (ultima == null) ? 1 : ultima.NumeroAsiento + 1;
						foreach (var group in agrupadosAsientos)
						{
							int nRenglon = 1;
							foreach (Renglon r in group)
							{
								DiarioMayor dm = new DiarioMayor();
								dm.NumeroAsiento = nAsiento;
								dm.NumeroRenglon = nRenglon;
								dm.FechaContabilidad = r.FechaContabilidad;
								dm.Tipo = r.Tipo;
								dm.FechaOperacion = r.FechaOperacion;
								dm.FechaVencimiento = r.FechaVencimiento;
								dm.FechaInsertado = DateTime.Now;
								dm.IdCuenta = r.IdCuenta;
								dm.Cuenta = r.Cuenta;
								dm.Comprobante = r.Comprobante;
								dm.Leyenda = r.Leyenda;
								dm.Debe = r.Debe;
								dm.Haber = r.Haber;
								dm.Registrado = enumRegistrado.Registrado;

								context.DiarioMayor.Add(dm);
								context.Renglones.Attach(r);
								context.Renglones.Remove(r);
								context.Cuentas.Attach(dm.Cuenta);
								nRenglon++;
							}
							nRenglon = 0;
							nAsiento++;
						}
						try
						{
							context.SaveChanges();
							Helpers.CreadorMensajes.mensajeObservacion("Los asientos han sido registrados con éxito!");
						}
						catch (Exception ex)
						{
							throw ex;
						}

					}
				}
			}
			else
			{
				Helpers.CreadorMensajes.mensajeError("Ingrese numeros de asiento desde y hasta!");
			}

		}

		private void textBoxRPTAsientoDesde_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxRPTAsientoHasta_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
