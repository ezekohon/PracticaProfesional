using Practico1v4.Helpers;
using Practico1v4.Models;
using Practico1v4.Views.Main;
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
using System.Net.Mail;
using Practico1v4.Views.Login;
using Practico1v4.Models.Helpers;
using System.Data.Entity.Migrations;

namespace Practico1v4
{
    public partial class Lanzador : Form
    {
        public Lanzador()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
			MessageBoxManager.Unregister();
            MessageBoxManager.Cancel = "Cancelar";
            MessageBoxManager.OK = "Aceptar";
            MessageBoxManager.Yes = "Si";
            MessageBoxManager.Register();


		}
		TenantsDBContext contextGlobal = new TenantsDBContext();// = new VentasDBContext(Common.TenantData.tenant.ConnectionString);



        private void button1_Click(object sender, EventArgs e)
        {
			avisarSiLanzarAplicacion();
		}

		private void avisarSiLanzarAplicacion()
		{
			string usuarioIngresado = textBoxUsuario.Text.Trim();
			string passwordIngresado = textBoxPassword.Text;

			if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresado))
			{
				Helpers.CreadorMensajes.mensajeError("Ingrese usuario y contraseña");
			}
			else if (loginCorrecto(usuarioIngresado, passwordIngresado))
			{
				//TODO: cambiar 
				
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					Common.UsuarioData.usuario = context.Usuarios.Where(u => u.Username == usuarioIngresado).Include(u => u.Rol).Include(u => u.Rol.Operaciones).SingleOrDefault();
				}
				DialogResult = DialogResult.OK;
			}
		}

		

		private bool loginCorrecto(string usu, string pass)
        {
			Usuario usuario;
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				//contextGlobal.Usuarios.Load();
				//usuario = contextGlobal.Usuarios.SingleOrDefault(u => u.Username == usu);
				context.Usuarios.Load();
				usuario = context.Usuarios.SingleOrDefault(u => u.Username == usu);
			}
			if (usuario != null && (Helpers.SecurePasswordHasher.Verify(pass, usuario.Password)))
			{
				return true;
			}
			else
			{
				Helpers.CreadorMensajes.mensajeError("Usuario o contraseña incorrectos");
				return false;
			}
		}

		private void Lanzador_Load(object sender, EventArgs e)
        {
            contextGlobal.Tenants.Load();

			//autologin
			Tenant tenant = new Tenant();
			using (var context = new TenantsDBContext())
			{
				tenant = context.Tenants.SingleOrDefault(t => t.BaseDeDatos == "VentasDBContext");
				Common.TenantData.tenant = tenant;
			}

			string usuarioIngresado = "super";
			string passwordIngresado = "super";

			if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresado))
			{
				Helpers.CreadorMensajes.mensajeError("Ingrese usuario y contraseña");
			}
			else if (loginCorrecto(usuarioIngresado, passwordIngresado))
			{
				using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
				{
					Common.UsuarioData.usuario = context.Usuarios.Where(u => u.Username == usuarioIngresado).Include(u => u.Rol).Include(u => u.Rol.Operaciones).SingleOrDefault();
				}
				DialogResult = DialogResult.OK;
			}

			//autologin


		}

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonIngresar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

		private void sendMail()
		{
			MailAddress from = new MailAddress("sis.tercero.j23@gmail.com", "dsads");
			MailAddress to = new MailAddress("ezekohon@gmail.com", "dsads");
			SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
			MailMessage msgMail;

			System.Net.NetworkCredential cred = new System.Net.NetworkCredential("sis.tercero.j23@gmail.com", "analistas");
			client.Credentials = cred;
			client.EnableSsl = true;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			//client.Port = 25;

			Text = "Stuff";
			msgMail = new MailMessage();
			msgMail.From = from;
			msgMail.To.Add(to);
			msgMail.Subject = "test";
			msgMail.Body = Text;
			msgMail.IsBodyHtml = true;
			client.Send(msgMail);
			msgMail.Dispose();
		}

		private void labelOlvidoPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			OlvidoPassword frm = new OlvidoPassword();
			frm.ShowDialog(this);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//var ctx1 = new VentasDBContext("data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=Test; integrated security=SSPI");
			//Models.Helpers.DatabaseOperations.MigrateDatabase(v);
			//ctx1.Database.Initialize(true);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			//NUEVA
			//var ctx1 = new VentasDBContext("data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=Test2; integrated security=SSPI");
			//Models.Helpers.DatabaseOperations.MigrateDatabase(ctx1);

		}

		private void buttonAccederEmpresa_Click(object sender, EventArgs e)
		{
			Tenant tenant = new Tenant();
			using (var context = new TenantsDBContext())
			{
				//siendo serio, tengo que traer por host, ahora solo traigo por nombre de DB
				tenant = context.Tenants.SingleOrDefault(t => t.BaseDeDatos == textBoxTenant.Text);
				if (tenant != null)
				{
					Common.TenantData.tenant = tenant;

					//para que las proximas veces que abra crystal sea rapido. La primera tarda
					Views.Reportes.frmPlanDeCuentasReporte rpt = new Views.Reportes.frmPlanDeCuentasReporte();
					rpt.Show();
					rpt.Hide();
					rpt.Close();
					//rpt.Dispose();

					using (var context2 = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
					{

						context2.Roles.AddOrUpdate(
							new Models.Rol { Id = 1, Nombre = "Super", Privilegio = 1000 },
							new Models.Rol { Id = 2, Nombre = "Supervisor", Privilegio = 600 },
							new Models.Rol { Id = 3, Nombre = "Auditor", Privilegio = 400 },
							new Models.Rol { Id = 4, Nombre = "Base", Privilegio = 100 }
							);
						context2.Operaciones.AddOrUpdate(
							new Models.Operacion { Id = 1, Nombre = "SUPER" },
							new Models.Operacion { Id = 2, Nombre = "USUARIOS_CONSULTAR" },
							new Models.Operacion { Id = 3, Nombre = "USUARIOS_MODIFICAR" },
							new Models.Operacion { Id = 4, Nombre = "USUARIOS_ALTABAJA" },
							new Models.Operacion { Id = 5, Nombre = "USUARIOS_SUPER" },
							new Models.Operacion { Id = 6, Nombre = "PUNTOSDEVENTA_CONSULTAR" },
							new Models.Operacion { Id = 7, Nombre = "PUNTOSDEVENTA_MODIFICAR" },
							new Models.Operacion { Id = 8, Nombre = "PUNTOSDEVENTA_ALTABAJA" },
							new Models.Operacion { Id = 9, Nombre = "PUNTOSDEVENTA_SUPER" },
							new Models.Operacion { Id = 10, Nombre = "VENDEDORES_CONSULTAR" },
							new Models.Operacion { Id = 11, Nombre = "VENDEDORES_MODIFICAR" },
							new Models.Operacion { Id = 12, Nombre = "VENDEDORES_ALTABAJA" },
							new Models.Operacion { Id = 13, Nombre = "VENDEDORES_SUPER" },
							new Models.Operacion { Id = 14, Nombre = "AUDITORIAS_CONSULTAR" },
							new Models.Operacion { Id = 15, Nombre = "BACKUP" },
							new Models.Operacion { Id = 16, Nombre = "RESTAURAR" }
							);
						context2.Cuentas.AddOrUpdate(
							new Cuenta { Tipo = 0, Nombre = "Activo", CodigoBalance = "1", CodigoPadre = "0" },
							new Cuenta { Tipo = 0, Nombre = "Activo Corriente", CodigoBalance = "1.1", CodigoPadre = "1" },
							new Cuenta { Tipo = 0, Nombre = "Disponibilidades", CodigoBalance = "1.1.01", CodigoPadre = "1.1" },
							new Cuenta { Tipo = 1, Nombre = "Cajas", CodigoBalance = "1.1.01.01", CodigoPadre = "1.1.01" },
							new Cuenta { Tipo = 0, Nombre = "Bancos", CodigoBalance = "1.1.01.02", CodigoPadre = "1.1.01" },
							new Cuenta { Tipo = 1, Nombre = "Banco Pcia. Cta.Cte.", CodigoBalance = "1.1.01.02.01", CodigoPadre = "1.1.01.02" },
							new Cuenta { Tipo = 1, Nombre = "Banco Nacion Cta.Cte", CodigoBalance = "1.1.01.02.02", CodigoPadre = "1.1.01.02" },
							new Cuenta { Tipo = 0, Nombre = "Cuentas Por Cobrar", CodigoBalance = "1.1.02", CodigoPadre = "1.1" },
							new Cuenta { Tipo = 1, Nombre = "Deudores en Cta.Cte", CodigoBalance = "1.1.02.01", CodigoPadre = "1.1.02" },
							new Cuenta { Tipo = 1, Nombre = "Documentos a Cobrar", CodigoBalance = "1.1.02.02", CodigoPadre = "1.1.02" },
							new Cuenta { Tipo = 1, Nombre = "IVA Credito Fiscal", CodigoBalance = "1.1.02.03", CodigoPadre = "1.1.02" },
							new Cuenta { Tipo = 0, Nombre = "Bienes De Cambio", CodigoBalance = "1.1.03", CodigoPadre = "1.1" },
							new Cuenta { Tipo = 0, Nombre = "Inversiones", CodigoBalance = "1.1.04", CodigoPadre = "1.1" },
							new Cuenta { Tipo = 0, Nombre = "Activos No Corrientes", CodigoBalance = "1.2", CodigoPadre = "1" },
							new Cuenta { Tipo = 0, Nombre = "Bienes de Uso", CodigoBalance = "1.2.01", CodigoPadre = "1.2" },
							new Cuenta { Tipo = 0, Nombre = "Pasivo", CodigoBalance = "2", CodigoPadre = "0" },
							new Cuenta { Tipo = 1, Nombre = "Rodados", CodigoBalance = "1.2.01.01", CodigoPadre = "1.2.01" },
							new Cuenta { Tipo = 1, Nombre = "Muebles y utiles", CodigoBalance = "1.2.01.02", CodigoPadre = "1.2.01" },
							new Cuenta { Tipo = 0, Nombre = "Pasivo Corriente", CodigoBalance = "2.1", CodigoPadre = "0" },
							new Cuenta { Tipo = 0, Nombre = "Deudas", CodigoBalance = "2.1.01", CodigoPadre = "2.1" },
							new Cuenta { Tipo = 0, Nombre = "Deudas Comerciales", CodigoBalance = "2.1.01.01", CodigoPadre = "2.1.01" },
							new Cuenta { Tipo = 1, Nombre = "Proveedores", CodigoBalance = "2.1.01.01.01", CodigoPadre = "2.1.01.01" },
							new Cuenta { Tipo = 1, Nombre = "Obligaciones a Pagar", CodigoBalance = "2.1.01.01.02", CodigoPadre = "2.1.01.01" },
							new Cuenta { Tipo = 0, Nombre = "Deudas Fiscales", CodigoBalance = "2.1.01.02", CodigoPadre = "2.1.01" },
							new Cuenta { Tipo = 1, Nombre = "IVA Debito Fiscal", CodigoBalance = "2.1.01.02.01", CodigoPadre = "2.1.01.02" },
							new Cuenta { Tipo = 1, Nombre = "IVA Percepciones", CodigoBalance = "2.1.01.02.02", CodigoPadre = "2.1.01.02" },
							new Cuenta { Tipo = 1, Nombre = "Ingresos Brutos a Pagar", CodigoBalance = "2.1.01.02.03", CodigoPadre = "2.1.01" },
							new Cuenta { Tipo = 0, Nombre = "Deudas Previsionales", CodigoBalance = "2.1.01.03", CodigoPadre = "2.1.01" },
							new Cuenta { Tipo = 1, Nombre = "Sueldos a Pagar", CodigoBalance = "2.1.01.03.01", CodigoPadre = "2.1.01.03" },
							new Cuenta { Tipo = 1, Nombre = "Cargas Sociales a Pagar", CodigoBalance = "2.1.01.03.02", CodigoPadre = "2.1.01.03" },
							new Cuenta { Tipo = 0, Nombre = "Deudas Bancarias", CodigoBalance = "2.1.01.04", CodigoPadre = "2.1.01" },
							new Cuenta { Tipo = 0, Nombre = "Pasivo no Corriente", CodigoBalance = "2.2", CodigoPadre = "2" },
							new Cuenta { Tipo = 0, Nombre = "Patrimonio Neto", CodigoBalance = "3", CodigoPadre = "0" },
							new Cuenta { Tipo = 0, Nombre = "Capital", CodigoBalance = "3.1", CodigoPadre = "3" },
							new Cuenta { Tipo = 1, Nombre = "Capital Social", CodigoBalance = "3.1.01", CodigoPadre = "3.1" },
							new Cuenta { Tipo = 0, Nombre = "Reservas", CodigoBalance = "3.2", CodigoPadre = "3" },
							new Cuenta { Tipo = 0, Nombre = "Resultados Acumulados", CodigoBalance = "3.3", CodigoPadre = "3" },
							new Cuenta { Tipo = 1, Nombre = "Resultado Ejercicio Anterior", CodigoBalance = "3.3.01", CodigoPadre = "3.3" },
							new Cuenta { Tipo = 0, Nombre = "Resultado Positivo", CodigoBalance = "4", CodigoPadre = "0" },
							new Cuenta { Tipo = 0, Nombre = "Ingresos Ordinarios", CodigoBalance = "4.1", CodigoPadre = "4" },
							new Cuenta { Tipo = 1, Nombre = "Ventas", CodigoBalance = "4.1.01", CodigoPadre = "4.1" },
							new Cuenta { Tipo = 1, Nombre = "Intereses Obtenidos", CodigoBalance = "4.1.02", CodigoPadre = "4.1" },
							new Cuenta { Tipo = 1, Nombre = "Descuentos Obtenidos", CodigoBalance = "4.1.03", CodigoPadre = "4.1" },
							new Cuenta { Tipo = 0, Nombre = "Ingresos Extraordinarios", CodigoBalance = "4.2", CodigoPadre = "4" },
							new Cuenta { Tipo = 0, Nombre = "Resultado Negativo", CodigoBalance = "5", CodigoPadre = "0" },
							new Cuenta { Tipo = 0, Nombre = "Gastos de Comercializacion", CodigoBalance = "5.1", CodigoPadre = "5" },
							new Cuenta { Tipo = 1, Nombre = "Costo de Venta", CodigoBalance = "5.1.01", CodigoPadre = "5.1" },
							new Cuenta { Tipo = 0, Nombre = "Gastos Administrativos", CodigoBalance = "5.2", CodigoPadre = "5" },
							new Cuenta { Tipo = 1, Nombre = "Agua, luz y gas", CodigoBalance = "5.2.01", CodigoPadre = "5.2" },
							new Cuenta { Tipo = 1, Nombre = "Impuestos", CodigoBalance = "5.2.02", CodigoPadre = "5.2" },
							new Cuenta { Tipo = 1, Nombre = "Telefono", CodigoBalance = "5.2.03", CodigoPadre = "5.2" },
							new Cuenta { Tipo = 0, Nombre = "Gastos en Personal", CodigoBalance = "5.3", CodigoPadre = "5" },
							new Cuenta { Tipo = 1, Nombre = "Sueldos y Jornales", CodigoBalance = "5.3.01", CodigoPadre = "5.3" },
							new Cuenta { Tipo = 1, Nombre = "Cargas Sociales", CodigoBalance = "5.3.02", CodigoPadre = "5.3" },
							new Cuenta { Tipo = 0, Nombre = "Gastos Financieros", CodigoBalance = "5.4", CodigoPadre = "5" },
							new Cuenta { Tipo = 1, Nombre = "Intereses Cedidos", CodigoBalance = "5.4.01", CodigoPadre = "5.4" },
							new Cuenta { Tipo = 1, Nombre = "Descuentos Cedidos", CodigoBalance = "5.4.02", CodigoPadre = "5.4" },
							new Cuenta { Tipo = 1, Nombre = "Gastos Bancarios", CodigoBalance = "5.4.03", CodigoPadre = "5.4" },
							new Cuenta { Tipo = 0, Nombre = "Otros Gastos", CodigoBalance = "5.5", CodigoPadre = "5" }
							);
						//context2.SaveChanges();

						try
						{
							// Your code...
							// Could also be before try if you know the exception occurs in SaveChanges

							context2.SaveChanges();
						}
						catch (System.Data.Entity.Validation.DbEntityValidationException ex)
						{
							foreach (var eve in ex.EntityValidationErrors)
							{
								Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
									eve.Entry.Entity.GetType().Name, eve.Entry.State);
								foreach (var ve in eve.ValidationErrors)
								{
									Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
										ve.PropertyName, ve.ErrorMessage);
								}
							}
							throw;
						}


						//context2.Usuarios.Load();
					}
					using (var context2 = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
					{
						context2.Usuarios.AddOrUpdate(
							new Usuario { Id = 1, Username = "super", Password = "$MYHASH$V1$10000$ORJGEFlUuFSyLCDFA4Om0+fZxePwDhchY3QRDpYjww/SM4+M", RolId = 1, Rol = context2.Roles.Where(r => r.Id == 1).Single() }
							);

						Rol super = context2.Roles.Where(r => r.Id == 1).Single();
						super.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 1).Single());
						Rol supervisor = context2.Roles.Where(r => r.Id == 2).Single();
						supervisor.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 16).Single());
						supervisor.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 5).Single());
						Rol auditor = context2.Roles.Where(r => r.Id == 3).Single();
						auditor.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 14).Single());

						Rol basee = context2.Roles.Where(r => r.Id == 4).Single();
						basee.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 6).Single());
						basee.Operaciones.Add(context2.Operaciones.Where(o => o.Id == 10).Single());

						context2.SaveChanges();
					}

					textBoxPassword.Enabled = true;
					textBoxUsuario.Enabled = true;
					buttonIngresar.Enabled = true;
					buttonAccederEmpresa.Enabled = false;
					textBoxTenant.Enabled = false;
				}
				else
				{
					Helpers.CreadorMensajes.mensajeError("No existe la empresa");
				}
			}
		}

		private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NuevaEmpresa frm = new NuevaEmpresa();
			frm.ShowDialog(this);
			textBoxPassword.Enabled = false;
			textBoxUsuario.Enabled = false;
			buttonIngresar.Enabled = true;
		}
	}
}
