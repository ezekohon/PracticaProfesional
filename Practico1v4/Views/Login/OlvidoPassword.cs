using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Login
{
	public partial class OlvidoPassword : Form
	{
		public OlvidoPassword()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string usuario = textBox1.Text.Trim();
			string mail = textBox2.Text.Trim();

			if (validarUsuarioYMail(usuario, mail))
			{
				//mandarle mail con la nueva cotrasena temp no hasheada, o mandar token?
			}
			else
				Helpers.CreadorMensajes.mensajeError("El nombre de usuario y mail no coinciden");

		}

		private bool validarUsuarioYMail(string usuarioIngresado, string mailIngresado)
		{
			Usuario usuario = new Usuario();
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				usuario = (context.Usuarios.Where(u => u.Username == usuarioIngresado && u.Mail == mailIngresado).SingleOrDefault());
			}
			return (usuario != null);		
		}
	}
}
