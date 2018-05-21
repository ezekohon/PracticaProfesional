using Practico1v4.Helpers;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new VentasDBContext())
            {
                context.Usuarios.Load();
                string usuario = textBoxUsuario.Text.Trim();
                string password = textBoxPassword.Text;

                Usuario u = context.Usuarios.Local.SingleOrDefault(u => u.Username == usuario);
                if (u != null)
                {
                    if (Helpers.SecurePasswordHasher.Verify(password, .Password))
                    {
                        //coincide la contrasena
                    }
                    else
                    {
                        using (new CenterWinDialog(this))
                        {
                            MessageBox.Show("Error", "Usuario o contraseña incorrectos");
                        }
                    }
                }
            }
        }
    }
}
