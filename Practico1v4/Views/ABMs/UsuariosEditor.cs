using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.ABMs
{
	public partial class UsuariosEditor : Form
	{
		public UsuariosEditor()
		{
			InitializeComponent();
		}

		private void UsuariosEditor_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = (currentStatus == status.insertar) ? "Modo insertar" : "Modo editar";
			using (var context = new VentasDBContext())
			{
				comboBoxRol.DataSource = context.Roles.ToList();
				comboBoxRol.DisplayMember = "Nombre";
				comboBoxRol.SelectedIndex = -1;
			}
		}

		public enum status
		{
			ninguno = 0,
			insertar = 1,
			editar = 2
		}

		private status _currentStatus;

		public status currentStatus {
			get { return _currentStatus; }
			set { _currentStatus = value; }
		}

		internal void cargarDatos(DataGridViewRow row) 
		{
			textBoxUsuario.Text = row.Cells["Nombre"].Value.ToString();
			comboBoxRol.SelectedItem = row.Cells["Rol"].Value.ToString();
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			textBoxUsuario.Clear();
			comboBoxRol.SelectedIndex = -1;
		}

		private void buttonConfirmar_Click(object sender, EventArgs e)
		{
			bool puedoInsertar = true;
			if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
			{
				errorProviderUsuario.SetError(textBoxUsuario, "Requerido");
				errorProviderUsuario.BlinkStyle = ErrorBlinkStyle.NeverBlink;
				puedoInsertar = false;
				//return;
			}
			else { errorProviderUsuario.Clear(); }

			if (puedoInsertar)
			{
				using (var context = new VentasDBContext())
				{
					Usuario u = new Usuario();
					Rol rol = (Rol)comboBoxRol.SelectedItem;
					u.Username = textBoxUsuario.Text;
					u.RolId = rol.Id;
					u.Rol = rol;
					
					u.Password = Helpers.SecurePasswordHasher.Hash(textBoxPassword.Text);

					if (currentStatus == status.insertar) //insertar
					{
						context.Usuarios.Add(u);
						context.Roles.Attach(rol);
						
						try
						{
							context.SaveChanges();
						}
						catch (Exception ex)
						{ throw ex; }
					}
					else //editar
					{
						context.Entry(u).State = EntityState.Modified;
						try
						{
							context.SaveChanges();
						}
						catch (Exception ex)
						{ throw ex; }
						this.Close();
					}
				}
				
			}
		}


	}
}
