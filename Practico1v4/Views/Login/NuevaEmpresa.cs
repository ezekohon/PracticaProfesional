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
	public partial class NuevaEmpresa : Form
	{
		public NuevaEmpresa()
		{
			InitializeComponent();
		}

		private void buttonCrear_Click(object sender, EventArgs e)
		{
			if (! string.IsNullOrWhiteSpace(textBoxNombre.Text))
			{
				try
				{
					Models.Helpers.DatabaseOperations.MigrateDatabase(textBoxNombre.Text);
					buttonCrear.Enabled = false;
					textBoxNombre.Enabled = false;
					Helpers.CreadorMensajes.mensajeObservacion("Empresa creada con éxito.");
				}
				catch (Exception ex)
				{
					throw ex;
				}

			}
				
		}
	}
}
