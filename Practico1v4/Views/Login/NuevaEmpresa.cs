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
					//cambiar, pasarle como param un Tenant
					Models.Tenant tenant = new Models.Tenant();
					tenant.BaseDeDatos = textBoxNombre.Text;
					tenant.UltimoNroAsientoCargando = 1;
					Models.Helpers.DatabaseOperations.MigrateDatabase(tenant);
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
