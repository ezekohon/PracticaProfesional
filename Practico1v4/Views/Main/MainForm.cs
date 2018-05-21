using Practico1v4.Helpers;
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
            MessageBoxManager.Cancel = "Cancelar";
            MessageBoxManager.OK = "Aceptar";
            MessageBoxManager.Yes = "Si";
            MessageBoxManager.Register();

            //System.Console.WriteLine(Helpers.SecurePasswordHasher.Hash("super"));
            //System.Console.WriteLine(Helpers.SecurePasswordHasher.Verify("carlos123", "$MYHASH$V1$10000$sYV9A5il3YTkIbvnXDftcsSuUNoGL4c9fDlaxnCXRpNKpVwM"));
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
    }
}
