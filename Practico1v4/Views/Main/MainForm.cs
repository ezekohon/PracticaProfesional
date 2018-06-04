using Practico1v4.Helpers;
using Practico1v4.Views.ABMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Main
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

			setupPermisos();
        }

        private void puntoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoDeVentasABM form = new PuntoDeVentasABM();
            form.ShowDialog(this);
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
			VendedoresABM form = new VendedoresABM();
            form.ShowDialog(this);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

		private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UsuariosABM form = new UsuariosABM();
			form.ShowDialog(this);
		}

		private void auditoríasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Auditorias.MainAuditorias form = new Auditorias.MainAuditorias();
			form.ShowDialog(this);
		}

		private void setupPermisos()
		{
			//if (! Common.UsuarioData.usuarioTieneAccesoOperacion(Common.UsuarioData.operaciones.AUDITORIAS_CONSULTAR))
			//{
			//	auditoríasToolStripMenuItem.Enabled = false;
			//}
			//if (! Common.UsuarioData.usuarioTieneAccesoOperacion(Common.UsuarioData.operaciones.USUARIOS_SUPER))
			//{
			//	usuariosToolStripMenuItem.Enabled = false;
			//}
			//if (!Common.UsuarioData.usuarioTieneAccesoOperacion(Common.UsuarioData.operaciones.PUNTOSDEVENTA_CONSULTAR))
			//{
			//	puntoDeVentasToolStripMenuItem.Enabled = false;
			//}
			//if (!Common.UsuarioData.usuarioTieneAccesoOperacion(Common.UsuarioData.operaciones.VENDEDORES_CONSULTAR))
			//{
			//	vendedoresToolStripMenuItem.Enabled = false;
			//}

			SetupPermisosHelper.instance.setupMenuPorOperacion(auditoríasToolStripMenuItem, Common.UsuarioData.operaciones.AUDITORIAS_CONSULTAR);
			SetupPermisosHelper.instance.setupMenuPorOperacion(usuariosToolStripMenuItem, Common.UsuarioData.operaciones.USUARIOS_SUPER);
			SetupPermisosHelper.instance.setupMenuPorOperacion(puntoDeVentasToolStripMenuItem, Common.UsuarioData.operaciones.PUNTOSDEVENTA_CONSULTAR);
			SetupPermisosHelper.instance.setupMenuPorOperacion(vendedoresToolStripMenuItem, Common.UsuarioData.operaciones.VENDEDORES_CONSULTAR);
		}

		private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//this.Hide();
			//Lanzador frm = new Lanzador();
			//frm.Show();
			Application.Restart();
		}
	}
}
