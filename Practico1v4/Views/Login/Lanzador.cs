﻿using Practico1v4.Helpers;
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
        VentasDBContext contextGlobal = new VentasDBContext();

        private async Task loadContext()
        {
            await contextGlobal.Usuarios.LoadAsync();
        }

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
				Common.UsuarioData.usuario = contextGlobal.Usuarios.Where(u => u.Username == usuarioIngresado).Include(u => u.Rol).SingleOrDefault();
				DialogResult = DialogResult.OK;
			}
		}

		

		private bool loginCorrecto(string usu, string pass)
        {
			Usuario usuario = contextGlobal.Usuarios.SingleOrDefault(u => u.Username == usu);
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
            contextGlobal.Usuarios.Load();
		}

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
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
	}
}
