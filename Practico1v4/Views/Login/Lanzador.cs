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
