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

namespace Practico1v4.Views.Facturacion
{
	public partial class EmisionComprobantes : Form
	{
		public EmisionComprobantes()
		{
			InitializeComponent();
		}

		public int NumeroComprobanteCargando { get; set; }
		public tempComprobanteEncabezadoPie ComprobanteCargando { get; set; }

		public decimal Neto21 { get; set; }
		public decimal IVA21 { get; set; }
		public decimal Neto27 { get; set; }
		public decimal IVA27 { get; set; }
		public decimal Exento { get; set; }
		public decimal Total { get; set; }

		private void EmisionComprobantes_Load(object sender, EventArgs e)
		{
			using (var context = new TenantsDBContext())
			{
				var entry = context.Tenants.Find(Common.TenantData.tenant.Id);

				//TODO esto cambiarlo por la tabla de FK tipocomprobante FK punto de venta y ultimo nro comrpobante
				NumeroComprobanteCargando = entry.UltimoNroComprobante;
				aumentarUltimoComprobanteTenant();
			}

			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Clientes.Load();
				comboBoxClientes.ValueMember = "Id";
				comboBoxClientes.DisplayMember = "Nombre";
				comboBoxClientes.DataSource = context.Clientes.Local;
				comboBoxClientes.SelectedIndex = 0;

				context.Articulos.Load();
				comboBoxArticulos.ValueMember = "Id";
				comboBoxArticulos.DisplayMember = "Descripcion";
				comboBoxArticulos.DataSource = context.Articulos.Local;
			}
		}

