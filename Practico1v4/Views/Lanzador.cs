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

namespace Practico1v4
{
    public partial class Lanzador : Form
    {
        public Lanzador()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-AR");
            CultureInfo.DefaultThreadCurrentCulture = new System.Globalization.CultureInfo("es-AR");
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
            //using (var context = new VentasDBContext())
            //{
                //context.Usuarios.Load();
                string usuarioIngresado = textBoxUsuario.Text.Trim();
                string passwordIngresado = textBoxPassword.Text;

            //Usuario usuario = contextGlobal.Usuarios.SingleOrDefault(u => u.Username == usuarioIngresado);
            //var query = from u in context.Usuarios
            //            where u.Username == usuarioIngresado
            //            select new
            //            {
            //                u.Username,
            //                u.Password
            //            };
            //var usuario = query.SingleOrDefault();
            //if (usuario != null && (Helpers.SecurePasswordHasher.Verify(passwordIngresado, usuario.Password)))
            //{
            //    if (Helpers.SecurePasswordHasher.Verify(passwordIngresado, usuario.Password))
            //    {
            //        //coincide la contrasena
            //    }
            //}
            //else
            //{
            //    using (new CenterWinDialog(this))
            //    {
            //        MessageBox.Show( "Usuario o contraseña incorrectos", "Error");
            //    }
            //}
            if (loginCorrecto(usuarioIngresado, passwordIngresado))
            {
				//TODO: cambiar 
				Common.UsuarioData.usuario = contextGlobal.Usuarios.Where(u => u.Username == usuarioIngresado).Include(u => u.Roles).SingleOrDefault();
				//var query = from u in contextGlobal.Usuarios
				//			join r in contextGlobal.Roles on u.Id equals r.Usuarios.

				DialogResult = DialogResult.OK;
			}


            //}
        }

        private bool loginCorrecto(string usu, string pass)
        {
            if (string.IsNullOrEmpty(usu) || string.IsNullOrEmpty(pass))
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Ingrese usuario y contraseña", "Error");
                }
                return false;
            }
            else
            {
                Usuario usuario = contextGlobal.Usuarios.SingleOrDefault(u => u.Username == usu);
                if (usuario != null && (Helpers.SecurePasswordHasher.Verify(pass, usuario.Password)))
                {
                    return true;
                }
                else
                {
                    using (new CenterWinDialog(this))
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                    }
                    return false;
                }
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
    }
}