		private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
		{
			TipoComprobante comprobante;
			Cliente cliente = new Cliente();
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Clientes.Include(x => x.SituacionIVA).Load();
				context.ComprobantePorSituacion.Include(x => x.SituacionIVA).Load();

				cliente = context.Clientes.Where(x => x.Id == ((Cliente)comboBoxClientes.SelectedItem).Id).SingleOrDefault();
				SituacionIVA situacionCliente = cliente.SituacionIVA;
				int situacionClienteID = cliente.SituacionIVAId;
				comprobante = context.ComprobantePorSituacion.Where(x => situacionCliente.Id == x.Id)
					.SingleOrDefault()
					.TipoComprobante;
				context.TiposComprobantesVenta.Where(x => x.Tipo == comprobante).Load();
				comboBoxComprobante.ValueMember = "Id";
				comboBoxComprobante.DisplayMember = "Descripcion";
				comboBoxComprobante.DataSource = context.TiposComprobantesVenta.Local;
			}
		}

		private void cargarGrilla()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.tempComprobantesRenglones
					.Include(r => r.Articulo)
					.Include(r => r.Articulo.TasaIVA)
					.Where(x => x.tempComprobanteEncabezadoPieId == ComprobanteCargando.Id).Load();
				dataGridView1.DataSource = context.tempComprobantesRenglones.Local;
			}
		}

		private void buttonAgregar_Click(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Articulos.Include(x => x.TasaIVA).Load();

				tempComprobanteRenglon renglon = new tempComprobanteRenglon();
				Articulo articulo = new Articulo();
				articulo = context.Articulos.Where(x => x.Id == ((Articulo)comboBoxArticulos.SelectedItem).Id).SingleOrDefault();

				tempComprobanteEncabezadoPie compPadre = new tempComprobanteEncabezadoPie();
				compPadre = ComprobanteCargando;

				renglon.Cantidad = Convert.ToInt32(textBoxCantidad.Text);
				renglon.Importe = renglon.Cantidad * articulo.PrecioNetoVenta;
				
				

				context.tempComprobantesRenglones.Add(renglon);
				context.Articulos.Attach(articulo);
				renglon.Articulo = articulo;
				context.tempComprobantesEncabezadoPie.Attach(compPadre);
				renglon.tempComprobanteEncabezadoPie = compPadre;
				try
				{
					context.SaveChanges();
				}
				catch (Exception ex)
				{ throw ex; }
			}
			cargarGrilla();
			actualizarCamposImportes();
		}

		private void buttonAceptar_Click(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				context.Clientes.Include(x => x.SituacionIVA).Load();
				context.TiposComprobantesVenta.Load();

				tempComprobanteEncabezadoPie comprobante = new tempComprobanteEncabezadoPie();
				Cliente cliente = new Cliente();
				cliente = context.Clientes.Where(x => x.Id == ((Cliente)comboBoxClientes.SelectedItem).Id).SingleOrDefault();
				TipoComprobanteVenta tipo = new TipoComprobanteVenta();
				tipo = context.TiposComprobantesVenta.Where(x => x.Id == ((TipoComprobanteVenta)comboBoxComprobante.SelectedItem).Id).SingleOrDefault();



				comprobante.FechaEmision = dateTimePicker1.Value.Date;

				context.tempComprobantesEncabezadoPie.Add(comprobante);
				context.Clientes.Attach(cliente);
				context.TiposComprobantesVenta.Attach(tipo);

				Tenant empresa = new Tenant();
				using (var context2 = new TenantsDBContext())
				{
					
					
					empresa = context2.Tenants.Find(Common.TenantData.tenant.Id);
				}

				comprobante.Cliente = cliente;
				comprobante.TiposComprobantesVenta = tipo;
				comprobante.Tenant = empresa;

				ComprobanteCargando = comprobante;

				try
				{
					context.SaveChanges();
				}
				catch (Exception ex)
				{ throw ex; }
			}
			panel1.Enabled = false;
		}

		private void aumentarUltimoComprobanteTenant()
		{
			using (var context = new TenantsDBContext())
			{
				var entry = context.Tenants.Find(Common.TenantData.tenant.Id);

				entry.UltimoNroComprobante++;
				context.Entry(entry).CurrentValues.SetValues(entry);
				context.SaveChanges();
				Common.TenantData.tenant = entry;
				//var ten = context.Tenants.Where(x => x.BaseDeDatos == Common.TenantData.tenant.BaseDeDatos).SingleOrDefault();
				//ten.UltimoNroAsientoCargando++;
			}
		}

		private void actualizarCamposImportes()
		{
			Neto21 = 0;
			Neto27 = 0;
			IVA21 = 0;
			IVA27 = 0;
			Exento = 0;
			Total = 0;

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				tempComprobanteRenglon r = (tempComprobanteRenglon)row.DataBoundItem;
				
				switch (r.TasaIVA)
				{
					case "21,00":
						Neto21 = Neto21 + r.Importe;
						IVA21 = IVA21 + r.Importe * Convert.ToDecimal(r.TasaIVA);
						break;
					case "27,00":
						Neto27 = Neto27 + r.Importe;
						IVA27 = IVA27 + r.Importe * Convert.ToDecimal(r.TasaIVA);
						break;
					case "0,00":
						Exento = Exento + r.Importe;
						break;
				}
			}
			textBoxNeto21.Text = string.Format("{0:0.00}", Neto21);//Neto21.ToString();
			textBoxIVA21.Text = string.Format("{0:0.00}", IVA21);//IVA21.ToString();
			textBoxNeto27.Text = string.Format("{0:0.00}", Neto27); //Neto27.ToString();
			textBoxIVA27.Text = string.Format("{0:0.00}", IVA27); //IVA27.ToString();
			textBoxExento.Text = string.Format("{0:0.00}", Exento); //Exento.ToString();

			Total = Neto21 + IVA21 + Neto27 + IVA27 + Exento;
			textBoxTotal.Text = string.Format("{0:0.00}", Total); //Total.ToString();
		}

		private void buttonGuardar_Click(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				ComprobanteEncabezadoPie comprobante = new ComprobanteEncabezadoPie();
				Cliente cliente = new Cliente();
				cliente = context.Clientes.Where(x => x.Id == ((Cliente)comboBoxClientes.SelectedItem).Id).SingleOrDefault();
				TipoComprobanteVenta tipo = new TipoComprobanteVenta();
				tipo = context.TiposComprobantesVenta.Where(x => x.Id == ((TipoComprobanteVenta)comboBoxComprobante.SelectedItem).Id).SingleOrDefault();
				comprobante.FechaEmision = dateTimePicker1.Value.Date;
				comprobante.Neto21 = Neto21;
				comprobante.IVA21 = IVA21;
				comprobante.Neto27 = Neto27;
				comprobante.IVA27 = IVA27;
				comprobante.Exento = Exento;
				comprobante.Total = Total;

				comprobante.NumeroComprobante = NumeroComprobanteCargando;

				context.ComprobantesEncabezadoPie.Add(comprobante);
				context.Clientes.Attach(cliente);
				context.TiposComprobantesVenta.Attach(tipo);

				Tenant empresa = new Tenant();
				using (var context2 = new TenantsDBContext())
				{
					empresa = context2.Tenants.Find(Common.TenantData.tenant.Id);
				}

				comprobante.Cliente = cliente;
				comprobante.TiposComprobantesVenta = tipo;
				comprobante.Tenant = empresa;

				try
				{
					context.SaveChanges();
				}
				catch (Exception ex)
				{ throw ex; }

			}
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				//renglones
				context.Articulos.Include(x => x.TasaIVA).Load();
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					ComprobanteRenglon renglon = new ComprobanteRenglon();
					tempComprobanteRenglon r = (tempComprobanteRenglon)row.DataBoundItem;

					ComprobanteEncabezadoPie compPadre = new ComprobanteEncabezadoPie();
					compPadre = context.ComprobantesEncabezadoPie.Where(x => x.NumeroComprobante == NumeroComprobanteCargando).SingleOrDefault();

					Articulo articulo = new Articulo();
					articulo = context.Articulos.Where(x => x.Id == r.Articulo.Id).SingleOrDefault();


					renglon.Cantidad = r.Cantidad;
					renglon.Importe = r.Importe;

					context.ComprobantesRenglones.Add(renglon);

					context.Articulos.Attach(articulo);
					renglon.Articulo = articulo;
					context.ComprobantesEncabezadoPie.Attach(compPadre);
					renglon.ComprobanteEncabezadoPie = compPadre;

					try
					{
						context.SaveChanges();
					}
					catch (Exception ex)
					{ throw ex; }

				}
			}
		}
	}
}
